Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.Workflow.Activities
Imports System
Imports System.Activities
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace ExecuteSprocWorkflowExample.Module
    Public Class CustomNativeActivity
        Inherits NativeActivity

        Protected Overridable Function GetObjectSpace(ByVal context As NativeActivityContext) As IObjectSpace
            Return DirectCast(context.Properties.Find(ObjectSpaceTransactionScope.ObjectSpacePropertyName), IObjectSpace)
        End Function
        Protected Overrides Sub Execute(ByVal context As NativeActivityContext)
            Dim xpObjectSpace As XPObjectSpace = DirectCast(GetObjectSpace(context), XPObjectSpace)
            xpObjectSpace.Session.ExecuteSproc("StoredProcName")
        End Sub
    End Class
End Namespace
