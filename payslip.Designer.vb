<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payslip
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbldate = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.empid = New System.Windows.Forms.TextBox
        Me.empname = New System.Windows.Forms.TextBox
        Me.empbasic = New System.Windows.Forms.TextBox
        Me.empdesign = New System.Windows.Forms.TextBox
        Me.empnet = New System.Windows.Forms.TextBox
        Me.btnprint = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-8, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(565, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PaySlip"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(282, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Net Salary :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(287, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(287, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Basic pay :"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Location = New System.Drawing.Point(347, 49)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(16, 13)
        Me.lbldate.TabIndex = 6
        Me.lbldate.Text = "---"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Designation :"
        '
        'empid
        '
        Me.empid.Location = New System.Drawing.Point(92, 46)
        Me.empid.Name = "empid"
        Me.empid.Size = New System.Drawing.Size(160, 20)
        Me.empid.TabIndex = 8
        '
        'empname
        '
        Me.empname.Location = New System.Drawing.Point(92, 83)
        Me.empname.Name = "empname"
        Me.empname.ReadOnly = True
        Me.empname.Size = New System.Drawing.Size(160, 20)
        Me.empname.TabIndex = 9
        '
        'empbasic
        '
        Me.empbasic.Location = New System.Drawing.Point(350, 83)
        Me.empbasic.Name = "empbasic"
        Me.empbasic.ReadOnly = True
        Me.empbasic.Size = New System.Drawing.Size(164, 20)
        Me.empbasic.TabIndex = 10
        '
        'empdesign
        '
        Me.empdesign.Location = New System.Drawing.Point(92, 116)
        Me.empdesign.Name = "empdesign"
        Me.empdesign.ReadOnly = True
        Me.empdesign.Size = New System.Drawing.Size(160, 20)
        Me.empdesign.TabIndex = 11
        '
        'empnet
        '
        Me.empnet.Location = New System.Drawing.Point(350, 116)
        Me.empnet.Name = "empnet"
        Me.empnet.ReadOnly = True
        Me.empnet.Size = New System.Drawing.Size(164, 20)
        Me.empnet.TabIndex = 12
        '
        'btnprint
        '
        Me.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprint.Location = New System.Drawing.Point(193, 160)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(139, 23)
        Me.btnprint.TabIndex = 13
        Me.btnprint.Text = "Print Pay Slip"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.ex1.My.Resources.Resources.Button_Previous_icon
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(21, 156)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(30, 27)
        Me.Button3.TabIndex = 82
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Crimson
        Me.Label9.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(-7, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(559, 23)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Enter the Employee ID"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'payslip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 229)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.empnet)
        Me.Controls.Add(Me.empdesign)
        Me.Controls.Add(Me.empbasic)
        Me.Controls.Add(Me.empname)
        Me.Controls.Add(Me.empid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "payslip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "payslip"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents empid As System.Windows.Forms.TextBox
    Friend WithEvents empname As System.Windows.Forms.TextBox
    Friend WithEvents empbasic As System.Windows.Forms.TextBox
    Friend WithEvents empdesign As System.Windows.Forms.TextBox
    Friend WithEvents empnet As System.Windows.Forms.TextBox
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
