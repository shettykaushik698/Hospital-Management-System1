<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bedshift
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bedshift))
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnshift = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtipno = New System.Windows.Forms.TextBox
        Me.txtwt = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtwn = New System.Windows.Forms.TextBox
        Me.txtbn = New System.Windows.Forms.TextBox
        Me.combowt = New System.Windows.Forms.ComboBox
        Me.combown = New System.Windows.Forms.ComboBox
        Me.combobn = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btncheck = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.MediumPurple
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-3, -3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(852, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bed Shift"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnshift
        '
        Me.btnshift.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnshift.Location = New System.Drawing.Point(140, 258)
        Me.btnshift.Margin = New System.Windows.Forms.Padding(4)
        Me.btnshift.Name = "btnshift"
        Me.btnshift.Size = New System.Drawing.Size(138, 32)
        Me.btnshift.TabIndex = 1
        Me.btnshift.Text = "Shift"
        Me.btnshift.UseVisualStyleBackColor = True
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
        Me.btncancel.Location = New System.Drawing.Point(24, 357)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(40, 42)
        Me.btncancel.TabIndex = 25
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "IP No. :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 138)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 18)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 190)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 18)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Ward Type :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 248)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Ward No. :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 298)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 18)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Bed No. :"
        '
        'txtipno
        '
        Me.txtipno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtipno.Location = New System.Drawing.Point(106, 79)
        Me.txtipno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtipno.Name = "txtipno"
        Me.txtipno.Size = New System.Drawing.Size(282, 24)
        Me.txtipno.TabIndex = 31
        '
        'txtwt
        '
        Me.txtwt.Location = New System.Drawing.Point(106, 186)
        Me.txtwt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtwt.Name = "txtwt"
        Me.txtwt.ReadOnly = True
        Me.txtwt.Size = New System.Drawing.Size(282, 24)
        Me.txtwt.TabIndex = 32
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(106, 134)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(282, 24)
        Me.txtname.TabIndex = 33
        '
        'txtwn
        '
        Me.txtwn.Location = New System.Drawing.Point(106, 244)
        Me.txtwn.Margin = New System.Windows.Forms.Padding(4)
        Me.txtwn.Name = "txtwn"
        Me.txtwn.ReadOnly = True
        Me.txtwn.Size = New System.Drawing.Size(282, 24)
        Me.txtwn.TabIndex = 34
        '
        'txtbn
        '
        Me.txtbn.Location = New System.Drawing.Point(106, 294)
        Me.txtbn.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbn.Name = "txtbn"
        Me.txtbn.ReadOnly = True
        Me.txtbn.Size = New System.Drawing.Size(282, 24)
        Me.txtbn.TabIndex = 35
        '
        'combowt
        '
        Me.combowt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combowt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.combowt.FormattingEnabled = True
        Me.combowt.Location = New System.Drawing.Point(140, 33)
        Me.combowt.Margin = New System.Windows.Forms.Padding(4)
        Me.combowt.Name = "combowt"
        Me.combowt.Size = New System.Drawing.Size(262, 26)
        Me.combowt.TabIndex = 36
        '
        'combown
        '
        Me.combown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.combown.FormattingEnabled = True
        Me.combown.Location = New System.Drawing.Point(140, 100)
        Me.combown.Margin = New System.Windows.Forms.Padding(4)
        Me.combown.Name = "combown"
        Me.combown.Size = New System.Drawing.Size(262, 26)
        Me.combown.TabIndex = 37
        '
        'combobn
        '
        Me.combobn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.combobn.FormattingEnabled = True
        Me.combobn.Location = New System.Drawing.Point(140, 169)
        Me.combobn.Margin = New System.Windows.Forms.Padding(4)
        Me.combobn.Name = "combobn"
        Me.combobn.Size = New System.Drawing.Size(262, 26)
        Me.combobn.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 37)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 18)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Ward Type :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 107)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 18)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Ward No. :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(52, 173)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 18)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Bed No. :"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.combowt)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.combown)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.combobn)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnshift)
        Me.Panel1.Location = New System.Drawing.Point(399, 79)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(429, 332)
        Me.Panel1.TabIndex = 42
        '
        'btncheck
        '
        Me.btncheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncheck.Location = New System.Drawing.Point(188, 357)
        Me.btncheck.Margin = New System.Windows.Forms.Padding(4)
        Me.btncheck.Name = "btncheck"
        Me.btncheck.Size = New System.Drawing.Size(128, 32)
        Me.btncheck.TabIndex = 43
        Me.btncheck.Text = "Check"
        Me.btncheck.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(579, 47)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 20)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Shift to :"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.MediumPurple
        Me.Label11.Location = New System.Drawing.Point(-10, 431)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(860, 39)
        Me.Label11.TabIndex = 45
        '
        'bedshift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 456)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btncheck)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtbn)
        Me.Controls.Add(Me.txtwn)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtwt)
        Me.Controls.Add(Me.txtipno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "bedshift"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "bedshift"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnshift As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtipno As System.Windows.Forms.TextBox
    Friend WithEvents txtwt As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtwn As System.Windows.Forms.TextBox
    Friend WithEvents txtbn As System.Windows.Forms.TextBox
    Friend WithEvents combowt As System.Windows.Forms.ComboBox
    Friend WithEvents combown As System.Windows.Forms.ComboBox
    Friend WithEvents combobn As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btncheck As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
