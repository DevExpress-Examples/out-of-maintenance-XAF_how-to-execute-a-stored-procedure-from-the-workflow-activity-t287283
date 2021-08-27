<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128590131/15.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T287283)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[CustomNativeActivity.cs](./CS/ExecuteSprocWorkflowExample.Module/CustomNativeActivity.cs) (VB: [CustomNativeActivity2.vb](./VB/ExecuteSprocWorkflowExample.Module/CustomNativeActivity2.vb))**
* [CustomNativeActivity2.cs](./CS/ExecuteSprocWorkflowExample.Module/CustomNativeActivity2.cs) (VB: [CustomNativeActivity2.vb](./VB/ExecuteSprocWorkflowExample.Module/CustomNativeActivity2.vb))
* [WinApplication.cs](./CS/ExecuteSprocWorkflowExample.Win/WinApplication.cs) (VB: [WinApplication.vb](./VB/ExecuteSprocWorkflowExample.Win/WinApplication.vb))
<!-- default file list end -->
# How to: Execute a Stored Procedure from the Workflow Activity


When using XPO, you can call the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXpoSession_ExecuteSproctopic">Session.ExecuteSproc</a> method to execute a <a href="https://documentation.devexpress.com/#CoreLibraries/CustomDocument8919">stored procedure</a>. Use the <a href="https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument113355">TransactionalGetObjectSpace</a> activity to obtain an underlying instance of the <a href="https://documentation.devexpress.com/#eXpressAppFramework/clsDevExpressExpressAppXpoXPObjectSpacetopic">XPObjectSpace</a> class and then use <a href="https://msdn.microsoft.com/library/system.activities.codeactivity(v=vs.110).aspx">CodeActivity</a> or <a href="https://msdn.microsoft.com/library/system.activities.statements.invokemethod(v=vs.100).aspx">InvokeMethod</a> to execute an appropriate method of the <strong>Session</strong> object. This example demonstrates how to execute a stored procedure in the Workflow Designer and in code.<br /><br /><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-execute-a-stored-procedure-from-the-workflow-activity-t287283/15.1.6+/media/09abca14-5607-11e5-80bf-00155d62480c.png"><br /><br /><strong>See also:</strong><br /><a href="https://www.devexpress.com/Support/Center/p/T247923">how to create object in custom function within workflow</a> <br /><a href="https://www.devexpress.com/Support/Center/p/Q444383">How do I obtain the XafApplication’s IObjectSpace in a class that is not inherited from ViewController</a>

<br/>


