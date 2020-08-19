<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empdetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.combotype = New System.Windows.Forms.ComboBox
        Me.radioresign = New System.Windows.Forms.RadioButton
        Me.radiocurrent = New System.Windows.Forms.RadioButton
        Me.employeegrid = New System.Windows.Forms.DataGridView
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.employeegrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Tan
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-6, -1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1167, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Details"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.combotype)
        Me.GroupBox1.Controls.Add(Me.radioresign)
        Me.GroupBox1.Controls.Add(Me.radiocurrent)
        Me.GroupBox1.Location = New System.Drawing.Point(63, 76)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(278, 328)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 210)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select Designation :"
        '
        'combotype
        '
        Me.combotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combotype.FormattingEnabled = True
        Me.combotype.Items.AddRange(New Object() {"Doctor", "Nurse", "Lab Technician", "HR dept.", "Receptionist", "Accountant"})
        Me.combotype.Location = New System.Drawing.Point(21, 249)
        Me.combotype.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.combotype.Name = "combotype"
        Me.combotype.Size = New System.Drawing.Size(230, 26)
        Me.combotype.TabIndex = 2
        '
        'radioresign
        '
        Me.radioresign.AccessibleName = "m"
        Me.radioresign.AutoSize = True
        Me.radioresign.Location = New System.Drawing.Point(60, 136)
        Me.radioresign.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioresign.Name = "radioresign"
        Me.radioresign.Size = New System.Drawing.Size(88, 22)
        Me.radioresign.TabIndex = 1
        Me.radioresign.TabStop = True
        Me.radioresign.Text = "Resigned"
        Me.radioresign.UseVisualStyleBackColor = True
        '
        'radiocurrent
        '
        Me.radiocurrent.AccessibleName = "m"
        Me.radiocurrent.AutoSize = True
        Me.radiocurrent.Location = New System.Drawing.Point(60, 61)
        Me.radiocurrent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radiocurrent.Name = "radiocurrent"
        Me.radiocurrent.Size = New System.Drawing.Size(75, 22)
        Me.radiocurrent.TabIndex = 0
        Me.radiocurrent.TabStop = True
        Me.radiocurrent.Text = "Current"
        Me.radiocurrent.UseVisualStyleBackColor = True
        '
        'employeegrid
        '
        Me.employeegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.employeegrid.Location = New System.Drawing.Point(366, 89)
        Me.employeegrid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.employeegrid.Name = "employeegrid"
        Me.employeegrid.ReadOnly = True
        Me.employeegrid.Size = New System.Drawing.Size(753, 316)
        Me.employeegrid.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.ex1.My.Resources.Resources.Button_Previous_icon
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(18, 385)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 37)
        Me.Button2.TabIndex = 28
        Me.Button2.UseVisualStyleBackColor = False
        '
        'empdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 439)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.employeegrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "empdetails"
        Me.Text = "+"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.employeegrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radioresign As System.Windows.Forms.RadioButton
    Friend WithEvents radiocurrent As System.Windows.Forms.RadioButton
    Friend WithEvents employeegrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents combotype As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
