<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dischargesummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dischargesummary))
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtdod = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtdoa = New System.Windows.Forms.TextBox
        Me.txtsex = New System.Windows.Forms.TextBox
        Me.txtadd = New System.Windows.Forms.TextBox
        Me.txtage = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtopid = New System.Windows.Forms.TextBox
        Me.txtipid = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblslno = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtdoc = New System.Windows.Forms.TextBox
        Me.txtdiet = New System.Windows.Forms.TextBox
        Me.txtadvice = New System.Windows.Forms.TextBox
        Me.txtdrug = New System.Windows.Forms.TextBox
        Me.txtph = New System.Windows.Forms.TextBox
        Me.txtcr = New System.Windows.Forms.TextBox
        Me.txtfd = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnedit = New System.Windows.Forms.Button
        Me.View = New System.Windows.Forms.Button
        Me.btnnew = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnsearch = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.MediumBlue
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-3, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1266, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Discharge Summary"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtdod)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtdoa)
        Me.GroupBox1.Controls.Add(Me.txtsex)
        Me.GroupBox1.Controls.Add(Me.txtadd)
        Me.GroupBox1.Controls.Add(Me.txtage)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txtopid)
        Me.GroupBox1.Controls.Add(Me.txtipid)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblslno)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(514, 368)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Details"
        '
        'txtdod
        '
        Me.txtdod.Location = New System.Drawing.Point(142, 322)
        Me.txtdod.Multiline = True
        Me.txtdod.Name = "txtdod"
        Me.txtdod.ReadOnly = True
        Me.txtdod.Size = New System.Drawing.Size(308, 24)
        Me.txtdod.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 325)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Date of discharge :"
        '
        'txtdoa
        '
        Me.txtdoa.Location = New System.Drawing.Point(142, 293)
        Me.txtdoa.Name = "txtdoa"
        Me.txtdoa.ReadOnly = True
        Me.txtdoa.Size = New System.Drawing.Size(308, 20)
        Me.txtdoa.TabIndex = 15
        '
        'txtsex
        '
        Me.txtsex.Location = New System.Drawing.Point(142, 257)
        Me.txtsex.Name = "txtsex"
        Me.txtsex.ReadOnly = True
        Me.txtsex.Size = New System.Drawing.Size(308, 20)
        Me.txtsex.TabIndex = 14
        '
        'txtadd
        '
        Me.txtadd.Location = New System.Drawing.Point(142, 199)
        Me.txtadd.Multiline = True
        Me.txtadd.Name = "txtadd"
        Me.txtadd.ReadOnly = True
        Me.txtadd.Size = New System.Drawing.Size(308, 46)
        Me.txtadd.TabIndex = 13
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(142, 169)
        Me.txtage.Name = "txtage"
        Me.txtage.ReadOnly = True
        Me.txtage.Size = New System.Drawing.Size(308, 20)
        Me.txtage.TabIndex = 12
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(142, 134)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(308, 20)
        Me.txtname.TabIndex = 11
        '
        'txtopid
        '
        Me.txtopid.Location = New System.Drawing.Point(142, 98)
        Me.txtopid.Name = "txtopid"
        Me.txtopid.ReadOnly = True
        Me.txtopid.Size = New System.Drawing.Size(308, 20)
        Me.txtopid.TabIndex = 10
        '
        'txtipid
        '
        Me.txtipid.Location = New System.Drawing.Point(142, 62)
        Me.txtipid.Name = "txtipid"
        Me.txtipid.Size = New System.Drawing.Size(308, 20)
        Me.txtipid.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 295)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Date of addmission :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(98, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Sex :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(73, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Address :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(96, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Age :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Patient Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "OP Number :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "IP Number :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "SLNO :"
        '
        'lblslno
        '
        Me.lblslno.AutoSize = True
        Me.lblslno.Location = New System.Drawing.Point(148, 26)
        Me.lblslno.Name = "lblslno"
        Me.lblslno.Size = New System.Drawing.Size(23, 13)
        Me.lblslno.TabIndex = 0
        Me.lblslno.Text = "----"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtdoc)
        Me.GroupBox2.Controls.Add(Me.txtdiet)
        Me.GroupBox2.Controls.Add(Me.txtadvice)
        Me.GroupBox2.Controls.Add(Me.txtdrug)
        Me.GroupBox2.Controls.Add(Me.txtph)
        Me.GroupBox2.Controls.Add(Me.txtcr)
        Me.GroupBox2.Controls.Add(Me.txtfd)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(535, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(714, 328)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Discharge Details"
        '
        'txtdoc
        '
        Me.txtdoc.Location = New System.Drawing.Point(206, 295)
        Me.txtdoc.Name = "txtdoc"
        Me.txtdoc.ReadOnly = True
        Me.txtdoc.Size = New System.Drawing.Size(472, 20)
        Me.txtdoc.TabIndex = 13
        '
        'txtdiet
        '
        Me.txtdiet.Location = New System.Drawing.Point(206, 241)
        Me.txtdiet.Multiline = True
        Me.txtdiet.Name = "txtdiet"
        Me.txtdiet.Size = New System.Drawing.Size(472, 37)
        Me.txtdiet.TabIndex = 12
        '
        'txtadvice
        '
        Me.txtadvice.Location = New System.Drawing.Point(206, 199)
        Me.txtadvice.Multiline = True
        Me.txtadvice.Name = "txtadvice"
        Me.txtadvice.Size = New System.Drawing.Size(472, 33)
        Me.txtadvice.TabIndex = 11
        '
        'txtdrug
        '
        Me.txtdrug.Location = New System.Drawing.Point(206, 165)
        Me.txtdrug.Name = "txtdrug"
        Me.txtdrug.Size = New System.Drawing.Size(472, 20)
        Me.txtdrug.TabIndex = 10
        '
        'txtph
        '
        Me.txtph.Location = New System.Drawing.Point(206, 108)
        Me.txtph.Multiline = True
        Me.txtph.Name = "txtph"
        Me.txtph.Size = New System.Drawing.Size(472, 39)
        Me.txtph.TabIndex = 9
        '
        'txtcr
        '
        Me.txtcr.Location = New System.Drawing.Point(206, 79)
        Me.txtcr.Name = "txtcr"
        Me.txtcr.Size = New System.Drawing.Size(472, 20)
        Me.txtcr.TabIndex = 8
        '
        'txtfd
        '
        Me.txtfd.Location = New System.Drawing.Point(206, 23)
        Me.txtfd.Multiline = True
        Me.txtfd.Name = "txtfd"
        Me.txtfd.Size = New System.Drawing.Size(472, 43)
        Me.txtfd.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(146, 295)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 13)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Doctor :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(108, 243)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Dietry Advice :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(24, 202)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(179, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Further Advice On Discharge :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(30, 165)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(172, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Drugs Advice On Discharge :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(118, 111)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Past History :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(49, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(153, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Complaints on Reporting :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(101, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Final Diagnosis :"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Location = New System.Drawing.Point(758, 374)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(87, 23)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "Save "
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Location = New System.Drawing.Point(876, 374)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(87, 23)
        Me.btnedit.TabIndex = 4
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'View
        '
        Me.View.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.View.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.View.Location = New System.Drawing.Point(1123, 374)
        Me.View.Name = "View"
        Me.View.Size = New System.Drawing.Size(87, 23)
        Me.View.TabIndex = 5
        Me.View.Text = "Print"
        Me.View.UseVisualStyleBackColor = False
        '
        'btnnew
        '
        Me.btnnew.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnew.Location = New System.Drawing.Point(638, 374)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(87, 23)
        Me.btnnew.TabIndex = 6
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = False
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
        Me.btncancel.Location = New System.Drawing.Point(562, 374)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(30, 29)
        Me.btncancel.TabIndex = 28
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearch.Location = New System.Drawing.Point(1004, 374)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(87, 23)
        Me.btnsearch.TabIndex = 29
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(-1, 419)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1280, 11)
        Me.Label2.TabIndex = 30
        '
        'dischargesummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1261, 430)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.View)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dischargesummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "`"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdoa As System.Windows.Forms.TextBox
    Friend WithEvents txtsex As System.Windows.Forms.TextBox
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtopid As System.Windows.Forms.TextBox
    Friend WithEvents txtipid As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblslno As System.Windows.Forms.Label
    Friend WithEvents txtdod As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtdoc As System.Windows.Forms.TextBox
    Friend WithEvents txtdiet As System.Windows.Forms.TextBox
    Friend WithEvents txtadvice As System.Windows.Forms.TextBox
    Friend WithEvents txtdrug As System.Windows.Forms.TextBox
    Friend WithEvents txtph As System.Windows.Forms.TextBox
    Friend WithEvents txtcr As System.Windows.Forms.TextBox
    Friend WithEvents txtfd As System.Windows.Forms.TextBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents View As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
