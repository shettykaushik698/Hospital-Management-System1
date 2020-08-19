<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attend
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Attend))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txteid = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txttd = New System.Windows.Forms.TextBox
        Me.txtwd = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnsave = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txttl = New System.Windows.Forms.TextBox
        Me.txtel = New System.Windows.Forms.TextBox
        Me.txtot = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtmonth = New System.Windows.Forms.TextBox
        Me.btncal = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gold
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-4, -4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(638, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Attendance"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txteid
        '
        Me.txteid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txteid.Location = New System.Drawing.Point(222, 73)
        Me.txteid.Margin = New System.Windows.Forms.Padding(4)
        Me.txteid.Name = "txteid"
        Me.txteid.Size = New System.Drawing.Size(350, 24)
        Me.txteid.TabIndex = 2
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(222, 134)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(350, 24)
        Me.txtname.TabIndex = 3
        '
        'txttd
        '
        Me.txttd.Location = New System.Drawing.Point(222, 233)
        Me.txttd.Margin = New System.Windows.Forms.Padding(4)
        Me.txttd.Name = "txttd"
        Me.txttd.ReadOnly = True
        Me.txttd.Size = New System.Drawing.Size(350, 24)
        Me.txttd.TabIndex = 5
        '
        'txtwd
        '
        Me.txtwd.Location = New System.Drawing.Point(222, 286)
        Me.txtwd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtwd.Name = "txtwd"
        Me.txtwd.Size = New System.Drawing.Size(180, 24)
        Me.txtwd.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Employee ID :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(152, 138)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 236)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total No. of days :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(55, 289)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "No. of days worked :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(148, 188)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Month :"
        '
        'btnsave
        '
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Location = New System.Drawing.Point(93, 505)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(144, 32)
        Me.btnsave.TabIndex = 14
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(357, 505)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(143, 32)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(64, 344)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 18)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Leaves per Month :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(50, 397)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 18)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Extra Leaves Taken :"
        '
        'txttl
        '
        Me.txttl.Location = New System.Drawing.Point(222, 341)
        Me.txttl.Margin = New System.Windows.Forms.Padding(4)
        Me.txttl.Name = "txttl"
        Me.txttl.ReadOnly = True
        Me.txttl.Size = New System.Drawing.Size(350, 24)
        Me.txttl.TabIndex = 20
        '
        'txtel
        '
        Me.txtel.Location = New System.Drawing.Point(222, 394)
        Me.txtel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtel.Name = "txtel"
        Me.txtel.ReadOnly = True
        Me.txtel.Size = New System.Drawing.Size(350, 24)
        Me.txtel.TabIndex = 21
        '
        'txtot
        '
        Me.txtot.Location = New System.Drawing.Point(222, 450)
        Me.txtot.Margin = New System.Windows.Forms.Padding(4)
        Me.txtot.Name = "txtot"
        Me.txtot.ReadOnly = True
        Me.txtot.Size = New System.Drawing.Size(350, 24)
        Me.txtot.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(130, 454)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 18)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Overtime :"
        '
        'txtmonth
        '
        Me.txtmonth.Location = New System.Drawing.Point(222, 184)
        Me.txtmonth.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmonth.Name = "txtmonth"
        Me.txtmonth.ReadOnly = True
        Me.txtmonth.Size = New System.Drawing.Size(350, 24)
        Me.txtmonth.TabIndex = 24
        '
        'btncal
        '
        Me.btncal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncal.Location = New System.Drawing.Point(429, 286)
        Me.btncal.Margin = New System.Windows.Forms.Padding(4)
        Me.btncal.Name = "btncal"
        Me.btncal.Size = New System.Drawing.Size(145, 32)
        Me.btncal.TabIndex = 26
        Me.btncal.Text = "Calculate"
        Me.btncal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncal.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.Transparent
        Me.btncancel.BackgroundImage = CType(resources.GetObject("btncancel.BackgroundImage"), System.Drawing.Image)
        Me.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancel.FlatAppearance.BorderSize = 0
        Me.btncancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Location = New System.Drawing.Point(18, 60)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(39, 42)
        Me.btncancel.TabIndex = 25
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'Attend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 568)
        Me.Controls.Add(Me.btncal)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.txtmonth)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtot)
        Me.Controls.Add(Me.txtel)
        Me.Controls.Add(Me.txttl)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtwd)
        Me.Controls.Add(Me.txttd)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txteid)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Attend"
        Me.Text = "Attend"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txteid As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txttd As System.Windows.Forms.TextBox
    Friend WithEvents txtwd As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txttl As System.Windows.Forms.TextBox
    Friend WithEvents txtel As System.Windows.Forms.TextBox
    Friend WithEvents txtot As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtmonth As System.Windows.Forms.TextBox
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btncal As System.Windows.Forms.Button
End Class
