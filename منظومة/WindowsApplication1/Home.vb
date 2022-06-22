Public Class Home


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub اضافةمظفToolStripMenuItem_Click(sender As Object, e As EventArgs)
        addEmp.Show()

    End Sub

    Private Sub ToolStripDropDownButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripDropDownButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub الاماكنToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Place.ShowDialog()

    End Sub

    Private Sub المؤهلاتToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Qualification.ShowDialog()
    End Sub

    

    Private Sub اضافةاجازةToolStripMenuItem_Click(sender As Object, e As EventArgs)
        holi.ShowDialog()
    End Sub

 
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Emp_P.Focus()
        Panel2.Visible = False


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Panel2.Visible = True
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Panel2.Visible = False
    End Sub

    Private Sub TabPage12_Click(sender As Object, e As EventArgs) Handles TabPage12.Click

    End Sub

    
    Private Sub TabPage16_Click(sender As Object, e As EventArgs) Handles TabPage16.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class