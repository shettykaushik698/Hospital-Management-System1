<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class apmts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(apmts))
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnclear = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.PidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DepartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ConsultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bgroup7DataSet4 = New ex1.bgroup7DataSet4
        Me.ConsultTableAdapter = New ex1.bgroup7DataSet4TableAdapters.consultTableAdapter
        Me.btnrefresh = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bgroup7DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.ex1.My.Resources.Resources.Button_Previous_icon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(36, 312)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 39)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Location = New System.Drawing.Point(288, 318)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(222, 32)
        Me.btnupdate.TabIndex = 10
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.NavajoWhite
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-3, -1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1122, 46)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Consultation Appointments"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnclear
        '
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Location = New System.Drawing.Point(684, 318)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(258, 32)
        Me.btnclear.TabIndex = 13
        Me.btnclear.Text = "Clear consulted patients"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PidDataGridViewTextBoxColumn, Me.PnameDataGridViewTextBoxColumn, Me.DepartDataGridViewTextBoxColumn, Me.DidDataGridViewTextBoxColumn, Me.DnameDataGridViewTextBoxColumn, Me.DstatusDataGridViewTextBoxColumn, Me.CdateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ConsultBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(36, 72)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1044, 208)
        Me.DataGridView1.TabIndex = 14
        '
        'PidDataGridViewTextBoxColumn
        '
        Me.PidDataGridViewTextBoxColumn.DataPropertyName = "pid"
        Me.PidDataGridViewTextBoxColumn.HeaderText = "pid"
        Me.PidDataGridViewTextBoxColumn.Name = "PidDataGridViewTextBoxColumn"
        Me.PidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PnameDataGridViewTextBoxColumn
        '
        Me.PnameDataGridViewTextBoxColumn.DataPropertyName = "pname"
        Me.PnameDataGridViewTextBoxColumn.HeaderText = "pname"
        Me.PnameDataGridViewTextBoxColumn.Name = "PnameDataGridViewTextBoxColumn"
        Me.PnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DepartDataGridViewTextBoxColumn
        '
        Me.DepartDataGridViewTextBoxColumn.DataPropertyName = "depart"
        Me.DepartDataGridViewTextBoxColumn.HeaderText = "depart"
        Me.DepartDataGridViewTextBoxColumn.Name = "DepartDataGridViewTextBoxColumn"
        Me.DepartDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DidDataGridViewTextBoxColumn
        '
        Me.DidDataGridViewTextBoxColumn.DataPropertyName = "did"
        Me.DidDataGridViewTextBoxColumn.HeaderText = "did"
        Me.DidDataGridViewTextBoxColumn.Name = "DidDataGridViewTextBoxColumn"
        Me.DidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DnameDataGridViewTextBoxColumn
        '
        Me.DnameDataGridViewTextBoxColumn.DataPropertyName = "dname"
        Me.DnameDataGridViewTextBoxColumn.HeaderText = "dname"
        Me.DnameDataGridViewTextBoxColumn.Name = "DnameDataGridViewTextBoxColumn"
        Me.DnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DstatusDataGridViewTextBoxColumn
        '
        Me.DstatusDataGridViewTextBoxColumn.DataPropertyName = "dstatus"
        Me.DstatusDataGridViewTextBoxColumn.HeaderText = "dstatus"
        Me.DstatusDataGridViewTextBoxColumn.Name = "DstatusDataGridViewTextBoxColumn"
        Me.DstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CdateDataGridViewTextBoxColumn
        '
        Me.CdateDataGridViewTextBoxColumn.DataPropertyName = "cdate"
        Me.CdateDataGridViewTextBoxColumn.HeaderText = "cdate"
        Me.CdateDataGridViewTextBoxColumn.Name = "CdateDataGridViewTextBoxColumn"
        Me.CdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConsultBindingSource
        '
        Me.ConsultBindingSource.DataMember = "consult"
        Me.ConsultBindingSource.DataSource = Me.Bgroup7DataSet4
        '
        'Bgroup7DataSet4
        '
        Me.Bgroup7DataSet4.DataSetName = "bgroup7DataSet4"
        Me.Bgroup7DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConsultTableAdapter
        '
        Me.ConsultTableAdapter.ClearBeforeFill = True
        '
        'btnrefresh
        '
        Me.btnrefresh.BackgroundImage = CType(resources.GetObject("btnrefresh.BackgroundImage"), System.Drawing.Image)
        Me.btnrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnrefresh.FlatAppearance.BorderSize = 0
        Me.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrefresh.Location = New System.Drawing.Point(142, 312)
        Me.btnrefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(42, 39)
        Me.btnrefresh.TabIndex = 32
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'apmts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 385)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "apmts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "apmts"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bgroup7DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Bgroup7DataSet4 As ex1.bgroup7DataSet4
    Friend WithEvents ConsultBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConsultTableAdapter As ex1.bgroup7DataSet4TableAdapters.consultTableAdapter
    Friend WithEvents PidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
End Class
