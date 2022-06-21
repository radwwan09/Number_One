Imports System.Net
Imports System.Net.Mail
Imports System.Data.SqlClient
Public Class SendCode
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-RAPHNO8\SQLEXPRESS;Initial Catalog=Emp;Integrated Security=True")

    Public Shared toUser As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As SqlCommand = New SqlCommand("select * from Users where User_Name ='" + txtUser.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        Dim from, pass, messageBody As String


        Dim message As MailMessage = New MailMessage()
        toUser = dt(0)(3)
        from = "muhammadadelmuhammadwali@gmail.com"
        pass = "jrxljonrbnpllmii"

        messageBody = "كلمة المرور الخاصة بك هي " + dt(0)(1)
        message.To.Add(toUser)
        message.From = New MailAddress(from)
        message.Body = messageBody
        message.Subject = "رمز إعادة تعيين كلمة المرور"
        Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com")
        smtp.EnableSsl = True
        smtp.Port = 587
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network
        smtp.Credentials = New NetworkCredential(from, pass)
        Try
            smtp.Send(message)
            MessageBox.Show("يرجى التحقق من بريدك الإلكتروني  ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class