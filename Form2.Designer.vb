<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblPunkteStand = New System.Windows.Forms.Label()
        Me.CmdExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPunkteStand
        '
        Me.lblPunkteStand.AutoSize = True
        Me.lblPunkteStand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPunkteStand.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPunkteStand.ForeColor = System.Drawing.Color.Red
        Me.lblPunkteStand.Location = New System.Drawing.Point(40, 29)
        Me.lblPunkteStand.Name = "lblPunkteStand"
        Me.lblPunkteStand.Size = New System.Drawing.Size(2, 39)
        Me.lblPunkteStand.TabIndex = 0
        '
        'CmdExit
        '
        Me.CmdExit.Location = New System.Drawing.Point(56, 364)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(138, 54)
        Me.CmdExit.TabIndex = 1
        Me.CmdExit.Text = "Beenden"
        Me.CmdExit.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.lblPunkteStand)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPunkteStand As Label
    Friend WithEvents CmdExit As Button
End Class
