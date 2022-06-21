Imports System.Data
Imports System.Data.SqlClient

Public Class Qualification
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-RAPHNO8\SQLEXPRESS;Initial Catalog=Emp;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim ad As SqlDataAdapter
    Dim dtPl As New DataTable

    Sub fillDGV()
        dtPl.Rows.Clear()
        dgvQl.Columns(0).Width = 150
        dgvQl.Columns(1).Width = 150
        ad = New SqlDataAdapter("select * from Qualifications", con)
        ad.Fill(dtPl)
        dgvQl.DataSource = dtPl


    End Sub
    Private Sub Qualification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        fillDGV()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmp As New addQual
        frmp.state = "add"
        frmp.btnEnter.Text = "اضافة"
        frmp.ShowDialog()
        frmp.ShowDialog()
        fillDGV()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frmp As New addPlace
        frmp.state = "edit"
        frmp.id = dgvQl.CurrentRow.Cells(0).Value
        frmp.txtN.Text = dgvQl.CurrentRow.Cells(1).Value
        frmp.btnEnter.Text = "تعديل"
        frmp.ShowDialog()
        fillDGV()
    End Sub
End Class