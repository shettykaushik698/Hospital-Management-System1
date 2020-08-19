<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cpass
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblid = New System.Windows.Forms.Label
        Me.txtop = New System.Windows.Forms.TextBox
        Me.txtnp = New System.Windows.Forms.TextBox
        Me.txtcp = New System.Windows.Forms.TextBox
        Me.btnchange = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.showpw = New System.Windows.Forms.CheckBox
        Me.lbleid = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-15, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(501, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CHANGE PASSWORD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 176)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Old Password :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 228)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "New Password :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 284)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Confirm Password :"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(154, 126)
        Me.lblid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(33, 18)
        Me.lblid.TabIndex = 5
        Me.lblid.Text = "-----"
        '
        'txtop
        '
        Me.txtop.Location = New System.Drawing.Point(159, 172)
        Me.txtop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtop.Name = "txtop"
        Me.txtop.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtop.Size = New System.Drawing.Size(199, 24)
        Me.txtop.TabIndex = 6
        '
        'txtnp
        '
        Me.txtnp.Location = New System.Drawing.Point(159, 224)
        Me.txtnp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnp.Name = "txtnp"
        Me.txtnp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnp.Size = New System.Drawing.Size(199, 24)
        Me.txtnp.TabIndex = 7
        '
        'txtcp
        '
        Me.txtcp.Location = New System.Drawing.Point(159, 280)
        Me.txtcp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcp.Name = "txtcp"
        Me.txtcp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcp.Size = New System.Drawing.Size(199, 24)
        Me.txtcp.TabIndex = 8
        '
        'btnchange
        '
        Me.btnchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnchange.Location = New System.Drawing.Point(148, 350)
        Me.btnchange.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnchange.Name = "btnchange"
        Me.btnchange.Size = New System.Drawing.Size(201, 32)
        Me.btnchange.TabIndex = 9
        Me.btnchange.Text = "Change Password"
        Me.btnchange.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.ex1.My.Resources.Resources.Button_Previous_icon
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(56, 345)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 37)
        Me.Button2.TabIndex = 10
        Me.Button2.UseVisualStyleBackColor = False
        '
        'showpw
        '
        Me.showpw.AutoSize = True
        Me.showpw.BackColor = System.Drawing.Color.Transparent
        Me.showpw.BackgroundImage = Global.ex1.My.Resources.Resources.eye1
        Me.showpw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.showpw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.showpw.Location = New System.Drawing.Point(388, 228)
        Me.showpw.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.showpw.Name = "showpw"
        Me.showpw.Size = New System.Drawing.Size(59, 22)
        Me.showpw.TabIndex = 34
        Me.showpw.Text = "        "
        Me.showpw.UseVisualStyleBackColor = False
        '
        'lbleid
        '
        Me.lbleid.AutoSize = True
        Me.lbleid.Location = New System.Drawing.Point(162, 76)
        Me.lbleid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbleid.Name = "lbleid"
        Me.lbleid.Size = New System.Drawing.Size(23, 18)
        Me.lbleid.TabIndex = 35
        Me.lbleid.Text = "---"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(87, 126)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 18)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Name :"
        '
        'cpass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 415)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbleid)
        Me.Controls.Add(Me.showpw)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnchange)
        Me.Controls.Add(Me.txtcp)
        Me.Controls.Add(Me.txtnp)
        Me.Controls.Add(Me.txtop)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "cpass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cpass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents txtop As System.Windows.Forms.TextBox
    Friend WithEvents txtnp As System.Windows.Forms.TextBox
    Friend WithEvents txtcp As System.Windows.Forms.TextBox
    Friend WithEvents btnchange As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents showpw As System.Windows.Forms.CheckBox
    Friend WithEvents lbleid As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
