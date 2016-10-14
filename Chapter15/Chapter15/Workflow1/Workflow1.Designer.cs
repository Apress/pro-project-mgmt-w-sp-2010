using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace Chapter15.Workflow1
{
    public sealed partial class Workflow1
    {
        #region Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        private void InitializeComponent()
        {
            this.CanModifyActivities = true;
            System.Workflow.Runtime.CorrelationToken correlationtoken1 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference1 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference2 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken2 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken3 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken4 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken5 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind3 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind4 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken6 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken7 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken8 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind5 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind6 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken9 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind7 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind8 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken10 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind9 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind10 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken11 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind11 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind12 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken12 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind13 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind14 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken13 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind15 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind16 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken14 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind17 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind18 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind19 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind20 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken15 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken16 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken17 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken18 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference3 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference4 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference5 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference6 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference7 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference8 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference9 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference10 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference11 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference12 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference13 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference14 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference15 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference16 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference17 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference18 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference19 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference20 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference21 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference22 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference23 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Runtime.CorrelationToken correlationtoken19 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken20 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind21 = new System.Workflow.ComponentModel.ActivityBind();
            this.setWaitingNew = new System.Workflow.Activities.SetStateActivity();
            this.setWaitingAssigned = new System.Workflow.Activities.SetStateActivity();
            this.updateWaiting = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.completeWaitingWork = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.ifElseBranchActivity5 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifWorkTaskResubmit = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity3 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifWorkTask = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseActivity9 = new System.Workflow.Activities.IfElseActivity();
            this.completeResubmit = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.setWaitingFinal = new System.Workflow.Activities.SetStateActivity();
            this.codeWaitingClosed = new System.Workflow.Activities.CodeActivity();
            this.ifElseActivity8 = new System.Workflow.Activities.IfElseActivity();
            this.completeWaiting = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.createWaitingMoreInfoTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.createWaitingEnhancementTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.createWaitingWadTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.setResolvedAssigned = new System.Workflow.Activities.SetStateActivity();
            this.updateNoResolved = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.completeNotResolved = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.setResolvedFinal = new System.Workflow.Activities.SetStateActivity();
            this.codeResolvedSetClosed = new System.Workflow.Activities.CodeActivity();
            this.completeResolvedWork = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.completeResolved = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.setActiveEnhancement = new System.Workflow.Activities.SetStateActivity();
            this.updateActiveEnhancement = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.setActiveWad = new System.Workflow.Activities.SetStateActivity();
            this.updateActiveWad = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.setActiveMoreInfo = new System.Workflow.Activities.SetStateActivity();
            this.updateActiveMoreInfo = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.setActiveResolved = new System.Workflow.Activities.SetStateActivity();
            this.updateActiveCompleted = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.setActiveAssigned = new System.Workflow.Activities.SetStateActivity();
            this.setAssignedEnhancement = new System.Workflow.Activities.SetStateActivity();
            this.updateAssignedEnhancement = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.setAssignedWad = new System.Workflow.Activities.SetStateActivity();
            this.updateAssignedWad = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.setAssignedMoreInfo = new System.Workflow.Activities.SetStateActivity();
            this.updateAssignedMoreInfo = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.setAssignedResolved = new System.Workflow.Activities.SetStateActivity();
            this.updateAssignedResolved = new Microsoft.SharePoint.WorkflowActions.UpdateTask();
            this.setAssignedActive = new System.Workflow.Activities.SetStateActivity();
            this.createAssignedTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.setNewEnhancement = new System.Workflow.Activities.SetStateActivity();
            this.completeNewEnhancement = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.setNewWad = new System.Workflow.Activities.SetStateActivity();
            this.completeNewWad = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.setNewMoreInfo = new System.Workflow.Activities.SetStateActivity();
            this.completeNewMoreInfo = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.setNewAssign = new System.Workflow.Activities.SetStateActivity();
            this.completeNewAssign = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.ifWaitingResubmit = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifWaitingClose = new System.Workflow.Activities.IfElseBranchActivity();
            this.elseMoreInfo = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifWaitingEnhancement = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifWaitingWad = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifNotResolved = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifResolved = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifActiveEnhancement = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifActiveWad = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifActiveMoreInfo = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifActiveCompleted = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifActivePause = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifAssignedEnhancement = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifAssignedWad = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifAssignedMoreInfo = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifAssignedCompleted = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifAssignedStart = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity2 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifNotCreated = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifNewEnhancement = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifNewWad = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifNewMoreInfo = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifNewAssign = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseActivity7 = new System.Workflow.Activities.IfElseActivity();
            this.onWaitingChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.codeInitWaiting = new System.Workflow.Activities.CodeActivity();
            this.ifElseActivity2 = new System.Workflow.Activities.IfElseActivity();
            this.ifElseActivity6 = new System.Workflow.Activities.IfElseActivity();
            this.onResolvedChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.codeInitResolved = new System.Workflow.Activities.CodeActivity();
            this.createResolvedTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.ifElseActivity5 = new System.Workflow.Activities.IfElseActivity();
            this.onActiveChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.codeInitActive = new System.Workflow.Activities.CodeActivity();
            this.ifElseActivity4 = new System.Workflow.Activities.IfElseActivity();
            this.onAssignedChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.codeInitAssigned = new System.Workflow.Activities.CodeActivity();
            this.ifElseActivity1 = new System.Workflow.Activities.IfElseActivity();
            this.ifElseActivity3 = new System.Workflow.Activities.IfElseActivity();
            this.onNewChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.codeInitNew = new System.Workflow.Activities.CodeActivity();
            this.createNewTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.setInitialNew = new System.Workflow.Activities.SetStateActivity();
            this.onWorkflowActivated1 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated();
            this.eventWaiting = new System.Workflow.Activities.EventDrivenActivity();
            this.initWaiting = new System.Workflow.Activities.StateInitializationActivity();
            this.eventResolved = new System.Workflow.Activities.EventDrivenActivity();
            this.initResolved = new System.Workflow.Activities.StateInitializationActivity();
            this.eventActive = new System.Workflow.Activities.EventDrivenActivity();
            this.initActive = new System.Workflow.Activities.StateInitializationActivity();
            this.eventAssigned = new System.Workflow.Activities.EventDrivenActivity();
            this.initAssigned = new System.Workflow.Activities.StateInitializationActivity();
            this.eventNew = new System.Workflow.Activities.EventDrivenActivity();
            this.initNew = new System.Workflow.Activities.StateInitializationActivity();
            this.eventInitial = new System.Workflow.Activities.EventDrivenActivity();
            this.stateWaiting = new System.Workflow.Activities.StateActivity();
            this.stateResolved = new System.Workflow.Activities.StateActivity();
            this.stateActive = new System.Workflow.Activities.StateActivity();
            this.stateAssigned = new System.Workflow.Activities.StateActivity();
            this.stateNew = new System.Workflow.Activities.StateActivity();
            this.stateFinal = new System.Workflow.Activities.StateActivity();
            this.stateInitial = new System.Workflow.Activities.StateActivity();
            // 
            // setWaitingNew
            // 
            this.setWaitingNew.Name = "setWaitingNew";
            this.setWaitingNew.TargetStateName = "stateNew";
            // 
            // setWaitingAssigned
            // 
            this.setWaitingAssigned.Name = "setWaitingAssigned";
            this.setWaitingAssigned.TargetStateName = "stateAssigned";
            // 
            // updateWaiting
            // 
            correlationtoken1.Name = "taskToken";
            correlationtoken1.OwnerActivityName = "Workflow1";
            this.updateWaiting.CorrelationToken = correlationtoken1;
            this.updateWaiting.Name = "updateWaiting";
            activitybind1.Name = "Workflow1";
            activitybind1.Path = "updateWorkTask_TaskId";
            activitybind2.Name = "Workflow1";
            activitybind2.Path = "updateWorkTask_TaskProperties";
            this.updateWaiting.MethodInvoking += new System.EventHandler(this.updateWorkAvailable_MethodInvoking);
            this.updateWaiting.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            this.updateWaiting.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            // 
            // completeWaitingWork
            // 
            this.completeWaitingWork.CorrelationToken = correlationtoken1;
            this.completeWaitingWork.Name = "completeWaitingWork";
            this.completeWaitingWork.TaskId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.completeWaitingWork.TaskOutcome = null;
            this.completeWaitingWork.MethodInvoking += new System.EventHandler(this.completeWorkTask_MethodInvoking);
            // 
            // ifElseBranchActivity5
            // 
            this.ifElseBranchActivity5.Activities.Add(this.setWaitingNew);
            this.ifElseBranchActivity5.Name = "ifElseBranchActivity5";
            // 
            // ifWorkTaskResubmit
            // 
            this.ifWorkTaskResubmit.Activities.Add(this.updateWaiting);
            this.ifWorkTaskResubmit.Activities.Add(this.setWaitingAssigned);
            ruleconditionreference1.ConditionName = "WorkTask";
            this.ifWorkTaskResubmit.Condition = ruleconditionreference1;
            this.ifWorkTaskResubmit.Name = "ifWorkTaskResubmit";
            // 
            // ifElseBranchActivity3
            // 
            this.ifElseBranchActivity3.Name = "ifElseBranchActivity3";
            // 
            // ifWorkTask
            // 
            this.ifWorkTask.Activities.Add(this.completeWaitingWork);
            ruleconditionreference2.ConditionName = "WorkTask";
            this.ifWorkTask.Condition = ruleconditionreference2;
            this.ifWorkTask.Name = "ifWorkTask";
            // 
            // ifElseActivity9
            // 
            this.ifElseActivity9.Activities.Add(this.ifWorkTaskResubmit);
            this.ifElseActivity9.Activities.Add(this.ifElseBranchActivity5);
            this.ifElseActivity9.Name = "ifElseActivity9";
            // 
            // completeResubmit
            // 
            correlationtoken2.Name = "waitingToken";
            correlationtoken2.OwnerActivityName = "stateWaiting";
            this.completeResubmit.CorrelationToken = correlationtoken2;
            this.completeResubmit.Name = "completeResubmit";
            this.completeResubmit.TaskId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.completeResubmit.TaskOutcome = null;
            this.completeResubmit.MethodInvoking += new System.EventHandler(this.completeTask_MethodInvoking);
            // 
            // setWaitingFinal
            // 
            this.setWaitingFinal.Name = "setWaitingFinal";
            this.setWaitingFinal.TargetStateName = "stateFinal";
            // 
            // codeWaitingClosed
            // 
            this.codeWaitingClosed.Name = "codeWaitingClosed";
            this.codeWaitingClosed.ExecuteCode += new System.EventHandler(this.codeSetClosed_ExecuteCode);
            // 
            // ifElseActivity8
            // 
            this.ifElseActivity8.Activities.Add(this.ifWorkTask);
            this.ifElseActivity8.Activities.Add(this.ifElseBranchActivity3);
            this.ifElseActivity8.Name = "ifElseActivity8";
            // 
            // completeWaiting
            // 
            correlationtoken3.Name = "waitingToken";
            correlationtoken3.OwnerActivityName = "stateWaiting";
            this.completeWaiting.CorrelationToken = correlationtoken3;
            this.completeWaiting.Name = "completeWaiting";
            this.completeWaiting.TaskId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.completeWaiting.TaskOutcome = null;
            this.completeWaiting.MethodInvoking += new System.EventHandler(this.completeTask_MethodInvoking);
            // 
            // createWaitingMoreInfoTask
            // 
            this.createWaitingMoreInfoTask.ContentTypeId = "0x01080100F6B61D3B68849C498E99E75200AFB025";
            correlationtoken4.Name = "waitingToken";
            correlationtoken4.OwnerActivityName = "stateWaiting";
            this.createWaitingMoreInfoTask.CorrelationToken = correlationtoken4;
            this.createWaitingMoreInfoTask.ListItemId = -1;
            this.createWaitingMoreInfoTask.Name = "createWaitingMoreInfoTask";
            this.createWaitingMoreInfoTask.SpecialPermissions = null;
            this.createWaitingMoreInfoTask.TaskId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.createWaitingMoreInfoTask.TaskProperties = null;
            this.createWaitingMoreInfoTask.MethodInvoking += new System.EventHandler(this.createInfoTask_MethodInvoking);
            // 
            // createWaitingEnhancementTask
            // 
            this.createWaitingEnhancementTask.ContentTypeId = "0x010801009BDB3742BBE3FC4FA0D143D59D754FC5";
            correlationtoken5.Name = "waitingToken";
            correlationtoken5.OwnerActivityName = "stateWaiting";
            this.createWaitingEnhancementTask.CorrelationToken = correlationtoken5;
            this.createWaitingEnhancementTask.ListItemId = -1;
            this.createWaitingEnhancementTask.Name = "createWaitingEnhancementTask";
            this.createWaitingEnhancementTask.SpecialPermissions = null;
            this.createWaitingEnhancementTask.TaskId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.createWaitingEnhancementTask.TaskProperties = null;
            this.createWaitingEnhancementTask.MethodInvoking += new System.EventHandler(this.createEnhancementTask_MethodInvoking);
            // 
            // createWaitingWadTask
            // 
            this.createWaitingWadTask.ContentTypeId = "0x010801004BD8BD6E49698C49B1A4A5385093625B";
            this.createWaitingWadTask.CorrelationToken = correlationtoken3;
            this.createWaitingWadTask.ListItemId = -1;
            this.createWaitingWadTask.Name = "createWaitingWadTask";
            this.createWaitingWadTask.SpecialPermissions = null;
            this.createWaitingWadTask.TaskId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.createWaitingWadTask.TaskProperties = null;
            this.createWaitingWadTask.MethodInvoking += new System.EventHandler(this.createWADTask_MethodInvoking);
            // 
            // setResolvedAssigned
            // 
            this.setResolvedAssigned.Name = "setResolvedAssigned";
            this.setResolvedAssigned.TargetStateName = "stateAssigned";
            // 
            // updateNoResolved
            // 
            this.updateNoResolved.CorrelationToken = correlationtoken1;
            this.updateNoResolved.Name = "updateNoResolved";
            activitybind3.Name = "Workflow1";
            activitybind3.Path = "updateWorkTask_TaskId";
            activitybind4.Name = "Workflow1";
            activitybind4.Path = "updateWorkTask_TaskProperties";
            this.updateNoResolved.MethodInvoking += new System.EventHandler(this.updateWorkAvailable_MethodInvoking);
            this.updateNoResolved.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            this.updateNoResolved.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
            // 
            // completeNotResolved
            // 
            correlationtoken6.Name = "resolvedToken";
            correlationtoken6.OwnerActivityName = "stateResolved";
            this.completeNotResolved.CorrelationToken = correlationtoken6;
            this.completeNotResolved.Name = "completeNotResolved";
            this.completeNotResolved.TaskId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.completeNotResolved.TaskOutcome = null;
            this.completeNotResolved.MethodInvoking += new System.EventHandler(this.completeTask_MethodInvoking);
            // 
            // setResolvedFinal
            // 
            this.setResolvedFinal.Name = "setResolvedFinal";
            this.setResolvedFinal.TargetStateName = "stateFinal";
            // 
            // codeResolvedSetClosed
            // 
            this.codeResolvedSetClosed.Name = "codeResolvedSetClosed";
            this.codeResolvedSetClosed.ExecuteCode += new System.EventHandler(this.codeSetResolved_ExecuteCode);
            // 
            // completeResolvedWork
            // 
            this.completeResolvedWork.CorrelationToken = correlationtoken1;
            this.completeResolvedWork.Name = "completeResolvedWork";
            this.completeResolvedWork.TaskId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.completeResolvedWork.TaskOutcome = null;
            this.completeResolvedWork.MethodInvoking += new System.EventHandler(this.completeWorkTask_MethodInvoking);
            // 
            // completeResolved
            // 
            correlationtoken7.Name = "resolvedToken";
            correlationtoken7.OwnerActivityName = "stateResolved";
            this.completeResolved.CorrelationToken = correlationtoken7;
            this.completeResolved.Name = "completeResolved";
            this.completeResolved.TaskId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.completeResolved.TaskOutcome = null;
            this.completeResolved.MethodInvoking += new System.EventHandler(this.completeTask_MethodInvoking);
            // 
            // setActiveEnhancement
            // 
            this.setActiveEnhancement.Name = "setActiveEnhancement";
            this.setActiveEnhancement.TargetStateName = "stateWaiting";
            // 
            // updateActiveEnhancement
            // 
            correlationtoken8.Name = "taskToken";
            correlationtoken8.OwnerActivityName = "Workflow1";
            this.updateActiveEnhancement.CorrelationToken = correlationtoken8;
            this.updateActiveEnhancement.Name = "updateActiveEnhancement";
            activitybind5.Name = "Workflow1";
            activitybind5.Path = "updateWorkTask_TaskId";
            activitybind6.Name = "Workflow1";
            activitybind6.Path = "updateWorkTask_TaskProperties";
            this.updateActiveEnhancement.MethodInvoking += new System.EventHandler(this.updateWorkWaiting_MethodInvoking);
            this.updateActiveEnhancement.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind6)));
            this.updateActiveEnhancement.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind5)));
            // 
            // setActiveWad
            // 
            this.setActiveWad.Name = "setActiveWad";
            this.setActiveWad.TargetStateName = "stateWaiting";
            // 
            // updateActiveWad
            // 
            correlationtoken9.Name = "taskToken";
            correlationtoken9.OwnerActivityName = "Workflow1";
            this.updateActiveWad.CorrelationToken = correlationtoken9;
            this.updateActiveWad.Name = "updateActiveWad";
            activitybind7.Name = "Workflow1";
            activitybind7.Path = "updateWorkTask_TaskId";
            activitybind8.Name = "Workflow1";
            activitybind8.Path = "updateWorkTask_TaskProperties";
            this.updateActiveWad.MethodInvoking += new System.EventHandler(this.updateWorkWaiting_MethodInvoking);
            this.updateActiveWad.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind8)));
            this.updateActiveWad.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind7)));
            // 
            // setActiveMoreInfo
            // 
            this.setActiveMoreInfo.Name = "setActiveMoreInfo";
            this.setActiveMoreInfo.TargetStateName = "stateWaiting";
            // 
            // updateActiveMoreInfo
            // 
            correlationtoken10.Name = "taskToken";
            correlationtoken10.OwnerActivityName = "Workflow1";
            this.updateActiveMoreInfo.CorrelationToken = correlationtoken10;
            this.updateActiveMoreInfo.Name = "updateActiveMoreInfo";
            activitybind9.Name = "Workflow1";
            activitybind9.Path = "updateWorkTask_TaskId";
            activitybind10.Name = "Workflow1";
            activitybind10.Path = "updateWorkTask_TaskProperties";
            this.updateActiveMoreInfo.MethodInvoking += new System.EventHandler(this.updateWorkWaiting_MethodInvoking);
            this.updateActiveMoreInfo.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind10)));
            this.updateActiveMoreInfo.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind9)));
            // 
            // setActiveResolved
            // 
            this.setActiveResolved.Name = "setActiveResolved";
            this.setActiveResolved.TargetStateName = "stateResolved";
            // 
            // updateActiveCompleted
            // 
            correlationtoken11.Name = "taskToken";
            correlationtoken11.OwnerActivityName = "Workflow1";
            this.updateActiveCompleted.CorrelationToken = correlationtoken11;
            this.updateActiveCompleted.Name = "updateActiveCompleted";
            activitybind11.Name = "Workflow1";
            activitybind11.Path = "updateWorkTask_TaskId";
            activitybind12.Name = "Workflow1";
            activitybind12.Path = "updateWorkTask_TaskProperties";
            this.updateActiveCompleted.MethodInvoking += new System.EventHandler(this.updateWorkWaiting_MethodInvoking);
            this.updateActiveCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind12)));
            this.updateActiveCompleted.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind11)));
            // 
            // setActiveAssigned
            // 
            this.setActiveAssigned.Name = "setActiveAssigned";
            this.setActiveAssigned.TargetStateName = "stateAssigned";
            // 
            // setAssignedEnhancement
            // 
            this.setAssignedEnhancement.Name = "setAssignedEnhancement";
            this.setAssignedEnhancement.TargetStateName = "stateWaiting";
            // 
            // updateAssignedEnhancement
            // 
            correlationtoken12.Name = "taskToken";
            correlationtoken12.OwnerActivityName = "Workflow1";
            this.updateAssignedEnhancement.CorrelationToken = correlationtoken12;
            this.updateAssignedEnhancement.Name = "updateAssignedEnhancement";
            activitybind13.Name = "Workflow1";
            activitybind13.Path = "updateWorkTask_TaskId";
            activitybind14.Name = "Workflow1";
            activitybind14.Path = "updateWorkTask_TaskProperties";
            this.updateAssignedEnhancement.MethodInvoking += new System.EventHandler(this.updateWorkWaiting_MethodInvoking);
            this.updateAssignedEnhancement.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind14)));
            this.updateAssignedEnhancement.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind13)));
            // 
            // setAssignedWad
            // 
            this.setAssignedWad.Name = "setAssignedWad";
            this.setAssignedWad.TargetStateName = "stateWaiting";
            // 
            // updateAssignedWad
            // 
            correlationtoken13.Name = "taskToken";
            correlationtoken13.OwnerActivityName = "Workflow1";
            this.updateAssignedWad.CorrelationToken = correlationtoken13;
            this.updateAssignedWad.Name = "updateAssignedWad";
            activitybind15.Name = "Workflow1";
            activitybind15.Path = "updateWorkTask_TaskId";
            activitybind16.Name = "Workflow1";
            activitybind16.Path = "updateWorkTask_TaskProperties";
            this.updateAssignedWad.MethodInvoking += new System.EventHandler(this.updateWorkWaiting_MethodInvoking);
            this.updateAssignedWad.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind16)));
            this.updateAssignedWad.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind15)));
            // 
            // setAssignedMoreInfo
            // 
            this.setAssignedMoreInfo.Name = "setAssignedMoreInfo";
            this.setAssignedMoreInfo.TargetStateName = "stateWaiting";
            // 
            // updateAssignedMoreInfo
            // 
            correlationtoken14.Name = "taskToken";
            correlationtoken14.OwnerActivityName = "Workflow1";
            this.updateAssignedMoreInfo.CorrelationToken = correlationtoken14;
            this.updateAssignedMoreInfo.Name = "updateAssignedMoreInfo";
            activitybind17.Name = "Workflow1";
            activitybind17.Path = "updateWorkTask_TaskId";
            activitybind18.Name = "Workflow1";
            activitybind18.Path = "updateWorkTask_TaskProperties";
            this.updateAssignedMoreInfo.MethodInvoking += new System.EventHandler(this.updateWorkWaiting_MethodInvoking);
            this.updateAssignedMoreInfo.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind18)));
            this.updateAssignedMoreInfo.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind17)));
            // 
            // setAssignedResolved
            // 
            this.setAssignedResolved.Name = "setAssignedResolved";
            this.setAssignedResolved.TargetStateName = "stateResolved";
            // 
            // updateAssignedResolved
            // 
            this.updateAssignedResolved.CorrelationToken = correlationtoken1;
            this.updateAssignedResolved.Name = "updateAssignedResolved";
            activitybind19.Name = "Workflow1";
            activitybind19.Path = "updateWorkTask_TaskId";
            activitybind20.Name = "Workflow1";
            activitybind20.Path = "updateWorkTask_TaskProperties";
            this.updateAssignedResolved.MethodInvoking += new System.EventHandler(this.updateWorkWaiting_MethodInvoking);
            this.updateAssignedResolved.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind19)));
            this.updateAssignedResolved.SetBinding(Microsoft.SharePoint.WorkflowActions.UpdateTask.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind20)));
            // 
            // setAssignedActive
            // 
            this.setAssignedActive.Name = "setAssignedActive";
            this.setAssignedActive.TargetStateName = "stateActive";
            // 
            // createAssignedTask
            // 
            this.createAssignedTask.ContentTypeId = "0x010801006223D085ECAA0A458ECE1293C12DE418";
            this.createAssignedTask.CorrelationToken = correlationtoken1;
            this.createAssignedTask.ListItemId = -1;
            this.createAssignedTask.Name = "createAssignedTask";
            this.createAssignedTask.SpecialPermissions = null;
            this.createAssignedTask.TaskId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.createAssignedTask.TaskProperties = null;
            this.createAssignedTask.MethodInvoking += new System.EventHandler(this.createAssignedTask_MethodInvoking);
            // 
            // setNewEnhancement
            // 
            this.setNewEnhancement.Name = "setNewEnhancement";
            this.setNewEnhancement.TargetStateName = "stateWaiting";
            // 
            // completeNewEnhancement
            // 
            correlationtoken15.Name = "newToken";
            correlationtoken15.OwnerActivityName = "stateNew";
            this.completeNewEnhancement.CorrelationToken = correlationtoken15;
            this.completeNewEnhancement.Name = "completeNewEnhancement";
            this.completeNewEnhancement.TaskId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.completeNewEnhancement.TaskOutcome = null;
            this.completeNewEnhancement.MethodInvoking += new System.EventHandler(this.completeTask_MethodInvoking);
            // 
            // setNewWad
            // 
            this.setNewWad.Name = "setNewWad";
            this.setNewWad.TargetStateName = "stateWaiting";
            // 
            // completeNewWad
            // 
            correlationtoken16.Name = "newToken";
            correlationtoken16.OwnerActivityName = "stateNew";
            this.completeNewWad.CorrelationToken = correlationtoken16;
            this.completeNewWad.Name = "completeNewWad";
            this.completeNewWad.TaskId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.completeNewWad.TaskOutcome = null;
            this.completeNewWad.MethodInvoking += new System.EventHandler(this.completeTask_MethodInvoking);
            // 
            // setNewMoreInfo
            // 
            this.setNewMoreInfo.Name = "setNewMoreInfo";
            this.setNewMoreInfo.TargetStateName = "stateWaiting";
            // 
            // completeNewMoreInfo
            // 
            correlationtoken17.Name = "newToken";
            correlationtoken17.OwnerActivityName = "stateNew";
            this.completeNewMoreInfo.CorrelationToken = correlationtoken17;
            this.completeNewMoreInfo.Name = "completeNewMoreInfo";
            this.completeNewMoreInfo.TaskId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.completeNewMoreInfo.TaskOutcome = null;
            this.completeNewMoreInfo.MethodInvoking += new System.EventHandler(this.completeTask_MethodInvoking);
            // 
            // setNewAssign
            // 
            this.setNewAssign.Name = "setNewAssign";
            this.setNewAssign.TargetStateName = "stateAssigned";
            // 
            // completeNewAssign
            // 
            correlationtoken18.Name = "newToken";
            correlationtoken18.OwnerActivityName = "stateNew";
            this.completeNewAssign.CorrelationToken = correlationtoken18;
            this.completeNewAssign.Name = "completeNewAssign";
            this.completeNewAssign.TaskId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.completeNewAssign.TaskOutcome = null;
            this.completeNewAssign.MethodInvoking += new System.EventHandler(this.completeTask_MethodInvoking);
            // 
            // ifWaitingResubmit
            // 
            this.ifWaitingResubmit.Activities.Add(this.completeResubmit);
            this.ifWaitingResubmit.Activities.Add(this.ifElseActivity9);
            ruleconditionreference3.ConditionName = "Resubmit";
            this.ifWaitingResubmit.Condition = ruleconditionreference3;
            this.ifWaitingResubmit.Name = "ifWaitingResubmit";
            // 
            // ifWaitingClose
            // 
            this.ifWaitingClose.Activities.Add(this.completeWaiting);
            this.ifWaitingClose.Activities.Add(this.ifElseActivity8);
            this.ifWaitingClose.Activities.Add(this.codeWaitingClosed);
            this.ifWaitingClose.Activities.Add(this.setWaitingFinal);
            ruleconditionreference4.ConditionName = "Close";
            this.ifWaitingClose.Condition = ruleconditionreference4;
            this.ifWaitingClose.Name = "ifWaitingClose";
            // 
            // elseMoreInfo
            // 
            this.elseMoreInfo.Activities.Add(this.createWaitingMoreInfoTask);
            this.elseMoreInfo.Name = "elseMoreInfo";
            // 
            // ifWaitingEnhancement
            // 
            this.ifWaitingEnhancement.Activities.Add(this.createWaitingEnhancementTask);
            ruleconditionreference5.ConditionName = "Enhancement";
            this.ifWaitingEnhancement.Condition = ruleconditionreference5;
            this.ifWaitingEnhancement.Name = "ifWaitingEnhancement";
            // 
            // ifWaitingWad
            // 
            this.ifWaitingWad.Activities.Add(this.createWaitingWadTask);
            ruleconditionreference6.ConditionName = "Wad";
            this.ifWaitingWad.Condition = ruleconditionreference6;
            this.ifWaitingWad.Name = "ifWaitingWad";
            // 
            // ifNotResolved
            // 
            this.ifNotResolved.Activities.Add(this.completeNotResolved);
            this.ifNotResolved.Activities.Add(this.updateNoResolved);
            this.ifNotResolved.Activities.Add(this.setResolvedAssigned);
            ruleconditionreference7.ConditionName = "notResolved";
            this.ifNotResolved.Condition = ruleconditionreference7;
            this.ifNotResolved.Name = "ifNotResolved";
            // 
            // ifResolved
            // 
            this.ifResolved.Activities.Add(this.completeResolved);
            this.ifResolved.Activities.Add(this.completeResolvedWork);
            this.ifResolved.Activities.Add(this.codeResolvedSetClosed);
            this.ifResolved.Activities.Add(this.setResolvedFinal);
            ruleconditionreference8.ConditionName = "Resolved";
            this.ifResolved.Condition = ruleconditionreference8;
            this.ifResolved.Name = "ifResolved";
            // 
            // ifActiveEnhancement
            // 
            this.ifActiveEnhancement.Activities.Add(this.updateActiveEnhancement);
            this.ifActiveEnhancement.Activities.Add(this.setActiveEnhancement);
            ruleconditionreference9.ConditionName = "Enhancement";
            this.ifActiveEnhancement.Condition = ruleconditionreference9;
            this.ifActiveEnhancement.Name = "ifActiveEnhancement";
            // 
            // ifActiveWad
            // 
            this.ifActiveWad.Activities.Add(this.updateActiveWad);
            this.ifActiveWad.Activities.Add(this.setActiveWad);
            ruleconditionreference10.ConditionName = "Wad";
            this.ifActiveWad.Condition = ruleconditionreference10;
            this.ifActiveWad.Name = "ifActiveWad";
            // 
            // ifActiveMoreInfo
            // 
            this.ifActiveMoreInfo.Activities.Add(this.updateActiveMoreInfo);
            this.ifActiveMoreInfo.Activities.Add(this.setActiveMoreInfo);
            ruleconditionreference11.ConditionName = "MoreInfo";
            this.ifActiveMoreInfo.Condition = ruleconditionreference11;
            this.ifActiveMoreInfo.Name = "ifActiveMoreInfo";
            // 
            // ifActiveCompleted
            // 
            this.ifActiveCompleted.Activities.Add(this.updateActiveCompleted);
            this.ifActiveCompleted.Activities.Add(this.setActiveResolved);
            ruleconditionreference12.ConditionName = "Completed";
            this.ifActiveCompleted.Condition = ruleconditionreference12;
            this.ifActiveCompleted.Name = "ifActiveCompleted";
            // 
            // ifActivePause
            // 
            this.ifActivePause.Activities.Add(this.setActiveAssigned);
            ruleconditionreference13.ConditionName = "Pause";
            this.ifActivePause.Condition = ruleconditionreference13;
            this.ifActivePause.Name = "ifActivePause";
            // 
            // ifAssignedEnhancement
            // 
            this.ifAssignedEnhancement.Activities.Add(this.updateAssignedEnhancement);
            this.ifAssignedEnhancement.Activities.Add(this.setAssignedEnhancement);
            ruleconditionreference14.ConditionName = "Enhancement";
            this.ifAssignedEnhancement.Condition = ruleconditionreference14;
            this.ifAssignedEnhancement.Name = "ifAssignedEnhancement";
            // 
            // ifAssignedWad
            // 
            this.ifAssignedWad.Activities.Add(this.updateAssignedWad);
            this.ifAssignedWad.Activities.Add(this.setAssignedWad);
            ruleconditionreference15.ConditionName = "Wad";
            this.ifAssignedWad.Condition = ruleconditionreference15;
            this.ifAssignedWad.Name = "ifAssignedWad";
            // 
            // ifAssignedMoreInfo
            // 
            this.ifAssignedMoreInfo.Activities.Add(this.updateAssignedMoreInfo);
            this.ifAssignedMoreInfo.Activities.Add(this.setAssignedMoreInfo);
            ruleconditionreference16.ConditionName = "MoreInfo";
            this.ifAssignedMoreInfo.Condition = ruleconditionreference16;
            this.ifAssignedMoreInfo.Name = "ifAssignedMoreInfo";
            // 
            // ifAssignedCompleted
            // 
            this.ifAssignedCompleted.Activities.Add(this.updateAssignedResolved);
            this.ifAssignedCompleted.Activities.Add(this.setAssignedResolved);
            ruleconditionreference17.ConditionName = "Completed";
            this.ifAssignedCompleted.Condition = ruleconditionreference17;
            this.ifAssignedCompleted.Name = "ifAssignedCompleted";
            // 
            // ifAssignedStart
            // 
            this.ifAssignedStart.Activities.Add(this.setAssignedActive);
            ruleconditionreference18.ConditionName = "Start";
            this.ifAssignedStart.Condition = ruleconditionreference18;
            this.ifAssignedStart.Name = "ifAssignedStart";
            // 
            // ifElseBranchActivity2
            // 
            this.ifElseBranchActivity2.Name = "ifElseBranchActivity2";
            // 
            // ifNotCreated
            // 
            this.ifNotCreated.Activities.Add(this.createAssignedTask);
            ruleconditionreference19.ConditionName = "notCreated";
            this.ifNotCreated.Condition = ruleconditionreference19;
            this.ifNotCreated.Name = "ifNotCreated";
            // 
            // ifNewEnhancement
            // 
            this.ifNewEnhancement.Activities.Add(this.completeNewEnhancement);
            this.ifNewEnhancement.Activities.Add(this.setNewEnhancement);
            ruleconditionreference20.ConditionName = "Enhancement";
            this.ifNewEnhancement.Condition = ruleconditionreference20;
            this.ifNewEnhancement.Name = "ifNewEnhancement";
            // 
            // ifNewWad
            // 
            this.ifNewWad.Activities.Add(this.completeNewWad);
            this.ifNewWad.Activities.Add(this.setNewWad);
            ruleconditionreference21.ConditionName = "Wad";
            this.ifNewWad.Condition = ruleconditionreference21;
            this.ifNewWad.Name = "ifNewWad";
            // 
            // ifNewMoreInfo
            // 
            this.ifNewMoreInfo.Activities.Add(this.completeNewMoreInfo);
            this.ifNewMoreInfo.Activities.Add(this.setNewMoreInfo);
            ruleconditionreference22.ConditionName = "MoreInfo";
            this.ifNewMoreInfo.Condition = ruleconditionreference22;
            this.ifNewMoreInfo.Name = "ifNewMoreInfo";
            // 
            // ifNewAssign
            // 
            this.ifNewAssign.Activities.Add(this.completeNewAssign);
            this.ifNewAssign.Activities.Add(this.setNewAssign);
            ruleconditionreference23.ConditionName = "Assign";
            this.ifNewAssign.Condition = ruleconditionreference23;
            this.ifNewAssign.Name = "ifNewAssign";
            // 
            // ifElseActivity7
            // 
            this.ifElseActivity7.Activities.Add(this.ifWaitingClose);
            this.ifElseActivity7.Activities.Add(this.ifWaitingResubmit);
            this.ifElseActivity7.Name = "ifElseActivity7";
            // 
            // onWaitingChanged
            // 
            this.onWaitingChanged.AfterProperties = null;
            this.onWaitingChanged.BeforeProperties = null;
            this.onWaitingChanged.CorrelationToken = correlationtoken3;
            this.onWaitingChanged.Executor = null;
            this.onWaitingChanged.Name = "onWaitingChanged";
            this.onWaitingChanged.TaskId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.onWaitingChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onWaitingChanged_Invoked);
            // 
            // codeInitWaiting
            // 
            this.codeInitWaiting.Name = "codeInitWaiting";
            this.codeInitWaiting.ExecuteCode += new System.EventHandler(this.codeInitWaiting_ExecuteCode);
            // 
            // ifElseActivity2
            // 
            this.ifElseActivity2.Activities.Add(this.ifWaitingWad);
            this.ifElseActivity2.Activities.Add(this.ifWaitingEnhancement);
            this.ifElseActivity2.Activities.Add(this.elseMoreInfo);
            this.ifElseActivity2.Name = "ifElseActivity2";
            // 
            // ifElseActivity6
            // 
            this.ifElseActivity6.Activities.Add(this.ifResolved);
            this.ifElseActivity6.Activities.Add(this.ifNotResolved);
            this.ifElseActivity6.Name = "ifElseActivity6";
            // 
            // onResolvedChanged
            // 
            this.onResolvedChanged.AfterProperties = null;
            this.onResolvedChanged.BeforeProperties = null;
            this.onResolvedChanged.CorrelationToken = correlationtoken7;
            this.onResolvedChanged.Executor = null;
            this.onResolvedChanged.Name = "onResolvedChanged";
            this.onResolvedChanged.TaskId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.onResolvedChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onResolvedChanged_Invoked);
            // 
            // codeInitResolved
            // 
            this.codeInitResolved.Name = "codeInitResolved";
            this.codeInitResolved.ExecuteCode += new System.EventHandler(this.codeInitResolved_ExecuteCode);
            // 
            // createResolvedTask
            // 
            this.createResolvedTask.ContentTypeId = "0x010801004B4F04C5416D1C4BACC3AC5398E42808";
            this.createResolvedTask.CorrelationToken = correlationtoken7;
            this.createResolvedTask.ListItemId = -1;
            this.createResolvedTask.Name = "createResolvedTask";
            this.createResolvedTask.SpecialPermissions = null;
            this.createResolvedTask.TaskId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.createResolvedTask.TaskProperties = null;
            this.createResolvedTask.MethodInvoking += new System.EventHandler(this.createResolvedTask_MethodInvoking);
            // 
            // ifElseActivity5
            // 
            this.ifElseActivity5.Activities.Add(this.ifActivePause);
            this.ifElseActivity5.Activities.Add(this.ifActiveCompleted);
            this.ifElseActivity5.Activities.Add(this.ifActiveMoreInfo);
            this.ifElseActivity5.Activities.Add(this.ifActiveWad);
            this.ifElseActivity5.Activities.Add(this.ifActiveEnhancement);
            this.ifElseActivity5.Name = "ifElseActivity5";
            // 
            // onActiveChanged
            // 
            this.onActiveChanged.AfterProperties = null;
            this.onActiveChanged.BeforeProperties = null;
            correlationtoken19.Name = "taskToken";
            correlationtoken19.OwnerActivityName = "Workflow1";
            this.onActiveChanged.CorrelationToken = correlationtoken19;
            this.onActiveChanged.Executor = null;
            this.onActiveChanged.Name = "onActiveChanged";
            this.onActiveChanged.TaskId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.onActiveChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onActiveChanged_Invoked);
            // 
            // codeInitActive
            // 
            this.codeInitActive.Name = "codeInitActive";
            this.codeInitActive.ExecuteCode += new System.EventHandler(this.codeInitActive_ExecuteCode);
            // 
            // ifElseActivity4
            // 
            this.ifElseActivity4.Activities.Add(this.ifAssignedStart);
            this.ifElseActivity4.Activities.Add(this.ifAssignedCompleted);
            this.ifElseActivity4.Activities.Add(this.ifAssignedMoreInfo);
            this.ifElseActivity4.Activities.Add(this.ifAssignedWad);
            this.ifElseActivity4.Activities.Add(this.ifAssignedEnhancement);
            this.ifElseActivity4.Name = "ifElseActivity4";
            // 
            // onAssignedChanged
            // 
            this.onAssignedChanged.AfterProperties = null;
            this.onAssignedChanged.BeforeProperties = null;
            this.onAssignedChanged.CorrelationToken = correlationtoken1;
            this.onAssignedChanged.Executor = null;
            this.onAssignedChanged.Name = "onAssignedChanged";
            this.onAssignedChanged.TaskId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.onAssignedChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAssignedChanged_Invoked);
            // 
            // codeInitAssigned
            // 
            this.codeInitAssigned.Name = "codeInitAssigned";
            this.codeInitAssigned.ExecuteCode += new System.EventHandler(this.codeInitAssigned_ExecuteCode);
            // 
            // ifElseActivity1
            // 
            this.ifElseActivity1.Activities.Add(this.ifNotCreated);
            this.ifElseActivity1.Activities.Add(this.ifElseBranchActivity2);
            this.ifElseActivity1.Name = "ifElseActivity1";
            // 
            // ifElseActivity3
            // 
            this.ifElseActivity3.Activities.Add(this.ifNewAssign);
            this.ifElseActivity3.Activities.Add(this.ifNewMoreInfo);
            this.ifElseActivity3.Activities.Add(this.ifNewWad);
            this.ifElseActivity3.Activities.Add(this.ifNewEnhancement);
            this.ifElseActivity3.Name = "ifElseActivity3";
            // 
            // onNewChanged
            // 
            this.onNewChanged.AfterProperties = null;
            this.onNewChanged.BeforeProperties = null;
            this.onNewChanged.CorrelationToken = correlationtoken18;
            this.onNewChanged.Executor = null;
            this.onNewChanged.Name = "onNewChanged";
            this.onNewChanged.TaskId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.onNewChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onNewChanged_Invoked);
            // 
            // codeInitNew
            // 
            this.codeInitNew.Name = "codeInitNew";
            this.codeInitNew.ExecuteCode += new System.EventHandler(this.codeInitNew_ExecuteCode);
            // 
            // createNewTask
            // 
            this.createNewTask.ContentTypeId = "0x01080100BFA6DC6952E01F409220B15B87FB5253";
            this.createNewTask.CorrelationToken = correlationtoken18;
            this.createNewTask.ListItemId = -1;
            this.createNewTask.Name = "createNewTask";
            this.createNewTask.SpecialPermissions = null;
            this.createNewTask.TaskId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.createNewTask.TaskProperties = null;
            this.createNewTask.MethodInvoking += new System.EventHandler(this.createNewTask_MethodInvoking);
            // 
            // setInitialNew
            // 
            this.setInitialNew.Name = "setInitialNew";
            this.setInitialNew.TargetStateName = "stateNew";
            // 
            // onWorkflowActivated1
            // 
            correlationtoken20.Name = "workflowToken";
            correlationtoken20.OwnerActivityName = "Workflow1";
            this.onWorkflowActivated1.CorrelationToken = correlationtoken20;
            this.onWorkflowActivated1.EventName = "OnWorkflowActivated";
            this.onWorkflowActivated1.Name = "onWorkflowActivated1";
            activitybind21.Name = "Workflow1";
            activitybind21.Path = "workflowProperties";
            this.onWorkflowActivated1.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onWorkflowActivated1_Invoked);
            this.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind21)));
            // 
            // eventWaiting
            // 
            this.eventWaiting.Activities.Add(this.onWaitingChanged);
            this.eventWaiting.Activities.Add(this.ifElseActivity7);
            this.eventWaiting.Name = "eventWaiting";
            // 
            // initWaiting
            // 
            this.initWaiting.Activities.Add(this.ifElseActivity2);
            this.initWaiting.Activities.Add(this.codeInitWaiting);
            this.initWaiting.Name = "initWaiting";
            // 
            // eventResolved
            // 
            this.eventResolved.Activities.Add(this.onResolvedChanged);
            this.eventResolved.Activities.Add(this.ifElseActivity6);
            this.eventResolved.Name = "eventResolved";
            // 
            // initResolved
            // 
            this.initResolved.Activities.Add(this.createResolvedTask);
            this.initResolved.Activities.Add(this.codeInitResolved);
            this.initResolved.Name = "initResolved";
            // 
            // eventActive
            // 
            this.eventActive.Activities.Add(this.onActiveChanged);
            this.eventActive.Activities.Add(this.ifElseActivity5);
            this.eventActive.Name = "eventActive";
            // 
            // initActive
            // 
            this.initActive.Activities.Add(this.codeInitActive);
            this.initActive.Name = "initActive";
            // 
            // eventAssigned
            // 
            this.eventAssigned.Activities.Add(this.onAssignedChanged);
            this.eventAssigned.Activities.Add(this.ifElseActivity4);
            this.eventAssigned.Name = "eventAssigned";
            // 
            // initAssigned
            // 
            this.initAssigned.Activities.Add(this.ifElseActivity1);
            this.initAssigned.Activities.Add(this.codeInitAssigned);
            this.initAssigned.Name = "initAssigned";
            // 
            // eventNew
            // 
            this.eventNew.Activities.Add(this.onNewChanged);
            this.eventNew.Activities.Add(this.ifElseActivity3);
            this.eventNew.Name = "eventNew";
            // 
            // initNew
            // 
            this.initNew.Activities.Add(this.createNewTask);
            this.initNew.Activities.Add(this.codeInitNew);
            this.initNew.Name = "initNew";
            // 
            // eventInitial
            // 
            this.eventInitial.Activities.Add(this.onWorkflowActivated1);
            this.eventInitial.Activities.Add(this.setInitialNew);
            this.eventInitial.Name = "eventInitial";
            // 
            // stateWaiting
            // 
            this.stateWaiting.Activities.Add(this.initWaiting);
            this.stateWaiting.Activities.Add(this.eventWaiting);
            this.stateWaiting.Name = "stateWaiting";
            // 
            // stateResolved
            // 
            this.stateResolved.Activities.Add(this.initResolved);
            this.stateResolved.Activities.Add(this.eventResolved);
            this.stateResolved.Name = "stateResolved";
            // 
            // stateActive
            // 
            this.stateActive.Activities.Add(this.initActive);
            this.stateActive.Activities.Add(this.eventActive);
            this.stateActive.Name = "stateActive";
            // 
            // stateAssigned
            // 
            this.stateAssigned.Activities.Add(this.initAssigned);
            this.stateAssigned.Activities.Add(this.eventAssigned);
            this.stateAssigned.Name = "stateAssigned";
            // 
            // stateNew
            // 
            this.stateNew.Activities.Add(this.initNew);
            this.stateNew.Activities.Add(this.eventNew);
            this.stateNew.Name = "stateNew";
            // 
            // stateFinal
            // 
            this.stateFinal.Name = "stateFinal";
            // 
            // stateInitial
            // 
            this.stateInitial.Activities.Add(this.eventInitial);
            this.stateInitial.Name = "stateInitial";
            // 
            // Workflow1
            // 
            this.Activities.Add(this.stateInitial);
            this.Activities.Add(this.stateFinal);
            this.Activities.Add(this.stateNew);
            this.Activities.Add(this.stateAssigned);
            this.Activities.Add(this.stateActive);
            this.Activities.Add(this.stateResolved);
            this.Activities.Add(this.stateWaiting);
            this.CompletedStateName = "stateFinal";
            this.DynamicUpdateCondition = null;
            this.InitialStateName = "stateInitial";
            this.Name = "Workflow1";
            this.CanModifyActivities = false;

        }

        #endregion

        private SetStateActivity setAssignedEnhancement;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask updateAssignedEnhancement;

        private SetStateActivity setAssignedWad;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask updateAssignedWad;

        private SetStateActivity setAssignedMoreInfo;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask updateAssignedMoreInfo;

        private SetStateActivity setAssignedResolved;

        private SetStateActivity setActiveEnhancement;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask updateActiveEnhancement;

        private SetStateActivity setActiveWad;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask updateActiveWad;

        private SetStateActivity setActiveMoreInfo;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask updateActiveMoreInfo;

        private SetStateActivity setActiveResolved;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask updateActiveCompleted;

        private SetStateActivity setActiveAssigned;

        private IfElseBranchActivity ifActiveEnhancement;

        private IfElseBranchActivity ifActiveWad;

        private IfElseBranchActivity ifActiveMoreInfo;

        private IfElseBranchActivity ifActiveCompleted;

        private IfElseBranchActivity ifActivePause;

        private IfElseActivity ifElseActivity5;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onActiveChanged;

        private IfElseBranchActivity ifNotResolved;

        private IfElseBranchActivity ifResolved;

        private IfElseActivity ifElseActivity6;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onResolvedChanged;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask updateNoResolved;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask completeNotResolved;

        private SetStateActivity setResolvedFinal;

        private CodeActivity codeResolvedSetClosed;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask completeResolvedWork;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask completeResolved;

        private SetStateActivity setResolvedAssigned;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask updateWaiting;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask completeWaitingWork;

        private IfElseBranchActivity ifElseBranchActivity5;

        private IfElseBranchActivity ifWorkTaskResubmit;

        private IfElseBranchActivity ifElseBranchActivity3;

        private IfElseBranchActivity ifWorkTask;

        private IfElseActivity ifElseActivity9;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask completeResubmit;

        private SetStateActivity setWaitingFinal;

        private CodeActivity codeWaitingClosed;

        private IfElseActivity ifElseActivity8;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask completeWaiting;

        private IfElseBranchActivity ifWaitingResubmit;

        private IfElseBranchActivity ifWaitingClose;

        private IfElseActivity ifElseActivity7;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onWaitingChanged;

        private SetStateActivity setWaitingNew;

        private SetStateActivity setWaitingAssigned;

        private SetStateActivity setNewEnhancement;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask completeNewEnhancement;

        private SetStateActivity setNewWad;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask completeNewWad;

        private SetStateActivity setNewMoreInfo;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask completeNewMoreInfo;

        private SetStateActivity setNewAssign;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAssignedChanged;

        private Microsoft.SharePoint.WorkflowActions.UpdateTask updateAssignedResolved;

        private SetStateActivity setAssignedActive;

        private IfElseBranchActivity ifAssignedEnhancement;

        private IfElseBranchActivity ifAssignedWad;

        private IfElseBranchActivity ifAssignedMoreInfo;

        private IfElseBranchActivity ifAssignedCompleted;

        private IfElseBranchActivity ifAssignedStart;

        private IfElseActivity ifElseActivity4;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask completeNewAssign;

        private IfElseBranchActivity ifNewEnhancement;

        private IfElseBranchActivity ifNewWad;

        private IfElseBranchActivity ifNewMoreInfo;

        private IfElseBranchActivity ifNewAssign;

        private IfElseActivity ifElseActivity3;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onNewChanged;

        private SetStateActivity setInitialNew;

        private EventDrivenActivity eventWaiting;

        private EventDrivenActivity eventResolved;

        private EventDrivenActivity eventActive;

        private EventDrivenActivity eventAssigned;

        private EventDrivenActivity eventNew;

        private CodeActivity codeInitWaiting;

        private IfElseBranchActivity ifElseBranchActivity2;

        private IfElseBranchActivity ifNotCreated;

        private IfElseActivity ifElseActivity1;

        private CodeActivity codeInitNew;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType createNewTask;

        private StateInitializationActivity initWaiting;

        private StateInitializationActivity initResolved;

        private StateInitializationActivity initActive;

        private StateInitializationActivity initAssigned;

        private StateInitializationActivity initNew;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType createAssignedTask;

        private CodeActivity codeInitAssigned;

        private CodeActivity codeInitActive;

        private CodeActivity codeInitResolved;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType createResolvedTask;

        private IfElseBranchActivity elseMoreInfo;

        private IfElseBranchActivity ifWaitingEnhancement;

        private IfElseBranchActivity ifWaitingWad;

        private IfElseActivity ifElseActivity2;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType createWaitingMoreInfoTask;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType createWaitingEnhancementTask;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType createWaitingWadTask;

        private StateActivity stateWaiting;

        private StateActivity stateResolved;

        private StateActivity stateActive;

        private StateActivity stateAssigned;

        private StateActivity stateNew;

        private StateActivity stateFinal;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated onWorkflowActivated1;

        private EventDrivenActivity eventInitial;

        private StateActivity stateInitial;












































    }
}
