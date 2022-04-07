<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PanRechtsOben = New System.Windows.Forms.Panel()
        Me.PanUntenMittig = New System.Windows.Forms.Panel()
        Me.PanUntenRechts = New System.Windows.Forms.Panel()
        Me.PanLinksOben = New System.Windows.Forms.Panel()
        Me.PanLinksMittig = New System.Windows.Forms.Panel()
        Me.PanLinksUnten = New System.Windows.Forms.Panel()
        Me.tmrFarbenWechsel = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tmrPunktestand = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PanRechtsOben
        '
        Me.PanRechtsOben.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanRechtsOben.Location = New System.Drawing.Point(893, 12)
        Me.PanRechtsOben.Name = "PanRechtsOben"
        Me.PanRechtsOben.Size = New System.Drawing.Size(57, 51)
        Me.PanRechtsOben.TabIndex = 1
        '
        'PanUntenMittig
        '
        Me.PanUntenMittig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanUntenMittig.Location = New System.Drawing.Point(463, 447)
        Me.PanUntenMittig.Name = "PanUntenMittig"
        Me.PanUntenMittig.Size = New System.Drawing.Size(57, 51)
        Me.PanUntenMittig.TabIndex = 2
        '
        'PanUntenRechts
        '
        Me.PanUntenRechts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanUntenRechts.Location = New System.Drawing.Point(893, 438)
        Me.PanUntenRechts.Name = "PanUntenRechts"
        Me.PanUntenRechts.Size = New System.Drawing.Size(57, 51)
        Me.PanUntenRechts.TabIndex = 4
        '
        'PanLinksOben
        '
        Me.PanLinksOben.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanLinksOben.Location = New System.Drawing.Point(12, 12)
        Me.PanLinksOben.Name = "PanLinksOben"
        Me.PanLinksOben.Size = New System.Drawing.Size(57, 51)
        Me.PanLinksOben.TabIndex = 3
        '
        'PanLinksMittig
        '
        Me.PanLinksMittig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanLinksMittig.Location = New System.Drawing.Point(463, 12)
        Me.PanLinksMittig.Name = "PanLinksMittig"
        Me.PanLinksMittig.Size = New System.Drawing.Size(57, 51)
        Me.PanLinksMittig.TabIndex = 4
        '
        'PanLinksUnten
        '
        Me.PanLinksUnten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanLinksUnten.Location = New System.Drawing.Point(12, 438)
        Me.PanLinksUnten.Name = "PanLinksUnten"
        Me.PanLinksUnten.Size = New System.Drawing.Size(57, 51)
        Me.PanLinksUnten.TabIndex = 3
        '
        'tmrFarbenWechsel
        '
        Me.tmrFarbenWechsel.Enabled = True
        Me.tmrFarbenWechsel.Interval = 1500
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(707, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(599, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(2, 39)
        Me.Label2.TabIndex = 6
        '
        'tmrPunktestand
        '
        Me.tmrPunktestand.Enabled = True
        Me.tmrPunktestand.Interval = 1000
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTimer.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTimer.ForeColor = System.Drawing.Color.Red
        Me.lblTimer.Location = New System.Drawing.Point(75, 24)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(2, 26)
        Me.lblTimer.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(962, 510)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanLinksMittig)
        Me.Controls.Add(Me.PanUntenRechts)
        Me.Controls.Add(Me.PanUntenMittig)
        Me.Controls.Add(Me.PanLinksUnten)
        Me.Controls.Add(Me.PanLinksOben)
        Me.Controls.Add(Me.PanRechtsOben)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanRechtsOben As Panel
    Friend WithEvents PanUntenMittig As Panel
    Friend WithEvents PanUntenRechts As Panel
    Friend WithEvents PanLinksOben As Panel
    Friend WithEvents PanLinksMittig As Panel
    Friend WithEvents PanLinksUnten As Panel
    Friend WithEvents tmrFarbenWechsel As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tmrPunktestand As Timer
    Friend WithEvents lblTimer As Label
End Class
