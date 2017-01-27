Imports System.ComponentModel

Public Class FormMain
    Private g_mSpiderWebsite As New Uri("http://spider.limetech.org/")
    Private g_sCustomEditorFile As String = IO.Path.Combine(Application.StartupPath, "CustomWebcompiler.txt")

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If (IO.File.Exists(g_sCustomEditorFile)) Then
                g_mSpiderWebsite = New Uri(IO.File.ReadAllText(g_sCustomEditorFile))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        WebBrowser_Editor.ScriptErrorsSuppressed = True
        WebBrowser_Editor.Navigate(g_mSpiderWebsite)
    End Sub

    Private Sub WebBrowser_Editor_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser_Editor.Navigating
        If e.Url <> g_mSpiderWebsite Then
            e.Cancel = True
        End If
    End Sub

    Private Sub WebBrowser_Editor_NewWindow(sender As Object, e As CancelEventArgs) Handles WebBrowser_Editor.NewWindow
        e.Cancel = True
    End Sub
End Class
