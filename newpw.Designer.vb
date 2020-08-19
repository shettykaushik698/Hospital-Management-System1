<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newpw
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
        Me.btnexit = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtnp = New System.Windows.Forms.TextBox
        Me.txtcp = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbluser = New System.Windows.Forms.Label
        Me.showpw = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'btnexit
        '
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexit.Location = New System.Drawing.Point(333, 210)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(148, 28)
        Me.btnexit.TabIndex = 0
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Location = New System.Drawing.Point(73, 210)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(140, 28)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 107)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "New Password :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 159)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Confirm Password :"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.BurlyWood
        Me.Label3.Font = New System.Drawing.Font("Bodoni MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, -1)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(601, 41)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SET YOUR NEW PASSWORD"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtnp
        '
        Me.txtnp.Location = New System.Drawing.Point(184, 107)
        Me.txtnp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnp.Name = "txtnp"
        Me.txtnp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnp.Size = New System.Drawing.Size(275, 22)
        Me.txtnp.TabIndex = 5
        '
        'txtcp
        '
        Me.txtcp.Location = New System.Drawing.Point(184, 159)
        Me.txtcp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcp.Name = "txtcp"
        Me.txtcp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcp.Size = New System.Drawing.Size(275, 22)
        Me.txtcp.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(119, 66)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "User :"
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Location = New System.Drawing.Point(193, 66)
        Me.lbluser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(34, 16)
        Me.lbluser.TabIndex = 9
        Me.lbluser.Text = "user"
        '
        'showpw
        '
        Me.showpw.AutoSize = True
        Me.showpw.BackColor = System.Drawing.Color.Transparent
        Me.showpw.BackgroundImage = Global.ex1.My.Resources.Resources.eye1
        Me.showpw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.showpw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.showpw.Location = New System.Drawing.Point(489, 135)
        Me.showpw.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.showpw.Name = "showpw"
        Me.showpw.Size = New System.Drawing.Size(51, 20)
        Me.showpw.TabIndex = 33
        Me.showpw.Text = "        "
        Me.showpw.UseVisualStyleBackColor = False
        '
        'newpw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 267)
        Me.Controls.Add(Me.showpw)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcp)
        Me.Controls.Add(Me.txtnp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnexit)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "newpw"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "newpw"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnp As System.Windows.Forms.TextBox
    Friend WithEvents txtcp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents showpw As System.Windows.Forms.CheckBox
End Class
