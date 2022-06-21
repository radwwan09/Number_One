Imports System.Data.SqlClient
Public Class add_T_Holiday
    Public state As String = "add"
    Public id As Integer
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-RAPHNO8\SQLEXPRESS;Initial Catalog=Emp;Integrated Security=True")

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Try
            Dim strQury As String = ""


            If state = "add" Then
                strQury = "INSERT INTO [dbo].[Type_Holiday] ([H_type]) VALUES ('" & txtN.Text & "')"

            Else

                strQury = " UPDATE [dbo].[Type_Holiday] SET [H_type] = '" & txtN.Text & "' WHERE H_Id= " & id

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

    Private Sub add_T_Holiday_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class