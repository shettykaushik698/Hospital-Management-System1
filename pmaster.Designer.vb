<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pmaster
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
        Me.pgrid = New System.Windows.Forms.DataGridView
        Me.btnop = New System.Windows.Forms.Button
        Me.btnip = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Bgroup7DataSet7 = New ex1.bgroup7DataSet7
        Me.OpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpTableAdapter = New ex1.bgroup7DataSet7TableAdapters.opTableAdapter
        CType(Me.pgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bgroup7DataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pgrid
        '
        Me.pgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pgrid.Location = New System.Drawing.Point(33, 59)
        Me.pgrid.Name = "pgrid"
        Me.pgrid.ReadOnly = True
        Me.pgrid.Size = New System.Drawing.Size(1037, 214)
        Me.pgrid.TabIndex = 0
        '
        'btnop
        '
        Me.btnop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnop.Location = New System.Drawing.Point(217, 307)
        Me.btnop.Name = "btnop"
        Me.btnop.Size = New System.Drawing.Size(265, 23)
        Me.btnop.TabIndex = 1
        Me.btnop.Text = "OUT-Pateient"
        Me.btnop.UseVisualStyleBackColor = True
        '
        'btnip
        '
        Me.btnip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnip.Location = New System.Drawing.Point(632, 307)
        Me.btnip.Name = "btnip"
        Me.btnip.Size = New System.Drawing.Size(265, 23)
        Me.btnip.TabIndex = 2
        Me.btnip.Text = "IN-Patient"
        Me.btnip.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.ex1.My.Resources.Resources.Button_Previous_icon
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(33, 307)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(30, 27)
        Me.Button3.TabIndex = 81
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Khaki
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-4, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1114, 34)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Patient Master"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Bgroup7DataSet7
        '
        Me.Bgroup7DataSet7.DataSetName = "bgroup7DataSet7"
        Me.Bgroup7DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OpBindingSource
        '
        Me.OpBindingSource.DataMember = "op"
        Me.OpBindingSource.DataSource = Me.Bgroup7DataSet7
        '
        'OpTableAdapter
        '
        Me.OpTableAdapter.ClearBeforeFill = True
        '
        'pmaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 362)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnip)
        Me.Controls.Add(Me.btnop)
        Me.Controls.Add(Me.pgrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pmaster"
        Me.Text = "pmaster"
        CType(Me.pgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bgroup7DataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pgrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnop As System.Windows.Forms.Button
    Friend WithEvents btnip As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Bgroup7DataSet7 As ex1.bgroup7DataSet7
    Friend WithEvents OpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OpTableAdapter As ex1.bgroup7DataSet7TableAdapters.opTableAdapter
End Class
