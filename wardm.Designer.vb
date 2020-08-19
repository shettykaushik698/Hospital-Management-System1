<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wardm
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgvward = New System.Windows.Forms.DataGridView
        Me.btnav = New System.Windows.Forms.Button
        Me.Bgroup7DataSet5 = New ex1.bgroup7DataSet5
        Me.DwardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DwardTableAdapter = New ex1.bgroup7DataSet5TableAdapters.dwardTableAdapter
        Me.Bgroup7DataSet6 = New ex1.bgroup7DataSet6
        Me.IpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IpTableAdapter = New ex1.bgroup7DataSet6TableAdapters.ipTableAdapter
        Me.btnchart = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.dgvward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bgroup7DataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DwardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bgroup7DataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(297, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(178, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-3, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(688, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WARD MASTER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(199, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select ward type :"
        '
        'dgvward
        '
        Me.dgvward.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvward.Location = New System.Drawing.Point(28, 78)
        Me.dgvward.Name = "dgvward"
        Me.dgvward.ReadOnly = True
        Me.dgvward.Size = New System.Drawing.Size(627, 205)
        Me.dgvward.TabIndex = 3
        '
        'btnav
        '
        Me.btnav.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnav.Location = New System.Drawing.Point(284, 298)
        Me.btnav.Name = "btnav"
        Me.btnav.Size = New System.Drawing.Size(137, 32)
        Me.btnav.TabIndex = 86
        Me.btnav.Text = "Patient Bed Occupancy"
        Me.btnav.UseVisualStyleBackColor = True
        '
        'Bgroup7DataSet5
        '
        Me.Bgroup7DataSet5.DataSetName = "bgroup7DataSet5"
        Me.Bgroup7DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DwardBindingSource
        '
        Me.DwardBindingSource.DataMember = "dward"
        Me.DwardBindingSource.DataSource = Me.Bgroup7DataSet5
        '
        'DwardTableAdapter
        '
        Me.DwardTableAdapter.ClearBeforeFill = True
        '
        'Bgroup7DataSet6
        '
        Me.Bgroup7DataSet6.DataSetName = "bgroup7DataSet6"
        Me.Bgroup7DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IpBindingSource
        '
        Me.IpBindingSource.DataMember = "ip"
        Me.IpBindingSource.DataSource = Me.Bgroup7DataSet6
        '
        'IpTableAdapter
        '
        Me.IpTableAdapter.ClearBeforeFill = True
        '
        'btnchart
        '
        Me.btnchart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnchart.Location = New System.Drawing.Point(486, 298)
        Me.btnchart.Name = "btnchart"
        Me.btnchart.Size = New System.Drawing.Size(139, 32)
        Me.btnchart.TabIndex = 87
        Me.btnchart.Text = "Over View"
        Me.btnchart.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(56, 298)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(172, 32)
        Me.Button2.TabIndex = 88
        Me.Button2.Text = "Add Ward/Bed"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label3.Location = New System.Drawing.Point(-6, 342)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(691, 26)
        Me.Label3.TabIndex = 89
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.ex1.My.Resources.Resources.Button_Previous_icon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(28, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 27)
        Me.Button1.TabIndex = 85
        Me.Button1.UseVisualStyleBackColor = False
        '
        'wardm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 362)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnchart)
        Me.Controls.Add(Me.btnav)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvward)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "wardm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "wardm"
        CType(Me.dgvward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bgroup7DataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DwardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bgroup7DataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvward As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnav As System.Windows.Forms.Button
    Friend WithEvents Bgroup7DataSet5 As ex1.bgroup7DataSet5
    Friend WithEvents DwardBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DwardTableAdapter As ex1.bgroup7DataSet5TableAdapters.dwardTableAdapter
    Friend WithEvents Bgroup7DataSet6 As ex1.bgroup7DataSet6
    Friend WithEvents IpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IpTableAdapter As ex1.bgroup7DataSet6TableAdapters.ipTableAdapter
    Friend WithEvents btnchart As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
