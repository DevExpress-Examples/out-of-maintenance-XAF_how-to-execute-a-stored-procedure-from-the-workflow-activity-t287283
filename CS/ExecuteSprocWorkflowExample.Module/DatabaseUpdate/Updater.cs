using System;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Workflow.Xpo;

namespace ExecuteSprocWorkflowExample.Module.DatabaseUpdate {
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppUpdatingModuleUpdatertopic.aspx
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
            base(objectSpace, currentDBVersion) {
        }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            //string name = "MyName";
            //DomainObject1 theObject = ObjectSpace.FindObject<DomainObject1>(CriteriaOperator.Parse("Name=?", name));
            //if(theObject == null) {
            //    theObject = ObjectSpace.CreateObject<DomainObject1>();
            //    theObject.Name = name;
            //}
            XpoWorkflowDefinition definition = ObjectSpace.CreateObject<XpoWorkflowDefinition>();
            definition.Name = "CallStoredProc";
            definition.Xaml = wfDefinition;
            ObjectSpace.CommitChanges();
        }
        public override void UpdateDatabaseBeforeUpdateSchema() {
            base.UpdateDatabaseBeforeUpdateSchema();
            //if(CurrentDBVersion < new Version("1.1.0.0") && CurrentDBVersion > new Version("0.0.0.0")) {
            //    RenameColumn("DomainObject1Table", "OldColumnName", "NewColumnName");
            //}
        }
        const string wfDefinition =
            @"
<Activity mc:Ignorable=""sads sap"" x:Class=""DevExpress.Workflow.XafWorkflow""
 xmlns=""http://schemas.microsoft.com/netfx/2009/xaml/activities""
 xmlns:de=""clr-namespace:DevExpress.ExpressApp;assembly=DevExpress.ExpressApp.Xpo.v15.1""
 xmlns:de1=""clr-namespace:DevExpress.ExpressApp;assembly=DevExpress.ExpressApp.v15.1""
 xmlns:de2=""clr-namespace:DevExpress.ExpressApp;assembly=DevExpress.Persistent.Base.v15.1""
 xmlns:dex=""clr-namespace:DevExpress.ExpressApp.Xpo;assembly=DevExpress.ExpressApp.Xpo.v15.1""
 xmlns:dwa=""clr-namespace:DevExpress.Workflow.Activities;assembly=DevExpress.Workflow.Activities.v15.1""
 xmlns:dx=""clr-namespace:DevExpress.Xpo;assembly=DevExpress.Data.v15.1""
 xmlns:dx1=""clr-namespace:DevExpress.Xpo;assembly=DevExpress.Xpo.v15.1""
 xmlns:dxh=""clr-namespace:DevExpress.Xpo.Helpers;assembly=DevExpress.Data.v15.1""
 xmlns:dxh1=""clr-namespace:DevExpress.Xpo.Helpers;assembly=DevExpress.Xpo.v15.1""
 xmlns:dxmh=""clr-namespace:DevExpress.Xpo.Metadata.Helpers;assembly=DevExpress.Xpo.v15.1""
 xmlns:mc=""http://schemas.openxmlformats.org/markup-compatibility/2006""
 xmlns:mva=""clr-namespace:Microsoft.VisualBasic.Activities;assembly=System.Activities""
 xmlns:sa=""clr-namespace:System.Activities;assembly=System.Activities""
 xmlns:sads=""http://schemas.microsoft.com/netfx/2010/xaml/activities/debugger""
 xmlns:sap=""http://schemas.microsoft.com/netfx/2009/xaml/activities/presentation""
 xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">
  <x:Members>
    <x:Property Name=""targetObjectId"" Type=""InArgument(x:Object)"" />
  </x:Members>
  <sap:VirtualizedContainerService.HintSize>308,396</sap:VirtualizedContainerService.HintSize>
  <mva:VisualBasic.Settings>Assembly references and imported namespaces for internal implementation</mva:VisualBasic.Settings>
  <dwa:ObjectSpaceTransactionScope AutoCommit=""True"" sap:VirtualizedContainerService.HintSize=""268,356"">
    <dwa:ObjectSpaceTransactionScope.Variables>
      <Variable x:TypeArguments=""de1:IObjectSpace"" Name=""objectSpace"" />
      <Variable x:TypeArguments=""dex:XPObjectSpace"" Name=""xpObjectSpace"" />
    </dwa:ObjectSpaceTransactionScope.Variables>
    <dwa:TransactionalGetObjectSpace sap:VirtualizedContainerService.HintSize=""242,22"" Result=""[objectSpace]"" />
    <Assign sap:VirtualizedContainerService.HintSize=""242,60"">
      <Assign.To>
        <OutArgument x:TypeArguments=""dex:XPObjectSpace"">[xpObjectSpace]</OutArgument>
      </Assign.To>
      <Assign.Value>
        <InArgument x:TypeArguments=""dex:XPObjectSpace"">[CType(objectSpace, XPObjectSpace)]</InArgument>
      </Assign.Value>
    </Assign>
    <InvokeMethod sap:VirtualizedContainerService.HintSize=""242,126"" MethodName=""ExecuteSproc"">
      <InvokeMethod.TargetObject>
        <InArgument x:TypeArguments=""dx1:Session"">[xpObjectSpace.Session]</InArgument>
      </InvokeMethod.TargetObject>
      <InArgument x:TypeArguments=""x:String"">ProcName</InArgument>
    </InvokeMethod>
  </dwa:ObjectSpaceTransactionScope>
</Activity>";
    }
}
