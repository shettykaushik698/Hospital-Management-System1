<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class labap
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(labap))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblslno = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblid = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txttcharge = New System.Windows.Forms.TextBox
        Me.txtid = New System.Windows.Forms.TextBox
        Me.lbldate = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.combotype = New System.Windows.Forms.ComboBox
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnnew = New System.Windows.Forms.Button
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.dgvlab = New System.Windows.Forms.DataGridView
        Me.Bgroup7DataSet8 = New ex1.bgroup7DataSet8
        Me.LabBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabTableAdapter = New ex1.bgroup7DataSet8TableAdapters.labTableAdapter
        Me.dgvtemp = New System.Windows.Forms.DataGridView
        Me.txttname = New System.Windows.Forms.ComboBox
        Me.Bgroup7DataSet91 = New ex1.bgroup7DataSet9
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BlabTableAdapter1 = New ex1.bgroup7DataSet9TableAdapters.blabTableAdapter
        Me.btnclear = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnrefresh = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        CType(Me.dgvlab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bgroup7DataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvtemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bgroup7DataSet91, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Goldenrod
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(983, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lab Test Appointment"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SL No :"
        '
        'lblslno
        '
        Me.lblslno.AutoSize = True
        Me.lblslno.Location = New System.Drawing.Point(115, 78)
        Me.lblslno.Name = "lblslno"
        Me.lblslno.Size = New System.Drawing.Size(20, 16)
        Me.lblslno.TabIndex = 2
        Me.lblslno.Text = "---"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Test Name :"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(30, 186)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(71, 16)
        Me.lblid.TabIndex = 5
        Me.lblid.Text = "Patient ID :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Patient Type :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(715, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Date :"
        '
        'txttcharge
        '
        Me.txttcharge.Location = New System.Drawing.Point(115, 267)
        Me.txttcharge.Name = "txttcharge"
        Me.txttcharge.ReadOnly = True
        Me.txttcharge.Size = New System.Drawing.Size(229, 22)
        Me.txttcharge.TabIndex = 10
        '
        'txtid
        '
        Me.txtid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtid.Location = New System.Drawing.Point(118, 182)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(228, 22)
        Me.txtid.TabIndex = 13
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Location = New System.Drawing.Point(771, 64)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(20, 16)
        Me.lbldate.TabIndex = 17
        Me.lbldate.Text = "---"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Test Charge :"
        '
        'combotype
        '
        Me.combotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combotype.FormattingEnabled = True
        Me.combotype.Items.AddRange(New Object() {"OUT-PATIENT", "IN-PATIENT"})
        Me.combotype.Location = New System.Drawing.Point(118, 126)
        Me.combotype.Name = "combotype"
        Me.combotype.Size = New System.Drawing.Size(228, 24)
        Me.combotype.TabIndex = 19
        '
        'btnsave
        '
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Location = New System.Drawing.Point(327, 323)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(99, 29)
        Me.btnsave.TabIndex = 20
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnew.Location = New System.Drawing.Point(150, 319)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(99, 29)
        Me.btnnew.TabIndex = 23
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.Location = New System.Drawing.Point(0, 380)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(979, 246)
        Me.Splitter1.TabIndex = 25
        Me.Splitter1.TabStop = False
        '
        'dgvlab
        '
        Me.dgvlab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlab.Location = New System.Drawing.Point(16, 400)
        Me.dgvlab.Name = "dgvlab"
        Me.dgvlab.ReadOnly = True
        Me.dgvlab.Size = New System.Drawing.Size(947, 214)
        Me.dgvlab.TabIndex = 27
        '
        'Bgroup7DataSet8
        '
        Me.Bgroup7DataSet8.DataSetName = "bgroup7DataSet8"
        Me.Bgroup7DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabBindingSource
        '
        Me.LabBindingSource.DataMember = "lab"
        Me.LabBindingSource.DataSource = Me.Bgroup7DataSet8
        '
        'LabTableAdapter
        '
        Me.LabTableAdapter.ClearBeforeFill = True
        '
        'dgvtemp
        '
        Me.dgvtemp.AllowUserToOrderColumns = True
        Me.dgvtemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtemp.Location = New System.Drawing.Point(354, 107)
        Me.dgvtemp.Name = "dgvtemp"
        Me.dgvtemp.ReadOnly = True
        Me.dgvtemp.Size = New System.Drawing.Size(609, 185)
        Me.dgvtemp.TabIndex = 28
        '
        'txttname
        '
        Me.txttname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txttname.FormattingEnabled = True
        Me.txttname.Location = New System.Drawing.Point(118, 226)
        Me.txttname.Name = "txttname"
        Me.txttname.Size = New System.Drawing.Size(228, 24)
        Me.txttname.TabIndex = 29
        '
        'Bgroup7DataSet91
        '
        Me.Bgroup7DataSet91.DataSetName = "bgroup7DataSet9"
        Me.Bgroup7DataSet91.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "blab"
        Me.BindingSource1.DataSource = Me.Bgroup7DataSet91
        '
        'BlabTableAdapter1
        '
        Me.BlabTableAdapter1.ClearBeforeFill = True
        '
        'btnclear
        '
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Location = New System.Drawing.Point(519, 319)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(99, 29)
        Me.btnclear.TabIndex = 31
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(681, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Green
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(770, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(862, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 16)
        Me.Label7.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(678, 341)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 16)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Pending"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(762, 339)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 16)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Attended"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(857, 339)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 16)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Ready"
        '
        'btnrefresh
        '
        Me.btnrefresh.BackgroundImage = CType(resources.GetObject("btnrefresh.BackgroundImage"), System.Drawing.Image)
        Me.btnrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnrefresh.FlatAppearance.BorderSize = 0
        Me.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrefresh.Location = New System.Drawing.Point(80, 319)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(39, 37)
        Me.btnrefresh.TabIndex = 26
        Me.btnrefresh.UseVisualStyleBackColor = True
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
        Me.btncancel.Location = New System.Drawing.Point(16, 319)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(37, 37)
        Me.btncancel.TabIndex = 24
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'labap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 626)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.txttname)
        Me.Controls.Add(Me.dgvtemp)
        Me.Controls.Add(Me.dgvlab)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.combotype)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.txttcharge)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblslno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "labap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "labap"
        CType(Me.dgvlab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bgroup7DataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvtemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bgroup7DataSet91, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblslno As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txttcharge As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents combotype As System.Windows.Forms.ComboBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents dgvlab As System.Windows.Forms.DataGridView
    Friend WithEvents Bgroup7DataSet8 As ex1.bgroup7DataSet8
    Friend WithEvents LabBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LabTableAdapter As ex1.bgroup7DataSet8TableAdapters.labTableAdapter
    Friend WithEvents dgvtemp As System.Windows.Forms.DataGridView
    Friend WithEvents Bgroup7DataSet9 As ex1.bgroup7DataSet9
    Friend WithEvents BlabBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BlabTableAdapter As ex1.bgroup7DataSet9TableAdapters.blabTableAdapter
    Friend WithEvents txttname As System.Windows.Forms.ComboBox
    Friend WithEvents Bgroup7DataSet91 As ex1.bgroup7DataSet9
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BlabTableAdapter1 As ex1.bgroup7DataSet9TableAdapters.blabTableAdapter
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
