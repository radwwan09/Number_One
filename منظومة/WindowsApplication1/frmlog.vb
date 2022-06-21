Imports System.Data
Imports System.Data.SqlClient
Public Class frmlog
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-RAPHNO8\SQLEXPRESS;Initial Catalog=Emp;Integrated Security=True")



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim cmd As SqlCommand = New SqlCommand("select * from Users where User_Name ='" + txtUser.Text + "' and User_pass ='" + txtPass.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
         

            Home.Show()
            Me.Hide()

            

        Else
            MessageBox.Show("هناك خطأ ")
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim sc As SendCode = New SendCode()
        sc.Show()
    End Sub
End Class
