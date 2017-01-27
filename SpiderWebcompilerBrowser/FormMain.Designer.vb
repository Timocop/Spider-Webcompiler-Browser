<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.WebBrowser_Editor = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'WebBrowser_Editor
        '
        Me.WebBrowser_Editor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser_Editor.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser_Editor.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser_Editor.Name = "WebBrowser_Editor"
        Me.WebBrowser_Editor.Size = New System.Drawing.Size(784, 561)
        Me.WebBrowser_Editor.TabIndex = 0
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.WebBrowser_Editor)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMain"
        Me.Text = "Spider Webcompiler - Browser"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebBrowser_Editor As WebBrowser
End Class
