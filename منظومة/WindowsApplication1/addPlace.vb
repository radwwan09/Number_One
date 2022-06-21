Imports System.Data
Imports System.Data.SqlClient
Public Class addPlace
    Public state As String = "add"
    Public id As Integer
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-RAPHNO8\SQLEXPRESS;Initial Catalog=Emp;Integrated Security=True")

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        
        Try
            Dim strQury As String = ""


            If state = "add" Then
                strQury = "INSERT INTO [dbo].[Places] ([Place_N]) VALUES ('" & txtN.Text & "')"

            Else

                strQury = " UPDATE [dbo].[Places] SET [Place_N] = '" & txtN.Text & "' WHERE Place_Id= " & id

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
            Place.fillDGV()
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtN_TextChanged(sender As Object, e As EventArgs) Handles txtN.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub addPlace_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class