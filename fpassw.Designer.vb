<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fpassw
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcid = New System.Windows.Forms.TextBox
        Me.txtcuid = New System.Windows.Forms.TextBox
        Me.txtcnp = New System.Windows.Forms.TextBox
        Me.txtccp = New System.Windows.Forms.TextBox
        Me.btnok = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnuid = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 79)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "user id :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 127)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "unique key :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 171)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "new password :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 220)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "confirm password :"
        '
        'txtcid
        '
        Me.txtcid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcid.Location = New System.Drawing.Point(220, 71)
        Me.txtcid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcid.Name = "txtcid"
        Me.txtcid.Size = New System.Drawing.Size(164, 30)
        Me.txtcid.TabIndex = 4
        '
        'txtcuid
        '
        Me.txtcuid.Location = New System.Drawing.Point(220, 127)
        Me.txtcuid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcuid.Name = "txtcuid"
        Me.txtcuid.Size = New System.Drawing.Size(164, 30)
        Me.txtcuid.TabIndex = 5
        '
        'txtcnp
        '
        Me.txtcnp.Location = New System.Drawing.Point(220, 171)
        Me.txtcnp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcnp.Name = "txtcnp"
        Me.txtcnp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcnp.Size = New System.Drawing.Size(164, 30)
        Me.txtcnp.TabIndex = 6
        '
        'txtccp
        '
        Me.txtccp.Location = New System.Drawing.Point(220, 220)
        Me.txtccp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtccp.Name = "txtccp"
        Me.txtccp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtccp.Size = New System.Drawing.Size(164, 30)
        Me.txtccp.TabIndex = 7
        '
        'btnok
        '
        Me.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnok.Location = New System.Drawing.Point(74, 287)
        Me.btnok.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(171, 39)
        Me.btnok.TabIndex = 8
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(353, 287)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(179, 39)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(431, 203)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(143, 26)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "show password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Coral
        Me.Label5.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-3, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(603, 48)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Forgot Password"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnuid
        '
        Me.btnuid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnuid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnuid.Location = New System.Drawing.Point(431, 102)
        Me.btnuid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnuid.Name = "btnuid"
        Me.btnuid.Size = New System.Drawing.Size(136, 70)
        Me.btnuid.TabIndex = 12
        Me.btnuid.Text = "Request Unique key"
        Me.btnuid.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Coral
        Me.Label6.Location = New System.Drawing.Point(-6, 346)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(621, 27)
        Me.Label6.TabIndex = 13
        '
        'fpassw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(599, 365)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnuid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.txtccp)
        Me.Controls.Add(Me.txtcnp)
        Me.Controls.Add(Me.txtcuid)
        Me.Controls.Add(Me.txtcid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "fpassw"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fpassw"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcid As System.Windows.Forms.TextBox
    Friend WithEvents txtcuid As System.Windows.Forms.TextBox
    Friend WithEvents txtcnp As System.Windows.Forms.TextBox
    Friend WithEvents txtccp As System.Windows.Forms.TextBox
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnuid As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
