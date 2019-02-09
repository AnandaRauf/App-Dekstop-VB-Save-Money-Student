Public Class Main_Menu
    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Version 1.0.0")
        MessageBox.Show("Powered  By PT.Tech Media Development")
        MessageBox.Show("Developed Date: 27 January 2019")
        MessageBox.Show("Thanks For Using This Apps Desktop")
    End Sub

    Private Sub InstagramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstagramToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.instagram.com/tmd.indo")
    End Sub

    Private Sub FacebookCompanyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacebookCompanyToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.facebook.com/tmd.indo")
    End Sub

    Private Sub ReportBugToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportBugToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://api.whatsapp.com/send?phone=6283879627956&text=Hai,%20Owner%20PT.TechMediaDevelopment%20Terhormat,%20Saya%20Menemukan%20Bug%20Di%20Aplikasi%20Dekstop%20Anda%20")
    End Sub
    Private Sub QuitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        MsgBox("Are you sure quit ?", vbQuestion + vbYesNo, "Confirmation")

        Close()
    End Sub

    Private Sub InputSaveMoneyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputSaveMoneyToolStripMenuItem.Click
        InputSaveMoney.Show()
    End Sub
End Class