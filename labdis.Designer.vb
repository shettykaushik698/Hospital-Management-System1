<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class labdis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(labdis))
        Me.Label1 = New System.Windows.Forms.Label
        Me.labviewgrid = New System.Windows.Forms.DataGridView
        Me.btnseen = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.lbltest = New System.Windows.Forms.Label
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnrefresh = New System.Windows.Forms.Button
        CType(Me.labviewgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.YellowGreen
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-11, -1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1276, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LABORATORY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labviewgrid
        '
        Me.labviewgrid.AllowUserToAddRows = False
        Me.labviewgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.labviewgrid.Location = New System.Drawing.Point(16, 58)
        Me.labviewgrid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.labviewgrid.MultiSelect = False
        Me.labviewgrid.Name = "labviewgrid"
        Me.labviewgrid.ReadOnly = True
        Me.labviewgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.labviewgrid.Size = New System.Drawing.Size(1231, 373)
        Me.labviewgrid.TabIndex = 1
        '
        'btnseen
        '
        Me.btnseen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnseen.Location = New System.Drawing.Point(199, 470)
        Me.btnseen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnseen.Name = "btnseen"
        Me.btnseen.Size = New System.Drawing.Size(100, 28)
        Me.btnseen.TabIndex = 2
        Me.btnseen.Text = "Attend"
        Me.btnseen.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(805, 472)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(160, 22)
        Me.TextBox1.TabIndex = 3
        '
        'lbltest
        '
        Me.lbltest.AutoSize = True
        Me.lbltest.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltest.Location = New System.Drawing.Point(508, 470)
        Me.lbltest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltest.Name = "lbltest"
        Me.lbltest.Size = New System.Drawing.Size(273, 24)
        Me.lbltest.TabIndex = 29
        Me.lbltest.Text = "Enter the Obtained Test Value :"
        '
        'btnupdate
        '
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Location = New System.Drawing.Point(336, 470)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(100, 28)
        Me.btnupdate.TabIndex = 30
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
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
        Me.btncancel.Location = New System.Drawing.Point(16, 470)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(41, 39)
        Me.btncancel.TabIndex = 28
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnrefresh
        '
        Me.btnrefresh.BackgroundImage = CType(resources.GetObject("btnrefresh.BackgroundImage"), System.Drawing.Image)
        Me.btnrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnrefresh.FlatAppearance.BorderSize = 0
        Me.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrefresh.Location = New System.Drawing.Point(95, 470)
        Me.btnrefresh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(41, 38)
        Me.btnrefresh.TabIndex = 27
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'labdis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1263, 524)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.lbltest)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnseen)
        Me.Controls.Add(Me.labviewgrid)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "labdis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "labdis"
        CType(Me.labviewgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents labviewgrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnseen As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents lbltest As System.Windows.Forms.Label
    Friend WithEvents btnupdate As System.Windows.Forms.Button
End Class
