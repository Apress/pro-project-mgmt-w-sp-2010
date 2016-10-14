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
using System.Xml.Linq;

namespace Chapter15.Workflow1
{
    public sealed partial class Workflow1 : StateMachineWorkflowActivity
    {
        public Workflow1()
        {
            InitializeComponent();
        }

        public SPWorkflowActivationProperties workflowProperties = new SPWorkflowActivationProperties();

        private string _admin = "internal\\test1";
        private string _test = "internal\\test2";

        // Issue data
        private string _title;
        private string _description;

        // Task data
        private string _action = "";
        private string _priority = "(2) Normal";
        private string _assign = "";
        private string _resolution;
        private string _feedback;

        // Task IDs
        private Guid _taskId = Guid.Empty;
        private Guid _workTaskId = Guid.Empty;

        private void onWorkflowActivated1_Invoked(object sender, ExternalDataEventArgs e)
        {
            // Get the details from the Issue item that we’ll need later
            _title = workflowProperties.Item.Title;
            _description = workflowProperties.Item["Description"].ToString();

            // Set the Date Created
            SPListItem item = workflowProperties.Item;
            item["_DCDateCreated"] = DateTime.UtcNow;
            item.Update();

            // Get the association data
            if (workflowProperties.AssociationData != null)
            {
                XElement data = XElement.Parse(workflowProperties.AssociationData);

                foreach (XElement x in data.Element("AdminUsers").Elements())
                {
                    _admin = x.Value;
                    break;  // just get the first one
                }
                foreach (XElement x in data.Element("TestUsers").Elements())
                {
                    _test = x.Value;
                    break;  // just get the first one
                }
            }
        }

        /*----------------------------------------------------------*/
        /* Create task event handlers                               */
        /*----------------------------------------------------------*/
        // New
        private void createNewTask_MethodInvoking(object sender, EventArgs e)
        {
            CreateTaskWithContentType task = sender as CreateTaskWithContentType;
            task.TaskId = Guid.NewGuid();

            SPWorkflowTaskProperties wtp = new SPWorkflowTaskProperties();
            wtp.PercentComplete = (float)0.0;
            wtp.AssignedTo = _admin;
            wtp.TaskType = 0;
            wtp.DueDate = DateTime.UtcNow.AddDays(1);
            wtp.Title = "New: " + _title;
            wtp.Description = _description;

            task.TaskProperties = wtp;
        }

        // Assigned
        private void createAssignedTask_MethodInvoking(object sender, EventArgs e)
        {
            CreateTaskWithContentType task = sender as CreateTaskWithContentType;
            task.TaskId = Guid.NewGuid();
            _workTaskId = task.TaskId;

            SPWorkflowTaskProperties wtp = new SPWorkflowTaskProperties();
            wtp.PercentComplete = (float)0.0;
            wtp.AssignedTo = _assign;
            wtp.TaskType = 1;
            wtp.DueDate = DateTime.UtcNow.AddDays(1);
            wtp.Title = "Issue: " + _title;
            wtp.Description = _description;

            task.TaskProperties = wtp;

            // Update the item to show the assignee
            SPUser u = workflowProperties.Web.SiteUsers[_assign];
            SPListItem item = workflowProperties.Item;
            item["AssignedTo"] = u;
            item.Update();
        }

        // Resolved
        private void createResolvedTask_MethodInvoking(object sender, EventArgs e)
        {
            CreateTaskWithContentType task = sender as CreateTaskWithContentType;
            task.TaskId = Guid.NewGuid();

            SPWorkflowTaskProperties wtp = new SPWorkflowTaskProperties();
            wtp.PercentComplete = (float)0.0;
            wtp.AssignedTo = _test;
            wtp.TaskType = 2;
            wtp.DueDate = DateTime.UtcNow.AddDays(1);
            wtp.Title = "Resolved: " + _title;
            wtp.Description = _description;

            task.TaskProperties = wtp;
        }

        // Waiting - Working as Designed
        private void createWADTask_MethodInvoking(object sender, EventArgs e)
        {
            CreateTaskWithContentType task = sender as CreateTaskWithContentType;
            task.TaskId = Guid.NewGuid();

            SPWorkflowTaskProperties wtp = new SPWorkflowTaskProperties();
            wtp.PercentComplete = (float)0.0;
            wtp.AssignedTo = _admin;
            wtp.TaskType = 3;
            wtp.DueDate = DateTime.UtcNow.AddDays(1);
            wtp.Title = "Working as Designed: " + _title;
            wtp.Description = _resolution;

            task.TaskProperties = wtp;

            // Update the items's Resolution Type
            SPListItem item = workflowProperties.Item;
            item["Resolution Type"] = "Working as Designed";
            item.Update();
        }

        // Waiting - Enhancement
        private void createEnhancementTask_MethodInvoking(object sender, EventArgs e)
        {
            CreateTaskWithContentType task = sender as CreateTaskWithContentType;
            task.TaskId = Guid.NewGuid();

            SPWorkflowTaskProperties wtp = new SPWorkflowTaskProperties();
            wtp.PercentComplete = (float)0.0;
            wtp.AssignedTo = _admin;
            wtp.TaskType = 4;
            wtp.DueDate = DateTime.UtcNow.AddDays(1);
            wtp.Title = "Enhancement: " + _title;
            wtp.Description = _resolution;

            task.TaskProperties = wtp;

            // Update the items's Resolution Type
            SPListItem item = workflowProperties.Item;
            item["Resolution Type"] = "Enhancement";
            item.Update();
        }

        // Waiting - More Info
        private void createInfoTask_MethodInvoking(object sender, EventArgs e)
        {
            CreateTaskWithContentType task = sender as CreateTaskWithContentType;
            task.TaskId = Guid.NewGuid();

            SPWorkflowTaskProperties wtp = new SPWorkflowTaskProperties();
            wtp.PercentComplete = (float)0.0;
            wtp.AssignedTo = _admin;
            wtp.TaskType = 5;
            wtp.DueDate = DateTime.UtcNow.AddDays(1);
            wtp.Title = "More info needed: " + _title;
            wtp.Description = _description;

            task.TaskProperties = wtp;

            // Update the items's Resolution Type
            SPListItem item = workflowProperties.Item;
            item["Resolution Type"] = "Closed";
            item.Update();
        }

        /*----------------------------------------------------------*/
        /* OnTaskChanged event handlers                             */
        /*----------------------------------------------------------*/
        // New
        private void onNewChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            CreateTaskWithContentType task = sender as CreateTaskWithContentType;
            SPTaskServiceEventArgs args = (SPTaskServiceEventArgs)e;

            _taskId = args.taskId;

            SPWorkflowTaskProperties after = args.afterProperties;
            if (after != null)
            {
                _action = after.ExtendedProperties[
                    workflowProperties.TaskList.Fields
                    .GetField("Issue New Action")
                    .Id].ToString();

                _priority = after.ExtendedProperties[
                    workflowProperties.TaskList.Fields
                    .GetField("Issue Priority")
                    .Id].ToString();

                _assign = after.ExtendedProperties[
                    workflowProperties.TaskList.Fields
                    .GetField("Issue Assigned To")
                    .Id].ToString();

                // Store the item's priority
                if (_priority.Length > 0)
                {
                    SPListItem item = workflowProperties.Item;

                    if (_priority.Length > 0)
                        item["Priority"] = _priority;

                    item.Update();
                }
            }
        }

        // Assigned
        private void onAssignedChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            CreateTaskWithContentType task = sender as CreateTaskWithContentType;
            SPTaskServiceEventArgs args = (SPTaskServiceEventArgs)e;

            _taskId = args.taskId;

            SPWorkflowTaskProperties after = args.afterProperties;
            if (after != null)
            {
                _action = after.ExtendedProperties[
                    workflowProperties.TaskList.Fields
                    .GetField("Issue Assigned Action")
                    .Id].ToString();

                bool started = bool.Parse(after.ExtendedProperties[
                    workflowProperties.TaskList.Fields
                    .GetField("Issue Started")
                    .Id].ToString());

                if (started)
                    _action = "Start";

                _resolution = after.ExtendedProperties[
                    workflowProperties.TaskList.Fields
                    .GetField("Resolution")
                    .Id].ToString();

                if (_resolution.Length > 0)
                {
                    SPListItem item = workflowProperties.Item;
                    item["Resolution"] = _resolution;
                    item.Update();
                }
            }
        }

        // Active
        private void onActiveChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            CreateTaskWithContentType task = sender as CreateTaskWithContentType;
            SPTaskServiceEventArgs args = (SPTaskServiceEventArgs)e;

            _taskId = args.taskId;

            SPWorkflowTaskProperties after = args.afterProperties;
            if (after != null)
            {
                _action = after.ExtendedProperties[
                    workflowProperties.TaskList.Fields
                    .GetField("Issue Assigned Action")
                    .Id].ToString();

                bool started = bool.Parse(after.ExtendedProperties[
                    workflowProperties.TaskList.Fields
                    .GetField("Issue Started")
                    .Id].ToString());

                if (!started)
                    _action = "Pause";

                _resolution = after.ExtendedProperties[
                    workflowProperties.TaskList.Fields
                    .GetField("Resolution")
                    .Id].ToString();

                if (_resolution.Length > 0)
                {
                    SPListItem item = workflowProperties.Item;
                    item["Resolution"] = _resolution;
                    item.Update();
                }
            }
        }

        // Resolved
        private void onResolvedChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            CreateTaskWithContentType task = sender as CreateTaskWithContentType;
            SPTaskServiceEventArgs args = (SPTaskServiceEventArgs)e;

            _taskId = args.taskId;

            SPWorkflowTaskProperties after = args.afterProperties;
            if (after != null)
            {
                _action = after.ExtendedProperties[
                    workflowProperties.TaskList.Fields
                    .GetField("Issue Resolved Action")
                    .Id].ToString();

                _feedback = after.ExtendedProperties[
                    workflowProperties.TaskList.Fields
                    .GetField("Issue Feedback")
                    .Id].ToString();

                if (_feedback.Length > 0 && _feedback != "<DIV></DIV>")
                {
                    SPListItem item = workflowProperties.Item;
                    if (item["Issue Feedback"] != null)
                        item["Issue Feedback"] += "\r\n";
                    item["Issue Feedback"] += _feedback;
                    item.Update();
                }
            }
        }

        // Waiting
        private void onWaitingChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            CreateTaskWithContentType task = sender as CreateTaskWithContentType;
            SPTaskServiceEventArgs args = (SPTaskServiceEventArgs)e;

            _taskId = args.taskId;

            SPWorkflowTaskProperties after = args.afterProperties;
            if (after != null)
            {
                _action = after.ExtendedProperties[
                    workflowProperties.TaskList.Fields
                    .GetField("Issue Waiting Action")
                    .Id].ToString();

                _feedback = after.ExtendedProperties[
                    workflowProperties.TaskList.Fields
                    .GetField("Issue Feedback")
                    .Id].ToString();

                if (_feedback.Length > 0 && _feedback != "<DIV></DIV>")
                {
                    SPListItem item = workflowProperties.Item;
                    if (item["Issue Feedback"] != null)
                        item["Issue Feedback"] += "\r\n";
                    item["Issue Feedback"] += _feedback;
                    item.Update();
                }
            }
        }

        /*----------------------------------------------------------*/
        /* State initializers                                       */
        /*----------------------------------------------------------*/
        private void codeInitNew_ExecuteCode(object sender, EventArgs e)
        {
            SPListItem item = workflowProperties.Item;
            item["PM Issue Status"] = "New";
            item.Update();
        }

        private void codeInitAssigned_ExecuteCode(object sender, EventArgs e)
        {
            SPListItem item = workflowProperties.Item;
            item["PM Issue Status"] = "Assigned";
            item.Update();
        }

        private void codeInitActive_ExecuteCode(object sender, EventArgs e)
        {
            SPListItem item = workflowProperties.Item;
            item["PM Issue Status"] = "Active";
            item.Update();
        }

        private void codeInitResolved_ExecuteCode(object sender, EventArgs e)
        {
            SPListItem item = workflowProperties.Item;
            item["PM Issue Status"] = "Resolved";
            item.Update();
        }

        private void codeInitWaiting_ExecuteCode(object sender, EventArgs e)
        {
            SPListItem item = workflowProperties.Item;
            item["PM Issue Status"] = "Pending";
            item.Update();
        }

        /*----------------------------------------------------------*/
        /* Complete task event handlers                             */
        /*----------------------------------------------------------*/
        private void completeTask_MethodInvoking(object sender, EventArgs e)
        {
            CompleteTask ct = (CompleteTask)sender;
            ct.TaskId = _taskId;
        }

        private void completeWorkTask_MethodInvoking(object sender, EventArgs e)
        {
            CompleteTask ct = (CompleteTask)sender;
            ct.TaskId = _workTaskId;
        }


        /*----------------------------------------------------------*/
        /* Misc code activity handlers                              */
        /*----------------------------------------------------------*/
        private void codeSetClosed_ExecuteCode(object sender, EventArgs e)
        {
            // Now set the BugStatus and the completed date
            SPListItem item = workflowProperties.Item;
            item["DateCompleted"] = DateTime.UtcNow;
            item["PM Issue Status"] = "Closed";
            item.Update();
        }

        private void codeSetResolved_ExecuteCode(object sender, EventArgs e)
        {
            // Now set the BugStatus and the completed date
            SPListItem item = workflowProperties.Item;
            item["DateCompleted"] = DateTime.UtcNow;
            item["PM Issue Status"] = "Closed";
            item["Resolution Type"] = "Resolved";
            item.Update();
        }

        public static DependencyProperty updateWorkTask_TaskIdProperty = DependencyProperty.Register("updateWorkTask_TaskId", typeof(System.Guid), typeof(Chapter15.Workflow1.Workflow1));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Misc")]
        public Guid updateWorkTask_TaskId
        {
            get
            {
                return ((System.Guid)(base.GetValue(Chapter15.Workflow1.Workflow1.updateWorkTask_TaskIdProperty)));
            }
            set
            {
                base.SetValue(Chapter15.Workflow1.Workflow1.updateWorkTask_TaskIdProperty, value);
            }
        }

        public static DependencyProperty updateWorkTask_TaskPropertiesProperty = DependencyProperty.Register("updateWorkTask_TaskProperties", typeof(Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties), typeof(Chapter15.Workflow1.Workflow1));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Misc")]
        public SPWorkflowTaskProperties updateWorkTask_TaskProperties
        {
            get
            {
                return ((Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties)(base.GetValue(Chapter15.Workflow1.Workflow1.updateWorkTask_TaskPropertiesProperty)));
            }
            set
            {
                base.SetValue(Chapter15.Workflow1.Workflow1.updateWorkTask_TaskPropertiesProperty, value);
            }
        }

        /*----------------------------------------------------------*/
        /* Set the UpdateTask properties                            */
        /*----------------------------------------------------------*/
        private void updateWorkWaiting_MethodInvoking(object sender, EventArgs e)
        {
            updateWorkTask_TaskId = _workTaskId;
            updateWorkTask_TaskProperties = new SPWorkflowTaskProperties();
            updateWorkTask_TaskProperties.ExtendedProperties[
                workflowProperties.TaskList.Fields.GetField("Status")
                    .Id] = "Waiting on someone else";
            updateWorkTask_TaskProperties.ExtendedProperties[
                workflowProperties.TaskList.Fields.GetField("Issue Assigned Action")
                    .Id] = "None";
        }

        private void updateWorkAvailable_MethodInvoking(object sender, EventArgs e)
        {
            updateWorkTask_TaskId = _workTaskId;
            updateWorkTask_TaskProperties = new SPWorkflowTaskProperties();
            updateWorkTask_TaskProperties.ExtendedProperties[
                workflowProperties.TaskList.Fields.GetField("Status")
                    .Id] = "In Progress";
            updateWorkTask_TaskProperties.ExtendedProperties[
                workflowProperties.TaskList.Fields.GetField("Issue Assigned Action")
                    .Id] = "None";
            updateWorkTask_TaskProperties.ExtendedProperties[
                workflowProperties.TaskList.Fields.GetField("Issue Started")
                    .Id] = "False";
        }

    }
}
