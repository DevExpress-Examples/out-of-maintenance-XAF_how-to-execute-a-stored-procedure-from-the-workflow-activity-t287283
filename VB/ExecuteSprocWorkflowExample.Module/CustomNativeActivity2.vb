Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.Workflow.Activities
Imports System
Imports System.Activities
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace ExecuteSprocWorkflowExample.Module
    Public Class CustomNativeActivity2
        Inherits NativeActivity

        Protected Overrides Sub Execute(ByVal context As NativeActivityContext)

            Dim xpObjectSpace_Renamed As XPObjectSpace = Me.XPObjectSpace.Get(context)
            xpObjectSpace_Renamed.Session.ExecuteSproc("StoredProcName")
        End Sub
        <System.ComponentModel.DefaultValue(CType(Nothing, Object))> _
        Public Property XPObjectSpace() As InArgument(Of XPObjectSpace)
    End Class
End Namespace
