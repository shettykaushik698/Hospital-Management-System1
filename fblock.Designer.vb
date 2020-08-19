<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fblock
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.BidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BlockedBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bgroup7DataSet10 = New ex1.bgroup7DataSet10
        Me.BlockedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bgroup7DataSet3 = New ex1.bgroup7DataSet3
        Me.btngenerate = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.BlockedTableAdapter = New ex1.bgroup7DataSet3TableAdapters.blockedTableAdapter
        Me.Button2 = New System.Windows.Forms.Button
        Me.BlockedTableAdapter1 = New ex1.bgroup7DataSet10TableAdapters.blockedTableAdapter
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlockedBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bgroup7DataSet10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlockedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bgroup7DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BidDataGridViewTextBoxColumn, Me.BstatusDataGridViewTextBoxColumn, Me.UidDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.BlockedBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(51, 82)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(560, 208)
        Me.DataGridView1.TabIndex = 0
        '
        'BidDataGridViewTextBoxColumn
        '
        Me.BidDataGridViewTextBoxColumn.DataPropertyName = "bid"
        Me.BidDataGridViewTextBoxColumn.HeaderText = "bid"
        Me.BidDataGridViewTextBoxColumn.Name = "BidDataGridViewTextBoxColumn"
        Me.BidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BstatusDataGridViewTextBoxColumn
        '
        Me.BstatusDataGridViewTextBoxColumn.DataPropertyName = "bstatus"
        Me.BstatusDataGridViewTextBoxColumn.HeaderText = "bstatus"
        Me.BstatusDataGridViewTextBoxColumn.Name = "BstatusDataGridViewTextBoxColumn"
        Me.BstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UidDataGridViewTextBoxColumn
        '
        Me.UidDataGridViewTextBoxColumn.DataPropertyName = "uid"
        Me.UidDataGridViewTextBoxColumn.HeaderText = "uid"
        Me.UidDataGridViewTextBoxColumn.Name = "UidDataGridViewTextBoxColumn"
        Me.UidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BlockedBindingSource1
        '
        Me.BlockedBindingSource1.DataMember = "blocked"
        Me.BlockedBindingSource1.DataSource = Me.Bgroup7DataSet10
        '
        'Bgroup7DataSet10
        '
        Me.Bgroup7DataSet10.DataSetName = "bgroup7DataSet10"
        Me.Bgroup7DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BlockedBindingSource
        '
        Me.BlockedBindingSource.DataMember = "blocked"
        Me.BlockedBindingSource.DataSource = Me.Bgroup7DataSet3
        '
        'Bgroup7DataSet3
        '
        Me.Bgroup7DataSet3.DataSetName = "bgroup7DataSet3"
        Me.Bgroup7DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btngenerate
        '
        Me.btngenerate.BackColor = System.Drawing.Color.Linen
        Me.btngenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btngenerate.Location = New System.Drawing.Point(184, 342)
        Me.btngenerate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btngenerate.Name = "btngenerate"
        Me.btngenerate.Size = New System.Drawing.Size(270, 32)
        Me.btngenerate.TabIndex = 1
        Me.btngenerate.Text = "Generate Unique ID and Unblock"
        Me.btngenerate.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Tomato
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(664, 43)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Blocked Users"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BlockedTableAdapter
        '
        Me.BlockedTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.ex1.My.Resources.Resources.Button_Previous_icon
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(51, 336)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 37)
        Me.Button2.TabIndex = 15
        Me.Button2.UseVisualStyleBackColor = False
        '
        'BlockedTableAdapter1
        '
        Me.BlockedTableAdapter1.ClearBeforeFill = True
        '
        'fblock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(662, 420)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btngenerate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "fblock"
        Me.Text = "fblock"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlockedBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bgroup7DataSet10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlockedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bgroup7DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btngenerate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Bgroup7DataSet3 As ex1.bgroup7DataSet3
    Friend WithEvents BlockedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BlockedTableAdapter As ex1.bgroup7DataSet3TableAdapters.blockedTableAdapter
    Friend WithEvents BidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Bgroup7DataSet10 As ex1.bgroup7DataSet10
    Friend WithEvents BlockedBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BlockedTableAdapter1 As ex1.bgroup7DataSet10TableAdapters.blockedTableAdapter
End Class
