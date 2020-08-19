<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scan))
        Me.lblscan = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtid = New System.Windows.Forms.TextBox
        Me.combotype = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbltype = New System.Windows.Forms.Label
        Me.btncancel = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtname = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtcharge = New System.Windows.Forms.TextBox
        Me.btnrefresh = New System.Windows.Forms.Button
        Me.lbldate = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.scangrid = New System.Windows.Forms.DataGridView
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnnew = New System.Windows.Forms.Button
        Me.btnapt = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.lblslno = New System.Windows.Forms.Label
        Me.txtscan = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.scangrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblscan
        '
        Me.lblscan.BackColor = System.Drawing.Color.Gold
        Me.lblscan.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscan.Location = New System.Drawing.Point(-3, -1)
        Me.lblscan.Name = "lblscan"
        Me.lblscan.Size = New System.Drawing.Size(1044, 39)
        Me.lblscan.TabIndex = 0
        Me.lblscan.Text = "Scan Appointment"
        Me.lblscan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Scan Name :"
        '
        'txtid
        '
        Me.txtid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtid.Location = New System.Drawing.Point(101, 179)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(203, 21)
        Me.txtid.TabIndex = 3
        '
        'combotype
        '
        Me.combotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combotype.FormattingEnabled = True
        Me.combotype.Items.AddRange(New Object() {"OUT-PATIENT", "IN-PATIENT"})
        Me.combotype.Location = New System.Drawing.Point(101, 120)
        Me.combotype.Name = "combotype"
        Me.combotype.Size = New System.Drawing.Size(203, 23)
        Me.combotype.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Patient Type :"
        '
        'lbltype
        '
        Me.lbltype.AutoSize = True
        Me.lbltype.Location = New System.Drawing.Point(40, 182)
        Me.lbltype.Name = "lbltype"
        Me.lbltype.Size = New System.Drawing.Size(26, 15)
        Me.lbltype.TabIndex = 6
        Me.lbltype.Text = "No."
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
        Me.btncancel.Location = New System.Drawing.Point(13, 48)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(31, 32)
        Me.btncancel.TabIndex = 26
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 15)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Name :"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(101, 238)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(203, 21)
        Me.txtname.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 365)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 15)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Charge :"
        '
        'txtcharge
        '
        Me.txtcharge.Location = New System.Drawing.Point(101, 361)
        Me.txtcharge.Name = "txtcharge"
        Me.txtcharge.ReadOnly = True
        Me.txtcharge.Size = New System.Drawing.Size(203, 21)
        Me.txtcharge.TabIndex = 30
        '
        'btnrefresh
        '
        Me.btnrefresh.BackgroundImage = CType(resources.GetObject("btnrefresh.BackgroundImage"), System.Drawing.Image)
        Me.btnrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnrefresh.FlatAppearance.BorderSize = 0
        Me.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrefresh.Location = New System.Drawing.Point(572, 62)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(35, 32)
        Me.btnrefresh.TabIndex = 31
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Location = New System.Drawing.Point(341, 66)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(19, 15)
        Me.lbldate.TabIndex = 32
        Me.lbldate.Text = "---"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(292, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 15)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Date :"
        '
        'scangrid
        '
        Me.scangrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.scangrid.Location = New System.Drawing.Point(344, 120)
        Me.scangrid.Name = "scangrid"
        Me.scangrid.Size = New System.Drawing.Size(668, 366)
        Me.scangrid.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(506, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 15)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Refresh :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(873, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 15)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Ready"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(790, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 15)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Attended"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(715, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 15)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Pending"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(876, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 15)
        Me.Label8.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Green
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(797, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 15)
        Me.Label10.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Red
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(719, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 15)
        Me.Label13.TabIndex = 38
        '
        'btnnew
        '
        Me.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnew.Location = New System.Drawing.Point(56, 433)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(87, 27)
        Me.btnnew.TabIndex = 44
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnapt
        '
        Me.btnapt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnapt.Location = New System.Drawing.Point(206, 433)
        Me.btnapt.Name = "btnapt"
        Me.btnapt.Size = New System.Drawing.Size(87, 27)
        Me.btnapt.TabIndex = 45
        Me.btnapt.Text = "Appoint"
        Me.btnapt.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(90, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 15)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "SL No. :"
        '
        'lblslno
        '
        Me.lblslno.AutoSize = True
        Me.lblslno.Location = New System.Drawing.Point(150, 66)
        Me.lblslno.Name = "lblslno"
        Me.lblslno.Size = New System.Drawing.Size(19, 15)
        Me.lblslno.TabIndex = 47
        Me.lblslno.Text = "---"
        '
        'txtscan
        '
        Me.txtscan.Location = New System.Drawing.Point(101, 300)
        Me.txtscan.Name = "txtscan"
        Me.txtscan.ReadOnly = True
        Me.txtscan.Size = New System.Drawing.Size(203, 21)
        Me.txtscan.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(-10, 515)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1069, 27)
        Me.Label1.TabIndex = 49
        '
        'scan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 534)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtscan)
        Me.Controls.Add(Me.lblslno)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnapt)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.scangrid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.txtcharge)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.lbltype)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.combotype)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblscan)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "scan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "scan"
        CType(Me.scangrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblscan As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents combotype As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbltype As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcharge As System.Windows.Forms.TextBox
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents scangrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnapt As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblslno As System.Windows.Forms.Label
    Friend WithEvents txtscan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
