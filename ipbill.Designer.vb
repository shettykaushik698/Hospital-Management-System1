<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ipbill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ipbill))
        Me.ipbillgrid = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btncal = New System.Windows.Forms.Button
        Me.txtamt = New System.Windows.Forms.TextBox
        Me.txtdiscount = New System.Windows.Forms.TextBox
        Me.combopay = New System.Windows.Forms.ComboBox
        Me.txtfamt = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnview = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnnew = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbltotdays = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtwt = New System.Windows.Forms.TextBox
        Me.txtwn = New System.Windows.Forms.TextBox
        Me.txtbn = New System.Windows.Forms.TextBox
        Me.txtdoa = New System.Windows.Forms.TextBox
        Me.txtopno = New System.Windows.Forms.TextBox
        Me.txtphno = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtsceheme = New System.Windows.Forms.TextBox
        Me.txtbillno = New System.Windows.Forms.TextBox
        Me.txtdoc = New System.Windows.Forms.TextBox
        Me.txtadd = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtsex = New System.Windows.Forms.TextBox
        Me.txtage = New System.Windows.Forms.TextBox
        Me.txtipno = New System.Windows.Forms.TextBox
        Me.lbldate = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.ipbillgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ipbillgrid
        '
        Me.ipbillgrid.AllowUserToAddRows = False
        Me.ipbillgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ipbillgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ipbillgrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.ipbillgrid.Location = New System.Drawing.Point(12, 299)
        Me.ipbillgrid.Margin = New System.Windows.Forms.Padding(4)
        Me.ipbillgrid.MultiSelect = False
        Me.ipbillgrid.Name = "ipbillgrid"
        Me.ipbillgrid.ReadOnly = True
        Me.ipbillgrid.Size = New System.Drawing.Size(1164, 202)
        Me.ipbillgrid.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "Description"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Charge"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Particulars"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Amount"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btncal)
        Me.GroupBox2.Controls.Add(Me.txtamt)
        Me.GroupBox2.Controls.Add(Me.txtdiscount)
        Me.GroupBox2.Controls.Add(Me.combopay)
        Me.GroupBox2.Controls.Add(Me.txtfamt)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 508)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1164, 116)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment"
        '
        'btncal
        '
        Me.btncal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncal.Location = New System.Drawing.Point(523, 26)
        Me.btncal.Margin = New System.Windows.Forms.Padding(4)
        Me.btncal.Name = "btncal"
        Me.btncal.Size = New System.Drawing.Size(100, 66)
        Me.btncal.TabIndex = 16
        Me.btncal.Text = "Calculate"
        Me.btncal.UseVisualStyleBackColor = True
        '
        'txtamt
        '
        Me.txtamt.Location = New System.Drawing.Point(187, 30)
        Me.txtamt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtamt.Name = "txtamt"
        Me.txtamt.ReadOnly = True
        Me.txtamt.Size = New System.Drawing.Size(281, 22)
        Me.txtamt.TabIndex = 15
        '
        'txtdiscount
        '
        Me.txtdiscount.Location = New System.Drawing.Point(187, 68)
        Me.txtdiscount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.ReadOnly = True
        Me.txtdiscount.Size = New System.Drawing.Size(281, 22)
        Me.txtdiscount.TabIndex = 14
        '
        'combopay
        '
        Me.combopay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combopay.FormattingEnabled = True
        Me.combopay.Items.AddRange(New Object() {"Cash", "Card"})
        Me.combopay.Location = New System.Drawing.Point(783, 30)
        Me.combopay.Margin = New System.Windows.Forms.Padding(4)
        Me.combopay.Name = "combopay"
        Me.combopay.Size = New System.Drawing.Size(287, 24)
        Me.combopay.TabIndex = 13
        '
        'txtfamt
        '
        Me.txtfamt.Location = New System.Drawing.Point(783, 68)
        Me.txtfamt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfamt.Name = "txtfamt"
        Me.txtfamt.ReadOnly = True
        Me.txtfamt.Size = New System.Drawing.Size(287, 22)
        Me.txtfamt.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(673, 71)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 16)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Final Amount :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(47, 71)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(119, 16)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Scheme Discount :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(663, 33)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Payment Mode :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(111, 33)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Amount :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btncancel)
        Me.GroupBox3.Controls.Add(Me.btnview)
        Me.GroupBox3.Controls.Add(Me.btnsave)
        Me.GroupBox3.Controls.Add(Me.btnnew)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 631)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1164, 64)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = " "
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
        Me.btncancel.Location = New System.Drawing.Point(29, 13)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(36, 39)
        Me.btncancel.TabIndex = 28
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnview
        '
        Me.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnview.Location = New System.Drawing.Point(907, 23)
        Me.btnview.Margin = New System.Windows.Forms.Padding(4)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(189, 28)
        Me.btnview.TabIndex = 3
        Me.btnview.Text = "View Bill"
        Me.btnview.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Location = New System.Drawing.Point(543, 23)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(189, 28)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnew.Location = New System.Drawing.Point(155, 22)
        Me.btnnew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(189, 28)
        Me.btnnew.TabIndex = 0
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbltotdays)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtwt)
        Me.GroupBox1.Controls.Add(Me.txtwn)
        Me.GroupBox1.Controls.Add(Me.txtbn)
        Me.GroupBox1.Controls.Add(Me.txtdoa)
        Me.GroupBox1.Controls.Add(Me.txtopno)
        Me.GroupBox1.Controls.Add(Me.txtphno)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtsceheme)
        Me.GroupBox1.Controls.Add(Me.txtbillno)
        Me.GroupBox1.Controls.Add(Me.txtdoc)
        Me.GroupBox1.Controls.Add(Me.txtadd)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txtsex)
        Me.GroupBox1.Controls.Add(Me.txtage)
        Me.GroupBox1.Controls.Add(Me.txtipno)
        Me.GroupBox1.Controls.Add(Me.lbldate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1164, 231)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Details"
        '
        'lbltotdays
        '
        Me.lbltotdays.AutoSize = True
        Me.lbltotdays.Location = New System.Drawing.Point(1075, 30)
        Me.lbltotdays.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotdays.Name = "lbltotdays"
        Me.lbltotdays.Size = New System.Drawing.Size(24, 16)
        Me.lbltotdays.TabIndex = 35
        Me.lbltotdays.Text = "----"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(992, 30)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 16)
        Me.Label22.TabIndex = 34
        Me.Label22.Text = "N.O.Days :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(37, 194)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(47, 16)
        Me.Label21.TabIndex = 33
        Me.Label21.Text = "Ward :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(319, 194)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 16)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "Room :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(811, 194)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 16)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Bed :"
        '
        'txtwt
        '
        Me.txtwt.Location = New System.Drawing.Point(97, 191)
        Me.txtwt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtwt.Name = "txtwt"
        Me.txtwt.ReadOnly = True
        Me.txtwt.Size = New System.Drawing.Size(187, 22)
        Me.txtwt.TabIndex = 30
        '
        'txtwn
        '
        Me.txtwn.Location = New System.Drawing.Point(380, 191)
        Me.txtwn.Margin = New System.Windows.Forms.Padding(4)
        Me.txtwn.Name = "txtwn"
        Me.txtwn.ReadOnly = True
        Me.txtwn.Size = New System.Drawing.Size(391, 22)
        Me.txtwn.TabIndex = 29
        '
        'txtbn
        '
        Me.txtbn.Location = New System.Drawing.Point(867, 191)
        Me.txtbn.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbn.Name = "txtbn"
        Me.txtbn.ReadOnly = True
        Me.txtbn.Size = New System.Drawing.Size(267, 22)
        Me.txtbn.TabIndex = 28
        '
        'txtdoa
        '
        Me.txtdoa.Location = New System.Drawing.Point(867, 150)
        Me.txtdoa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdoa.Name = "txtdoa"
        Me.txtdoa.ReadOnly = True
        Me.txtdoa.Size = New System.Drawing.Size(267, 22)
        Me.txtdoa.TabIndex = 27
        '
        'txtopno
        '
        Me.txtopno.Location = New System.Drawing.Point(97, 150)
        Me.txtopno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtopno.Name = "txtopno"
        Me.txtopno.ReadOnly = True
        Me.txtopno.Size = New System.Drawing.Size(187, 22)
        Me.txtopno.TabIndex = 26
        '
        'txtphno
        '
        Me.txtphno.Location = New System.Drawing.Point(380, 150)
        Me.txtphno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtphno.Name = "txtphno"
        Me.txtphno.ReadOnly = True
        Me.txtphno.Size = New System.Drawing.Size(391, 22)
        Me.txtphno.TabIndex = 25
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(25, 154)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 16)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "OP No. :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(312, 154)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 16)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Ph No. :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(803, 154)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 16)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "D.O.A :"
        '
        'txtsceheme
        '
        Me.txtsceheme.Location = New System.Drawing.Point(380, 106)
        Me.txtsceheme.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsceheme.Name = "txtsceheme"
        Me.txtsceheme.ReadOnly = True
        Me.txtsceheme.Size = New System.Drawing.Size(391, 22)
        Me.txtsceheme.TabIndex = 21
        '
        'txtbillno
        '
        Me.txtbillno.Location = New System.Drawing.Point(867, 64)
        Me.txtbillno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbillno.Name = "txtbillno"
        Me.txtbillno.ReadOnly = True
        Me.txtbillno.Size = New System.Drawing.Size(267, 22)
        Me.txtbillno.TabIndex = 20
        '
        'txtdoc
        '
        Me.txtdoc.Location = New System.Drawing.Point(867, 106)
        Me.txtdoc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdoc.Name = "txtdoc"
        Me.txtdoc.ReadOnly = True
        Me.txtdoc.Size = New System.Drawing.Size(267, 22)
        Me.txtdoc.TabIndex = 19
        '
        'txtadd
        '
        Me.txtadd.Location = New System.Drawing.Point(380, 68)
        Me.txtadd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtadd.Name = "txtadd"
        Me.txtadd.ReadOnly = True
        Me.txtadd.Size = New System.Drawing.Size(391, 22)
        Me.txtadd.TabIndex = 18
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(380, 30)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(391, 22)
        Me.txtname.TabIndex = 17
        '
        'txtsex
        '
        Me.txtsex.Location = New System.Drawing.Point(97, 106)
        Me.txtsex.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsex.Name = "txtsex"
        Me.txtsex.ReadOnly = True
        Me.txtsex.Size = New System.Drawing.Size(187, 22)
        Me.txtsex.TabIndex = 16
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(97, 68)
        Me.txtage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtage.Name = "txtage"
        Me.txtage.ReadOnly = True
        Me.txtage.Size = New System.Drawing.Size(187, 22)
        Me.txtage.TabIndex = 15
        '
        'txtipno
        '
        Me.txtipno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtipno.Location = New System.Drawing.Point(97, 30)
        Me.txtipno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtipno.Name = "txtipno"
        Me.txtipno.Size = New System.Drawing.Size(187, 22)
        Me.txtipno.TabIndex = 14
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Location = New System.Drawing.Point(863, 30)
        Me.lbldate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(24, 16)
        Me.lbldate.TabIndex = 9
        Me.lbldate.Text = "----"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 33)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "IP No. :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(303, 110)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Scheme :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(797, 68)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Bill No. :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(304, 71)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Address :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(799, 110)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Doctor :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(317, 33)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Name :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(811, 30)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 16)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Date :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(47, 110)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 16)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Sex :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(47, 73)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 16)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Age :"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Chocolate
        Me.Label2.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-9, 711)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1204, 31)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter the IP number"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Chocolate
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-11, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1209, 34)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "IN-PATIENT BILLING"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ipbill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 741)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ipbillgrid)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ipbill"
        Me.Text = "ipbill"
        CType(Me.ipbillgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ipbillgrid As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btncal As System.Windows.Forms.Button
    Friend WithEvents txtamt As System.Windows.Forms.TextBox
    Friend WithEvents txtdiscount As System.Windows.Forms.TextBox
    Friend WithEvents combopay As System.Windows.Forms.ComboBox
    Friend WithEvents txtfamt As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsceheme As System.Windows.Forms.TextBox
    Friend WithEvents txtbillno As System.Windows.Forms.TextBox
    Friend WithEvents txtdoc As System.Windows.Forms.TextBox
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtsex As System.Windows.Forms.TextBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents txtipno As System.Windows.Forms.TextBox
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdoa As System.Windows.Forms.TextBox
    Friend WithEvents txtopno As System.Windows.Forms.TextBox
    Friend WithEvents txtphno As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtwt As System.Windows.Forms.TextBox
    Friend WithEvents txtwn As System.Windows.Forms.TextBox
    Friend WithEvents txtbn As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbltotdays As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
End Class
