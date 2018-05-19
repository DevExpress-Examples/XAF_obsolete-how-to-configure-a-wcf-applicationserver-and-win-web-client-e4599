Imports System.ComponentModel
Imports DevExpress.ExpressApp.Win
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp

Namespace ClientServer_Wcf_StandardAuth.Win
    Partial Public Class ClientServer_Wcf_StandardAuthWindowsFormsApplication
        Inherits WinApplication

        Public Sub New()
            InitializeComponent()
            DelayedViewItemsInitialization = True
        End Sub

        Private Sub ClientServer_Wcf_StandardAuthWindowsFormsApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)
            Throw New InvalidOperationException("The application cannot connect to the specified database, because the latter doesn't exist or its version is older than that of the application." & vbCrLf & "This error occurred  because the automatic database update was disabled when the application was started without debugging." & vbCrLf & "To avoid this error, you should either start the application under Visual Studio in debug mode, or modify the " & "source code of the 'DatabaseVersionMismatch' event handler to enable automatic database update, " & "or manually create a database using the 'DBUpdater' tool." & vbCrLf & "Anyway, refer to the 'Update Application and Database Versions' help topic at http://www.devexpress.com/Help/?document=ExpressApp/CustomDocument2795.htm " & "for more detailed information. If this doesn't help, please contact our Support Team at http://www.devexpress.com/Support/Center/")
        End Sub
    End Class
End Namespace
