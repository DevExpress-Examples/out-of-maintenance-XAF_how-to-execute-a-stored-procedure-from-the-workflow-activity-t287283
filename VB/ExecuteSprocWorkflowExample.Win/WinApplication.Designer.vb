Namespace ExecuteSprocWorkflowExample.Win
    Partial Public Class ExecuteSprocWorkflowExampleWindowsFormsApplication
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
            Me.module3 = New ExecuteSprocWorkflowExample.Module.ExecuteSprocWorkflowExampleModule()
            Me.conditionalAppearanceModule = New DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule()
            Me.workflowModule = New DevExpress.ExpressApp.Workflow.WorkflowModule()
            Me.workflowWindowsFormsModule = New DevExpress.ExpressApp.Workflow.Win.WorkflowWindowsFormsModule()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' workflowModule
            ' 
            Me.workflowModule.RunningWorkflowInstanceInfoType = GetType(DevExpress.ExpressApp.Workflow.Xpo.XpoRunningWorkflowInstanceInfo)
            Me.workflowModule.StartWorkflowRequestType = GetType(DevExpress.ExpressApp.Workflow.Xpo.XpoStartWorkflowRequest)
            Me.workflowModule.UserActivityVersionType = GetType(DevExpress.ExpressApp.Workflow.Versioning.XpoUserActivityVersion)
            Me.workflowModule.WorkflowControlCommandRequestType = GetType(DevExpress.ExpressApp.Workflow.Xpo.XpoWorkflowInstanceControlCommandRequest)
            Me.workflowModule.WorkflowDefinitionType = GetType(DevExpress.ExpressApp.Workflow.Xpo.XpoWorkflowDefinition)
            Me.workflowModule.WorkflowInstanceKeyType = GetType(DevExpress.Workflow.Xpo.XpoInstanceKey)
            Me.workflowModule.WorkflowInstanceType = GetType(DevExpress.Workflow.Xpo.XpoWorkflowInstance)
            ' 
            ' workflowWindowsFormsModule
            ' 
            ' 
            ' ExecuteSprocWorkflowExampleWindowsFormsApplication
            ' 
            Me.ApplicationName = "ExecuteSprocWorkflowExample"
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.conditionalAppearanceModule)
            Me.Modules.Add(Me.workflowModule)
            Me.Modules.Add(Me.module3)
            Me.Modules.Add(Me.workflowWindowsFormsModule)
            Me.UseOldTemplates = False
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
        Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
        Private module3 As ExecuteSprocWorkflowExample.Module.ExecuteSprocWorkflowExampleModule
        Private conditionalAppearanceModule As DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule
        Private workflowModule As DevExpress.ExpressApp.Workflow.WorkflowModule
        Private WithEvents workflowWindowsFormsModule As DevExpress.ExpressApp.Workflow.Win.WorkflowWindowsFormsModule
    End Class
End Namespace
