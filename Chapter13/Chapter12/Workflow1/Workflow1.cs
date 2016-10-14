using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Workflow;
using Microsoft.SharePoint.WorkflowActions;

using System.Collections.Generic;

namespace Chapter12.Workflow1
{
    public sealed partial class Workflow1 : SequentialWorkflowActivity
    {
        public Workflow1()
        {
            InitializeComponent();
        }

        public Guid workflowId = default(System.Guid);
        public SPWorkflowActivationProperties workflowProperties = new SPWorkflowActivationProperties();

        private void codeActivity1_ExecuteCode(object sender, EventArgs e)
        {
            using (SPWeb web = SPContext.Current.Web)
            {
                // Get the Test Cycle that we're working on
                SPListItem cycle = workflowProperties.Item;

                // Get the status of the Test Cycle
                string cycleStatus = cycle["Test Status"] as string;

                // Get the referenced Iteration
                SPFieldLookupValue value =
                   new SPFieldLookupValue(cycle["Iteration"].ToString());
                SPList iterations = web.Lists["Iterations"];
                SPListItem iteration = iterations.GetItemById(value.LookupId);

                // Get the lists that we will need later
                SPList testScenarios = web.Lists["Test Scenarios"];
                SPList testCases = web.Lists["Test Cases"];
                SPList testItems = web.Lists["Test Items"];

                // If the status is Initial, populate the Test Items list
                if (cycleStatus == "Initial")
                {

                    // Iterate through all of the User Stories
                    List<int> userStoryIDs = new List<int>();
                    SPList userStories = web.Lists["User Stories"];
                    foreach (SPListItem userStory in userStories.Items)
                    {
                        if (userStory["Iteration"] != null &&
                            userStory["Iteration"].ToString() ==
                               cycle["Iteration"].ToString())
                            userStoryIDs.Add(userStory.ID);
                    }

                    // Iteration through all of the Test Scenarios
                    List<int> testScenarioIDs = new List<int>();
                    foreach (SPListItem testScenario in testScenarios.Items)
                    {
                        if (testScenario["User Story"] != null)
                        {
                            SPFieldLookupValue userStoryFieldValue =
                             new SPFieldLookupValue(testScenario["User Story"].ToString());

                            if (userStoryIDs.Contains<int>(userStoryFieldValue.LookupId))
                                testScenarioIDs.Add(testScenario.ID);
                        }
                    }

                    // Iteration through all of the Test Cases
                    foreach (SPListItem testCase in testCases.Items)
                    {
                        SPFieldLookupValue testScenarioFieldValue =
                           new SPFieldLookupValue(testCase["Test Scenario"].ToString());

                        if (testScenarioIDs.Contains<int>(testScenarioFieldValue.LookupId))
                        {
                            // Add this Test Case to the test cycle
                            SPListItem testItem = testItems.Items.Add();
                            testItem["Title"] = testCase.Title;
                            testItem["Test Status"] = "Planned";
                            testItem["Test Cycle"] =
                               cycle.ID.ToString() + ";#" + cycle.Title;
                            testItem["Test Case"] =
                               testCase.ID.ToString() + ";#" + testCase.Title;
                            testItem.Update();
                        }
                    }

                    // Mark the test cycle as Planned
                    cycle["Test Status"] = "Planned";
                    cycle.Update();
                }

                if (cycleStatus == "InProgress" || cycleStatus == "Completed")
                {
                    // Retrieve the failed items
                    SPQuery query = new SPQuery();
                    query.Query =
                       "<Where>" +
                          "<And>" +
                             "<Eq>" +
                                "<FieldRef Name='Test_x0020_Cycle' LookupId='TRUE' />" +
                                "<Value Type='Lookup'>" + cycle.ID.ToString() + "</Value>" +
                             "</Eq>" +
                             "<And>" +
                                "<Eq>" +
                                   "<FieldRef Name='Test_x0020_Status' />" +
                                   "<Value Type='Choice'>Completed</Value>" +
                                "</Eq>" +
                                "<Eq>" +
                                   "<FieldRef Name='Test_x0020_Pass_x002f_Fail' />" +
                                   "<Value Type='Boolean'>No</Value>" +
                                "</Eq>" +
                             "</And>" +
                          "</And>" +
                       "</Where>";

                    SPListItemCollection failedItems = testItems.GetItems(query);

                    // If there are any that failed...
                    if (failedItems.Count > 0)
                    {
                        SPContentType defectContent = web.ContentTypes["Iteration Defect"];
                        SPList iterationItems = web.Lists["Iteration Items"];

                        foreach (SPListItem failed in failedItems)
                        {
                            // See if this failure has already been reported
                            SPQuery itemQuery = new SPQuery();
                            itemQuery.Query =
                               "<Where>" +
                                  "<And>" +
                                     "<And>" +
                                        "<And>" +
                                           "<Eq>" +
                                              "<FieldRef Name='Iteration' LookupId='TRUE' />" +
                                              "<Value Type='Lookup'>" +
                                                 iteration.ID.ToString() + "</Value>" +
                                           "</Eq>" +
                                           "<Eq>" +
                                              "<FieldRef Name='ContentType' />" +
                                              "<Value Type='Text'>Iteration Defect</Value>" +
                                           "</Eq>" +
                                        "</And>" +
                                        "<Eq>" +
                                           "<FieldRef Name='Test_x0020_Item' LookupId='TRUE' />" +
                                          "<Value Type='Lookup'>" +
                                             failed.ID.ToString() + "</Value>" +
                                        "</Eq>" +
                                     "</And>" +
                                     "<Or>" +
                                        "<Eq>" +
                                           "<FieldRef Name='Item_x0020_Status' />" +
                                           "<Value Type='Choice'>Pending</Value>" +
                                        "</Eq>" +
                                        "<Eq>" +
                                           "<FieldRef Name='Item_x0020_Status' />" +
                                           "<Value Type='Choice'>InProgress</Value>" +
                                        "</Eq>" +
                                     "</Or>" +
                                  "</And>" +
                               "</Where>";

                            SPListItemCollection matches = iterationItems.GetItems(itemQuery);

                            // If this failure has not been reported...
                            if (matches.Count == 0)
                            {
                                // ...add this failure to the defect list
                                SPListItem defect = iterationItems.Items.Add();
                                defect["ContentTypeId"] = defectContent.Id;
                                defect["Title"] = failed.Title;
                                defect["Item Status"] = "Pending";
                                defect["Iteration"] = iteration.ID.ToString() + ";#" +
                                   iteration.Title;
                                defect["Test Item"] = failed.ID.ToString() + ";#" + failed.Title;

                                // Determine the user story
                                SPFieldLookupValue testCaseFieldValue =
                                   new SPFieldLookupValue(failed["Test Case"].ToString());
                                SPListItem testCase =
                                   testCases.GetItemById(testCaseFieldValue.LookupId);
                                if (testCase != null)
                                {
                                    SPFieldLookupValue testScenarioFieldValue =
                                      new SPFieldLookupValue(testCase["Test Scenario"].ToString());
                                    SPListItem testScenario =
                                       testScenarios.GetItemById(testScenarioFieldValue.LookupId);
                                    if (testScenario != null)
                                    {
                                        defect["User Story"] = testScenario["User Story"];
                                    }
                                }

                                defect.Update();
                            }
                        }
                    }

                    /*------------------------------------*/
                    // Gather TestCycle metrics
                    /*------------------------------------*/
                    // Walk through all the test items
                    int planned = 0;
                    int completed = 0;
                    int cancelled = 0;
                    int failedCount = 0;
                    int weightedDefect = 0;
                    int repeated = 0;

                    SPQuery testItemQuery = new SPQuery();
                    testItemQuery.Query =
                       "<Where>" +
                          "<Eq>" +
                             "<FieldRef Name='Test_x0020_Cycle' LookupId='TRUE' />" +
                             "<Value Type='Lookup'>" + cycle.ID.ToString() + "</Value>" +
                          "</Eq>" +
                       "</Where>";

                    SPListItemCollection items = testItems.GetItems(testItemQuery);
                    foreach (SPListItem item in items)
                    {
                        planned++;
                        string status = item["Test Status"].ToString();
                        switch (status)
                        {
                            case "Completed":
                                completed++;
                                if (item["Test Pass/Fail"].ToString() == "False")
                                {
                                    failedCount++;
                                    weightedDefect += 
                                        int.Parse(item["Defect Severity"].ToString());

                                    if (item["Repeated Defect"].ToString() == "True")
                                        repeated++;
                                }
                                break;

                            case "Cancelled":
                                cancelled++;
                                break;
                        }
                    }

                    // Compute the total story points
                    SPList userStories = web.Lists["User Stories"];
                    int storyPoints = 0;

                    SPQuery userStoryQuery = new SPQuery();
                    userStoryQuery.Query =
                       "<Where>" +
                          "<Eq>" +
                             "<FieldRef Name='Iteration' LookupId='TRUE' />" +
                             "<Value Type='Lookup'>" + iteration.ID.ToString() + "</Value>" +
                          "</Eq>" +
                       "</Where>";

                    SPListItemCollection stories = userStories.GetItems(userStoryQuery);
                    foreach (SPListItem story in stories)
                        storyPoints += int.Parse(story["Story Points"].ToString());

                    // Store the accumulated totals
                    cycle["Repeated Defects"] = repeated;
                    cycle["Test Cases Cancelled"] = cancelled;
                    cycle["Test Cases Completed"] = completed;
                    cycle["Test Cases Failed"] = failedCount;
                    cycle["Test Cases Planned"] = planned;
                    cycle["Weighted Defects"] = weightedDefect;
                    cycle["Story Points"] = storyPoints;

                    cycle.Update();
                }

                // If the status is Completed, accumulate the Iteration metrics
                if (cycleStatus == "Completed")
                {
                    // Walk through all the test cycles for this iteration
                    int initialWeightedDefects = 0;
                    int currentWeightedDefects = 0;
                    int totalCompleted = 0;
                    int totalPlanned = 0;
                    int totalRepeated = 0;
                    int cycleCount = 0;
                    int storyPoints = 0;

                    SPList testCycles = web.Lists["Test Cycles"];

                    SPQuery cycleQuery = new SPQuery();
                    cycleQuery.Query =
                       "<Where>" +
                          "<And>" +
                             "<Eq>" +
                                "<FieldRef Name='Iteration' LookupId='TRUE' />" +
                                "<Value Type='Lookup'>" + iteration.ID.ToString() + "</Value>" +
                             "</Eq>" +
                             "<Eq>" +
                                "<FieldRef Name='Test_x0020_Status' />" +
                                "<Value Type='Choice'>Completed</Value>" +
                             "</Eq>" +
                          "</And>" +
                       "</Where>" +
                       "<OrderBy>" + 
                          "<FieldRef Name='StartDate' />" +
                       "</OrderBy>" ;

                    SPListItem initialCycle = null;
                    SPListItem currentCycle = null;

                    SPListItemCollection items = testCycles.GetItems(cycleQuery);
                    foreach (SPListItem item in items)
                    {
                        cycleCount++;

                        // Since the test cycles are returned in chronological order,
                        // the first one will be the initial cycle and the last one
                        // will be the current (or most recent) test cycle
                        if (initialCycle == null)
                            initialCycle = item;
                        currentCycle = item;

                        totalCompleted += int.Parse(item["Test Cases Completed"].ToString());
                        totalPlanned += int.Parse(item["Test Cases Planned"].ToString());
                        totalRepeated += int.Parse(item["Repeated Defects"].ToString());

                        // Accumulate
                    }

                    // Get the initial and current defect counts
                    if (initialCycle != null)
                        initialWeightedDefects = 
                            int.Parse(initialCycle["Weighted Defects"].ToString());

                    if (currentCycle != null)
                    {
                        currentWeightedDefects = 
                            int.Parse(currentCycle["Weighted Defects"].ToString());
                        storyPoints = int.Parse(currentCycle["Story Points"].ToString());
                    }

                    // Update the iteration
                    iteration["Initial Weighted Defects"] = initialWeightedDefects;
                    iteration["Weighted Defects"] = currentWeightedDefects;
                    iteration["Repeated Defects"] = totalRepeated;
                    iteration["Test Cases Planned"] = totalPlanned;
                    iteration["Test Cases Completed"] = totalCompleted;
                    iteration["Test Cycle Count"] = cycleCount;
                    iteration["Story Points"] = storyPoints;

                    iteration.Update();
                }
            }
        }

    }
}
