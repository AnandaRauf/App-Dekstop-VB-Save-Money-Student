Imports System.Data
Imports System.Data.SqlClient
Public Class InputSaveMoney
    Private Sub InputSaveMoney_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ShowSaveMoney()
        'TODO: This line of code loads data into the 'Db_bank_schoollDataSet.tbl_SaveMoney' table. You can move, or remove it, as needed.
        Me.Tbl_SaveMoneyTableAdapter.Fill(Me.Db_bank_schoollDataSet.tbl_SaveMoney)

    End Sub

    Private Sub SaveMoneyBut_Click(sender As Object, e As EventArgs) Handles SaveMoneyBut.Click
        If NamStu.Text = "" Or Classroom.Text = "" Or DateSaveMoneyTime.Text = "" Or StatusSave.Text = "" Then
            MsgBox("Your Data Empty !", MsgBoxStyle.Critical, "Data Empty")
            NamStu.Focus()
        Else
            MessageBox.Show("Save Data Succesfull")
        End If
        Dim cons As New SqlConnection
        Dim cmd As New SqlCommand
        Try
            cons.ConnectionString = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SMARTSYARI'AH\Documents\Visual Studio 2015\Projects\App Desktop Save Money Student\App Desktop Save Money Student\db_bank_schooll.mdf;Integrated Security=True;Connect Timeout=30")
            cons.Open()
            cmd.Connection = cons
            cmd.CommandText = "Insert into tbl_SaveMoney([Name_Student], [Class_Student],[Save_Money], [Date_SaveMoney], [Status]) VALUES('" & NamStu.Text & "','" & Classroom.Text & "','" & SaveMoney.Text & "','" & DateSaveMoneyTime.Text & "','" & StatusSave.Text & "')"
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            cons.Close()
        End Try
    End Sub
    Sub ShowSaveMoney()
        Try
            Call konekdatabase()
            Dim da = New SqlDataAdapter("Select * From tbl_SaveMoney", koneksiSQL)
            Dim ds = New DataSet
            da.Fill(ds, "tbl_SaveMoney")
            SaveMoneyView.DataSource = ds.Tables("tbl_SaveMoney")

        Catch ex As Exception
        End Try
    End Sub
    Private Sub DelBut_Click(sender As Object, e As EventArgs) Handles DelBut.Click
        Call konekdatabase()
        Dim SQLCmd As New SqlCommand
        Dim DR As SqlDataReader
        SQLCmd = New SqlCommand("Delete * From tbl_SaveMoney where  Name_Student='" & NamStu.Text & "'  Class_Student='" & Classroom.Text & "' Save_Money='" & SaveMoney.Text & "' Date_SaveMoney='" & DateSaveMoneyTime.Text & "' Status='" & StatusSave.Text & "'", koneksiSQL)

        DR = SQLCmd.ExecuteReader

        If DR.Read Then

            NamStu.Focus()
            Classroom.Focus()
            SaveMoney.Focus()
            DateSaveMoneyTime.Focus()
            StatusSave.Focus()
            MsgBox("Deleted Succesfull !")
            Main_Menu.Show()
            Me.Hide()

        Else
            MsgBox("Sorry Deleted Has Been Failed ! Wrong Table & Column !")

            NamStu.Clear()
            Classroom.Clear()
            SaveMoney.Clear()
            StatusSave.Clear()
            NamStu.Focus()
        End If
    End Sub
    Private Sub QuitBut_Click(sender As Object, e As EventArgs) Handles QuitBut.Click
        MsgBox("Are you sure quit ?", vbQuestion + vbYesNo, "Confirmation")

        Close()
    End Sub
End Class