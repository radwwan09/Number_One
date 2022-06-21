Imports System.Data
Imports System.Data.SqlClient
Public Class addEmp

    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-RAPHNO8\SQLEXPRESS;Initial Catalog=Emp;Integrated Security=True")
    Dim cmd As New SqlCommand

    Private Sub addEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd = New SqlCommand("INSERT INTO [dbo].[Employees] ([Emp_Id],[Emp_Name],[Emp_M],[Conf_Type],[Conf_Id],[Emp_NW],[Birth_Date],[Birth_Place],[Social_Case],[Gender],[Nationa],[Address],[Phone],[Email],[Data_of_direct_action],[Data_of_original_work],[Annual_leave_balance],[Emergency_leave_balance],[Job_Id],[Fun_level_id],[Fun_Deg_id],[Cer_id],[Spec_id],[Qual_id],[Costing],[Getting_Date],[Country],[Dep_id]) VALUES (@Emp_Id,@Emp_Name,@Emp_M,@Conf_Type,@Conf_Id,@Emp_NW,@Birth_Date,@Birth_Place,@Social_Case,@Gender,@Nationa, @Address,@Phone,@Email,@Data_of_direct_action,@Data_of_original_work,@Annual_leave_balance,@Emergency_leave_balance, @Job_Id,@Fun_level_id,@Fun_Deg_id,@Cer_id,@Spec_id,@Qual_id,@Costing,@Getting_Date, @Country,@Dep_id)", con)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class