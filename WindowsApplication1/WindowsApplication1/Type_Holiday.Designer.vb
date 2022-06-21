<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Type_Holiday
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvQl = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvQl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(199, 453)
        Me.Button2.Margin = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 40)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "تعديل"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(65, 453)
        Me.Button1.Margin = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 40)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "اضافة"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvQl
        '
        Me.dgvQl.AllowUserToAddRows = False
        Me.dgvQl.AllowUserToDeleteRows = False
        Me.dgvQl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgvQl.Location = New System.Drawing.Point(37, 19)
        Me.dgvQl.Margin = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.dgvQl.Name = "dgvQl"
        Me.dgvQl.ReadOnly = True
        Me.dgvQl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgvQl.RowHeadersVisible = False
        Me.dgvQl.Size = New System.Drawing.Size(303, 423)
        Me.dgvQl.TabIndex = 9
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "H_Id"
        Me.Column1.FillWeight = 150.0!
        Me.Column1.HeaderText = "رقم الاجازة"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "H_type"
        Me.Column2.HeaderText = "نوع الاجازة"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Type_Holiday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 497)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvQl)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Type_Holiday"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "انواع الاجازات"
        CType(Me.dgvQl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvQl As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
