<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class labreport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(labreport))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbltype = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbldate = New System.Windows.Forms.Label
        Me.radioop = New System.Windows.Forms.RadioButton
        Me.radioip = New System.Windows.Forms.RadioButton
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtid = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnprint = New System.Windows.Forms.Button
        Me.btnview = New System.Windows.Forms.Button
        Me.reportgrid = New System.Windows.Forms.DataGridView
        Me.btnclear = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.reportgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Orange
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-3, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(594, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lab Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name :"
        '
        'lbltype
        '
        Me.lbltype.AutoSize = True
        Me.lbltype.Location = New System.Drawing.Point(37, 22)
        Me.lbltype.Name = "lbltype"
        Me.lbltype.Size = New System.Drawing.Size(24, 13)
        Me.lbltype.TabIndex = 2
        Me.lbltype.Text = "ID :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(237, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date :"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Location = New System.Drawing.Point(279, 51)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(19, 13)
        Me.lbldate.TabIndex = 4
        Me.lbldate.Text = "----"
        '
        'radioop
        '
        Me.radioop.AccessibleName = "n"
        Me.radioop.AutoSize = True
        Me.radioop.Location = New System.Drawing.Point(18, 19)
        Me.radioop.Name = "radioop"
        Me.radioop.Size = New System.Drawing.Size(97, 17)
        Me.radioop.TabIndex = 5
        Me.radioop.TabStop = True
        Me.radioop.Text = "OUT-PATIENT"
        Me.radioop.UseVisualStyleBackColor = True
        '
        'radioip
        '
        Me.radioip.AccessibleName = "n"
        Me.radioip.AutoSize = True
        Me.radioip.Location = New System.Drawing.Point(18, 56)
        Me.radioip.Name = "radioip"
        Me.radioip.Size = New System.Drawing.Size(85, 17)
        Me.radioip.TabIndex = 6
        Me.radioip.TabStop = True
        Me.radioip.Text = "IN-PATIENT"
        Me.radioip.UseVisualStyleBackColor = True
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(67, 52)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(146, 20)
        Me.txtname.TabIndex = 8
        '
        'txtid
        '
        Me.txtid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtid.Location = New System.Drawing.Point(67, 19)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(146, 20)
        Me.txtid.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radioop)
        Me.GroupBox1.Controls.Add(Me.radioip)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 90)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Type"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtid)
        Me.GroupBox2.Controls.Add(Me.txtname)
        Me.GroupBox2.Controls.Add(Me.lbltype)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(173, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 90)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Patient Details"
        '
        'btnprint
        '
        Me.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprint.Location = New System.Drawing.Point(452, 133)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(102, 23)
        Me.btnprint.TabIndex = 11
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btnview
        '
        Me.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnview.Location = New System.Drawing.Point(452, 89)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(102, 27)
        Me.btnview.TabIndex = 12
        Me.btnview.Text = "View Report"
        Me.btnview.UseVisualStyleBackColor = True
        '
        'reportgrid
        '
        Me.reportgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.reportgrid.Location = New System.Drawing.Point(29, 198)
        Me.reportgrid.Name = "reportgrid"
        Me.reportgrid.Size = New System.Drawing.Size(525, 150)
        Me.reportgrid.TabIndex = 28
        '
        'btnclear
        '
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Location = New System.Drawing.Point(452, 51)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(102, 23)
        Me.btnclear.TabIndex = 29
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
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
        Me.btncancel.Location = New System.Drawing.Point(12, 42)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(30, 28)
        Me.btncancel.TabIndex = 27
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'labreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 380)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.reportgrid)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "labreport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "labreport"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.reportgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbltype As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents radioop As System.Windows.Forms.RadioButton
    Friend WithEvents radioip As System.Windows.Forms.RadioButton
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents reportgrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnclear As System.Windows.Forms.Button
End Class
