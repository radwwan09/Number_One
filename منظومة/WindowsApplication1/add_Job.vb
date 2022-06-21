Imports System.Data.SqlClient
Public Class add_Job
    Public state As String = "add"
    Public id As Integer
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-RAPHNO8\SQLEXPRESS;Initial Catalog=Emp;Integrated Security=True")

    Private Sub add_Job_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Try
            Dim strQury As String = ""


            If state = "add" Then
                strQury = "INSERT INTO [dbo].[Job] ([Job_N]) VALUES ('" & txtN.Text & "')"

            Else

                strQury = " UPDATE [dbo].[Job] SET [Job_N] = '" & txtN.Text & "' WHERE Job_Id= " & id

            End If
            Dim cmd As New SqlCommand(strQury, con)
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("تمت العمليه بنجاح", MsgBoxStyle.Information, "ادارة المنظومة")

        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            con.Close()
            Me.Close()

        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class