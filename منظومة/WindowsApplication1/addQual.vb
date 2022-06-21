Imports System.Data
Imports System.Data.SqlClient
Public Class addQual
    Public state As String = "add"
    Public id As Integer
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-RAPHNO8\SQLEXPRESS;Initial Catalog=Emp;Integrated Security=True")

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Try
            Dim strQury As String = ""


            If state = "add" Then
                strQury = "INSERT INTO [dbo].[Qualifications] ([Qual_name]) VALUES ('" & txtN.Text & "')"

            Else

                strQury = " UPDATE [dbo].[Qualifications] SET [Qual_name] = '" & txtN.Text & "' WHERE Qual_Id= " & id

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
            Qualification.fillDGV()
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class