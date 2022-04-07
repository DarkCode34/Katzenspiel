Imports System
Imports System.Runtime.InteropServices
Imports System.IO

Public Class Form1

    Dim MausImage As Image = My.Resources.maus
    Dim WeißImage As Image = My.Resources.weiss

    Dim SekundenCounter_PanLinskOben As Integer = 0
    Dim SekundenCounter_PanLinksMittig As Integer = 0
    Dim SekundenCounter_PanLinksUnten As Integer = 0
    Dim SekundenCounter_PanRechtsOben As Integer = 0
    Dim SekundenCounter_PanUntenRechts As Integer = 0
    Dim SekundenCounter_PanUntenMittig As Integer = 0

    Public Punktestand As Integer = 0
    Dim Timer As Integer = 0


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Cursor = New Cursor(My.Resources.katze1ico.Handle)  'so einfach und doch so schwer. Muss noch angepasst werden! derzeit negativ + viel zu groß
        Me.BackgroundImage = My.Resources.hintergrund


    End Sub

    Private Sub tmrFarbenWechsel_Tick(sender As Object, e As EventArgs) Handles tmrFarbenWechsel.Tick

        Dim Random As Integer = (Int((6 * Rnd()) + 1))
        Select Case Random
            Case 1
                PanLinksOben.BackgroundImage = MausImage
                PanLinksOben.BackgroundImageLayout = ImageLayout.Stretch
                SekundenCounter_PanLinskOben += 1
                If SekundenCounter_PanLinskOben > 1 Then  'da ich nicht weiß wie häufig der Case aufgerufen wird, weiß auch auch nie wies mit den SekundenCounter aussieht!
                    PanLinksOben.BackgroundImage = WeißImage
                    SekundenCounter_PanLinskOben = 0
                End If
            Case 2
                PanLinksMittig.BackgroundImage = MausImage
                PanLinksMittig.BackgroundImageLayout = ImageLayout.Stretch
                SekundenCounter_PanLinksMittig += 1
                If SekundenCounter_PanLinksMittig > 1 Then
                    PanLinksMittig.BackgroundImage = WeißImage
                    SekundenCounter_PanLinksMittig = 0
                End If
            Case 3
                PanLinksUnten.BackgroundImage = MausImage
                PanLinksUnten.BackgroundImageLayout = ImageLayout.Stretch
                SekundenCounter_PanLinksUnten += 1
                If SekundenCounter_PanLinksUnten > 1 Then
                    PanLinksUnten.BackgroundImage = WeißImage
                    SekundenCounter_PanLinksUnten = 0
                End If
            Case 4
                PanRechtsOben.BackgroundImage = MausImage
                PanRechtsOben.BackgroundImageLayout = ImageLayout.Stretch
                SekundenCounter_PanRechtsOben += 1
                If SekundenCounter_PanRechtsOben > 1 Then
                    PanRechtsOben.BackgroundImage = WeißImage
                    SekundenCounter_PanRechtsOben = 0
                End If
            Case 5
                PanUntenRechts.BackgroundImage = MausImage
                PanUntenRechts.BackgroundImageLayout = ImageLayout.Stretch
                SekundenCounter_PanUntenRechts += 1
                If SekundenCounter_PanUntenRechts > 1 Then
                    PanUntenRechts.BackgroundImage = WeißImage
                    SekundenCounter_PanUntenRechts = 0
                End If
            Case 6
                PanUntenMittig.BackgroundImage = MausImage
                PanUntenMittig.BackgroundImageLayout = ImageLayout.Stretch
                SekundenCounter_PanUntenMittig += 1
                If SekundenCounter_PanUntenMittig > 1 Then
                    PanUntenMittig.BackgroundImage = WeißImage
                    SekundenCounter_PanUntenMittig = 0
                End If
        End Select
    End Sub

    Private Sub tmrPunktestand_Tick(sender As Object, e As EventArgs) Handles tmrPunktestand.Tick

        Timer += 1
        lblTimer.Text = "Verbleibende Zeit in Sekunden: " & Timer

        If Timer >= 60 Then
            Form2.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub PanLinksMittig_Click(sender As Object, e As EventArgs) Handles PanLinksMittig.Click, PanUntenRechts.Click, PanUntenMittig.Click, PanRechtsOben.Click, PanLinksUnten.Click, PanLinksOben.Click

        If PanLinksMittig.BackgroundImage Is MausImage Then
            Punktestand += 1
            Label2.Text = "Dein Punktestand: " & Punktestand
            PanLinksMittig.BackgroundImage = WeißImage
        ElseIf PanLinksOben.BackgroundImage Is MausImage Then
            Punktestand += 1
            Label2.Text = "Dein Punktestand: " & Punktestand
            PanLinksOben.BackgroundImage = WeißImage
        ElseIf PanLinksUnten.BackgroundImage Is MausImage Then
            Punktestand += 1
            Label2.Text = "Dein Punktestand: " & Punktestand
            PanLinksUnten.BackgroundImage = WeißImage
        ElseIf PanRechtsOben.BackgroundImage Is MausImage Then
            Punktestand += 1
            Label2.Text = "Dein Punktestand: " & Punktestand
            PanRechtsOben.BackgroundImage = WeißImage
        ElseIf PanUntenRechts.BackgroundImage Is MausImage Then
            Punktestand += 1
            Label2.Text = "Dein Punktestand: " & Punktestand
            PanUntenRechts.BackgroundImage = WeißImage
        ElseIf PanUntenMittig.BackgroundImage Is MausImage Then
            Punktestand += 1
            Label2.Text = "Dein Punktestand: " & Punktestand
            PanUntenMittig.BackgroundImage = WeißImage
        Else
            Label2.Text = "Dein Punktestand: " & Punktestand
        End If
    End Sub
End Class
