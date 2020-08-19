<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scandis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scandis))
        Me.lblscan = New System.Windows.Forms.Label
        Me.btndone = New System.Windows.Forms.Button
        Me.btnattend = New System.Windows.Forms.Button
        Me.scandisplay = New System.Windows.Forms.DataGridView
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnrefresh = New System.Windows.Forms.Button
        CType(Me.scandisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblscan
        '
        Me.lblscan.BackColor = System.Drawing.Color.CadetBlue
        Me.lblscan.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscan.Location = New System.Drawing.Point(-3, 0)
        Me.lblscan.Name = "lblscan"
        Me.lblscan.Size = New System.Drawing.Size(785, 30)
        Me.lblscan.TabIndex = 0
        Me.lblscan.Text = "Scan Appointments"
        Me.lblscan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btndone
        '
        Me.btndone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndone.Location = New System.Drawing.Point(467, 292)
        Me.btndone.Name = "btndone"
        Me.btndone.Size = New System.Drawing.Size(102, 23)
        Me.btndone.TabIndex = 34
        Me.btndone.Text = "Scan Finished"
        Me.btndone.UseVisualStyleBackColor = True
        '
        'btnattend
        '
        Me.btnattend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnattend.Location = New System.Drawing.Point(196, 292)
        Me.btnattend.Name = "btnattend"
        Me.btnattend.Size = New System.Drawing.Size(98, 23)
        Me.btnattend.TabIndex = 31
        Me.btnattend.Text = "Attend"
        Me.btnattend.UseVisualStyleBackColor = True
        '
        'scandisplay
        '
        Me.scandisplay.AllowUserToAddRows = False
        Me.scandisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.scandisplay.Location = New System.Drawing.Point(12, 46)
        Me.scandisplay.MultiSelect = False
        Me.scandisplay.Name = "scandisplay"
        Me.scandisplay.ReadOnly = True
        Me.scandisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.scandisplay.Size = New System.Drawing.Size(756, 218)
        Me.scandisplay.TabIndex = 36
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
        Me.btncancel.Location = New System.Drawing.Point(12, 283)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(40, 40)
        Me.btncancel.TabIndex = 35
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnrefresh
        '
        Me.btnrefresh.BackgroundImage = CType(resources.GetObject("btnrefresh.BackgroundImage"), System.Drawing.Image)
        Me.btnrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnrefresh.FlatAppearance.BorderSize = 0
        Me.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrefresh.Location = New System.Drawing.Point(79, 283)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(41, 40)
        Me.btnrefresh.TabIndex = 32
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'scandis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 335)
        Me.Controls.Add(Me.scandisplay)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btndone)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btnattend)
        Me.Controls.Add(Me.lblscan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "scandis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "scandis"
        CType(Me.scandisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblscan As System.Windows.Forms.Label
    Friend WithEvents btndone As System.Windows.Forms.Button
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents btnattend As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents scandisplay As System.Windows.Forms.DataGridView
End Class
