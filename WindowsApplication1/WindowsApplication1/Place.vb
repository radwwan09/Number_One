Imports System.Data
Imports System.Data.SqlClient


Public Class Place
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-RAPHNO8\SQLEXPRESS;Initial Catalog=Emp;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim ad As SqlDataAdapter
    Dim dtPl As New DataTable

    Sub fillDGV()
        dtPl.Rows.Clear()
        dgvPl.Columns(0).Width = 150
        dgvPl.Columns(1).Width = 150
        ad = New SqlDataAdapter("select * from Places", con)
        ad.Fill(dtPl)
        dgvPl.DataSource = dtPl


    End Sub


    Private Sub Place_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        fillDGV()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmp As New addPlace
        frmp.state = "add"
        frmp.btnEnter.Text = "اضافة"
        frmp.ShowDialog()
        fillDGV()
    End Sub

    Private Sub dgvPl_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPl.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frmp As New addPlace
        frmp.state = "edit"
        frmp.id = dgvPl.CurrentRow.Cells(0).Value
        frmp.txtN.Text = dgvPl.CurrentRow.Cells(1).Value
        frmp.btnEnter.Text = "تعديل"
        frmp.ShowDialog()
        fillDGV()
    End Sub
End Class