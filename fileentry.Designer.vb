<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fileentry
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
        Me.Combodept = New System.Windows.Forms.ComboBox
        Me.combodoc = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnapnt = New System.Windows.Forms.Button
        Me.comboopno = New System.Windows.Forms.ComboBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtpname = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.datec = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtdcharge = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblslno = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Peru
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-8, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(920, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "File Entry"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Combodept
        '
        Me.Combodept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combodept.FormattingEnabled = True
        Me.Combodept.Items.AddRange(New Object() {"Cardiology", "Dentist", "E.N.T", "Emergency", "Endocrinology", "Gyneocologist", "Medical oncology", "Medicine", "Nephrology", "Neuro", "Ortho", "Pediatrics", "Surgery", "Surgery oncology", "Urology"})
        Me.Combodept.Location = New System.Drawing.Point(146, 191)
        Me.Combodept.Margin = New System.Windows.Forms.Padding(4)
        Me.Combodept.Name = "Combodept"
        Me.Combodept.Size = New System.Drawing.Size(240, 26)
        Me.Combodept.TabIndex = 1
        '
        'combodoc
        '
        Me.combodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combodoc.FormattingEnabled = True
        Me.combodoc.Location = New System.Drawing.Point(604, 187)
        Me.combodoc.Margin = New System.Windows.Forms.Padding(4)
        Me.combodoc.Name = "combodoc"
        Me.combodoc.Size = New System.Drawing.Size(240, 26)
        Me.combodoc.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 129)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "OP ID :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 191)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Department :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(507, 191)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Doctor ID :"
        '
        'btnapnt
        '
        Me.btnapnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnapnt.Location = New System.Drawing.Point(578, 347)
        Me.btnapnt.Margin = New System.Windows.Forms.Padding(4)
        Me.btnapnt.Name = "btnapnt"
        Me.btnapnt.Size = New System.Drawing.Size(201, 32)
        Me.btnapnt.TabIndex = 8
        Me.btnapnt.Text = "Appoint"
        Me.btnapnt.UseVisualStyleBackColor = True
        '
        'comboopno
        '
        Me.comboopno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboopno.FormattingEnabled = True
        Me.comboopno.Location = New System.Drawing.Point(146, 125)
        Me.comboopno.Margin = New System.Windows.Forms.Padding(4)
        Me.comboopno.Name = "comboopno"
        Me.comboopno.Size = New System.Drawing.Size(240, 26)
        Me.comboopno.TabIndex = 10
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(146, 262)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(240, 24)
        Me.txtname.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 266)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Doctor Name :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(480, 129)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Patient Name :"
        '
        'txtpname
        '
        Me.txtpname.Location = New System.Drawing.Point(604, 125)
        Me.txtpname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.ReadOnly = True
        Me.txtpname.Size = New System.Drawing.Size(240, 24)
        Me.txtpname.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(600, 71)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Date :"
        '
        'datec
        '
        Me.datec.AutoSize = True
        Me.datec.Location = New System.Drawing.Point(663, 71)
        Me.datec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.datec.Name = "datec"
        Me.datec.Size = New System.Drawing.Size(76, 18)
        Me.datec.TabIndex = 16
        Me.datec.Text = "----:----:----"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.ex1.My.Resources.Resources.Button_Previous_icon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(18, 61)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 37)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(435, 262)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 18)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Consultation charge :"
        '
        'txtdcharge
        '
        Me.txtdcharge.Location = New System.Drawing.Point(604, 256)
        Me.txtdcharge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdcharge.Name = "txtdcharge"
        Me.txtdcharge.ReadOnly = True
        Me.txtdcharge.Size = New System.Drawing.Size(240, 24)
        Me.txtdcharge.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(126, 80)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 18)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "SL No. :"
        '
        'lblslno
        '
        Me.lblslno.AutoSize = True
        Me.lblslno.Location = New System.Drawing.Point(204, 80)
        Me.lblslno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblslno.Name = "lblslno"
        Me.lblslno.Size = New System.Drawing.Size(28, 18)
        Me.lblslno.TabIndex = 21
        Me.lblslno.Text = "----"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Peru
        Me.Label10.Location = New System.Drawing.Point(-3, 417)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(915, 27)
        Me.Label10.TabIndex = 22
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(173, 347)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(201, 32)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "New"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'fileentry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 436)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblslno)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtdcharge)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.datec)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtpname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.comboopno)
        Me.Controls.Add(Me.btnapnt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.combodoc)
        Me.Controls.Add(Me.Combodept)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "fileentry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Combodept As System.Windows.Forms.ComboBox
    Friend WithEvents combodoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnapnt As System.Windows.Forms.Button
    Friend WithEvents comboopno As System.Windows.Forms.ComboBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtpname As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents datec As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtdcharge As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblslno As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
