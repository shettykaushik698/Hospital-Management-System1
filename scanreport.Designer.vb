<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scanreport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scanreport))
        Me.btnclear = New System.Windows.Forms.Button
        Me.reportgrid = New System.Windows.Forms.DataGridView
        Me.btnview = New System.Windows.Forms.Button
        Me.btnprint = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtid = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.lbltype = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.radioop = New System.Windows.Forms.RadioButton
        Me.radioip = New System.Windows.Forms.RadioButton
        Me.lbldate = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btncancel = New System.Windows.Forms.Button
        CType(Me.reportgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnclear
        '
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Location = New System.Drawing.Point(447, 45)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(102, 23)
        Me.btnclear.TabIndex = 39
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'reportgrid
        '
        Me.reportgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.reportgrid.Location = New System.Drawing.Point(24, 192)
        Me.reportgrid.Name = "reportgrid"
        Me.reportgrid.Size = New System.Drawing.Size(525, 150)
        Me.reportgrid.TabIndex = 38
        '
        'btnview
        '
        Me.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnview.Location = New System.Drawing.Point(447, 83)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(102, 27)
        Me.btnview.TabIndex = 36
        Me.btnview.Text = "View Report"
        Me.btnview.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprint.Location = New System.Drawing.Point(447, 127)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(102, 23)
        Me.btnprint.TabIndex = 35
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtid)
        Me.GroupBox2.Controls.Add(Me.txtname)
        Me.GroupBox2.Controls.Add(Me.lbltype)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(168, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 90)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Patient Details"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(67, 19)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(146, 20)
        Me.txtid.TabIndex = 9
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(67, 52)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(146, 20)
        Me.txtname.TabIndex = 8
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radioop)
        Me.GroupBox1.Controls.Add(Me.radioip)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 90)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Type"
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
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Location = New System.Drawing.Point(274, 45)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(19, 13)
        Me.lbldate.TabIndex = 33
        Me.lbldate.Text = "----"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(232, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Date :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Olive
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-5, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(583, 31)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Scan Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btncancel.Location = New System.Drawing.Point(7, 39)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(27, 25)
        Me.btncancel.TabIndex = 37
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'scanreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 367)
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
        Me.Name = "scanreport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "scanreport"
        CType(Me.reportgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents reportgrid As System.Windows.Forms.DataGridView
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents lbltype As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radioop As System.Windows.Forms.RadioButton
    Friend WithEvents radioip As System.Windows.Forms.RadioButton
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
