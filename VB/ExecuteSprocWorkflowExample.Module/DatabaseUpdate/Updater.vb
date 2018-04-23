Imports System
Imports System.Linq
Imports DevExpress.ExpressApp
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.Workflow.Xpo

Namespace ExecuteSprocWorkflowExample.Module.DatabaseUpdate
    ' For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppUpdatingModuleUpdatertopic.aspx
    Public Class Updater
        Inherits ModuleUpdater

        Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub
        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            MyBase.UpdateDatabaseAfterUpdateSchema()
            'string name = "MyName";
            'DomainObject1 theObject = ObjectSpace.FindObject<DomainObject1>(CriteriaOperator.Parse("Name=?", name));
            'if(theObject == null) {
            '    theObject = ObjectSpace.CreateObject<DomainObject1>();
            '    theObject.Name = name;
            '}
            Dim definition As XpoWorkflowDefinition = ObjectSpace.CreateObject(Of XpoWorkflowDefinition)()
            definition.Name = "CallStoredProc"
            definition.Xaml = wfDefinition
            ObjectSpace.CommitChanges()
        End Sub
        Public Overrides Sub UpdateDatabaseBeforeUpdateSchema()
            MyBase.UpdateDatabaseBeforeUpdateSchema()
            'if(CurrentDBVersion < new Version("1.1.0.0") && CurrentDBVersion > new Version("0.0.0.0")) {
            '    RenameColumn("DomainObject1Table", "OldColumnName", "NewColumnName");
            '}
        End Sub
        Private Const wfDefinition As String = "" & ControlChars.CrLf & _
"<Activity mc:Ignorable=""sads sap"" x:Class=""DevExpress.Workflow.XafWorkflow""" & ControlChars.CrLf & _
" xmlns=""http://schemas.microsoft.com/netfx/2009/xaml/activities""" & ControlChars.CrLf & _
" xmlns:de=""clr-namespace:DevExpress.ExpressApp;assembly=DevExpress.ExpressApp.Xpo.v15.1""" & ControlChars.CrLf & _
" xmlns:de1=""clr-namespace:DevExpress.ExpressApp;assembly=DevExpress.ExpressApp.v15.1""" & ControlChars.CrLf & _
" xmlns:de2=""clr-namespace:DevExpress.ExpressApp;assembly=DevExpress.Persistent.Base.v15.1""" & ControlChars.CrLf & _
" xmlns:dex=""clr-namespace:DevExpress.ExpressApp.Xpo;assembly=DevExpress.ExpressApp.Xpo.v15.1""" & ControlChars.CrLf & _
" xmlns:dwa=""clr-namespace:DevExpress.Workflow.Activities;assembly=DevExpress.Workflow.Activities.v15.1""" & ControlChars.CrLf & _
" xmlns:dx=""clr-namespace:DevExpress.Xpo;assembly=DevExpress.Data.v15.1""" & ControlChars.CrLf & _
" xmlns:dx1=""clr-namespace:DevExpress.Xpo;assembly=DevExpress.Xpo.v15.1""" & ControlChars.CrLf & _
" xmlns:dxh=""clr-namespace:DevExpress.Xpo.Helpers;assembly=DevExpress.Data.v15.1""" & ControlChars.CrLf & _
" xmlns:dxh1=""clr-namespace:DevExpress.Xpo.Helpers;assembly=DevExpress.Xpo.v15.1""" & ControlChars.CrLf & _
" xmlns:dxmh=""clr-namespace:DevExpress.Xpo.Metadata.Helpers;assembly=DevExpress.Xpo.v15.1""" & ControlChars.CrLf & _
" xmlns:mc=""http://schemas.openxmlformats.org/markup-compatibility/2006""" & ControlChars.CrLf & _
" xmlns:mva=""clr-namespace:Microsoft.VisualBasic.Activities;assembly=System.Activities""" & ControlChars.CrLf & _
" xmlns:sa=""clr-namespace:System.Activities;assembly=System.Activities""" & ControlChars.CrLf & _
" xmlns:sads=""http://schemas.microsoft.com/netfx/2010/xaml/activities/debugger""" & ControlChars.CrLf & _
" xmlns:sap=""http://schemas.microsoft.com/netfx/2009/xaml/activities/presentation""" & ControlChars.CrLf & _
" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">" & ControlChars.CrLf & _
"  <x:Members>" & ControlChars.CrLf & _
"    <x:Property Name=""targetObjectId"" Type=""InArgument(x:Object)"" />" & ControlChars.CrLf & _
"  </x:Members>" & ControlChars.CrLf & _
"  <sap:VirtualizedContainerService.HintSize>308,396</sap:VirtualizedContainerService.HintSize>" & ControlChars.CrLf & _
"  <mva:VisualBasic.Settings>Assembly references and imported namespaces for internal implementation</mva:VisualBasic.Settings>" & ControlChars.CrLf & _
"  <dwa:ObjectSpaceTransactionScope AutoCommit=""True"" sap:VirtualizedContainerService.HintSize=""268,356"">" & ControlChars.CrLf & _
"    <dwa:ObjectSpaceTransactionScope.Variables>" & ControlChars.CrLf & _
"      <Variable x:TypeArguments=""de1:IObjectSpace"" Name=""objectSpace"" />" & ControlChars.CrLf & _
"      <Variable x:TypeArguments=""dex:XPObjectSpace"" Name=""xpObjectSpace"" />" & ControlChars.CrLf & _
"    </dwa:ObjectSpaceTransactionScope.Variables>" & ControlChars.CrLf & _
"    <dwa:TransactionalGetObjectSpace sap:VirtualizedContainerService.HintSize=""242,22"" Result=""[objectSpace]"" />" & ControlChars.CrLf & _
"    <Assign sap:VirtualizedContainerService.HintSize=""242,60"">" & ControlChars.CrLf & _
"      <Assign.To>" & ControlChars.CrLf & _
"        <OutArgument x:TypeArguments=""dex:XPObjectSpace"">[xpObjectSpace]</OutArgument>" & ControlChars.CrLf & _
"      </Assign.To>" & ControlChars.CrLf & _
"      <Assign.Value>" & ControlChars.CrLf & _
"        <InArgument x:TypeArguments=""dex:XPObjectSpace"">[CType(objectSpace, XPObjectSpace)]</InArgument>" & ControlChars.CrLf & _
"      </Assign.Value>" & ControlChars.CrLf & _
"    </Assign>" & ControlChars.CrLf & _
"    <InvokeMethod sap:VirtualizedContainerService.HintSize=""242,126"" MethodName=""ExecuteSproc"">" & ControlChars.CrLf & _
"      <InvokeMethod.TargetObject>" & ControlChars.CrLf & _
"        <InArgument x:TypeArguments=""dx1:Session"">[xpObjectSpace.Session]</InArgument>" & ControlChars.CrLf & _
"      </InvokeMethod.TargetObject>" & ControlChars.CrLf & _
"      <InArgument x:TypeArguments=""x:String"">ProcName</InArgument>" & ControlChars.CrLf & _
"    </InvokeMethod>" & ControlChars.CrLf & _
"  </dwa:ObjectSpaceTransactionScope>" & ControlChars.CrLf & _
"</Activity>"
    End Class
End Namespace
