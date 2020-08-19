<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.btnlogin = New System.Windows.Forms.Button
        Me.txtpw = New System.Windows.Forms.TextBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbltype = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnhelp = New System.Windows.Forms.Button
        Me.showpw = New System.Windows.Forms.CheckBox
        Me.btncancel = New System.Windows.Forms.Button
        Me.txtid = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.Transparent
        Me.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogin.Location = New System.Drawing.Point(304, 235)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(160, 37)
        Me.btnlogin.TabIndex = 1
        Me.btnlogin.Text = "Log In"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'txtpw
        '
        Me.txtpw.Location = New System.Drawing.Point(237, 171)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpw.Size = New System.Drawing.Size(301, 27)
        Me.txtpw.TabIndex = 2
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.Location = New System.Drawing.Point(21, 306)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(235, 20)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forgot password/Account blocked"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(156, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "User ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(146, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password :"
        '
        'lbltype
        '
        Me.lbltype.BackColor = System.Drawing.Color.Transparent
        Me.lbltype.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltype.Location = New System.Drawing.Point(232, -1)
        Me.lbltype.Name = "lbltype"
        Me.lbltype.Size = New System.Drawing.Size(181, 42)
        Me.lbltype.TabIndex = 33
        Me.lbltype.Text = "LOG IN"
        Me.lbltype.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnhelp
        '
        Me.btnhelp.BackColor = System.Drawing.Color.Transparent
        Me.btnhelp.BackgroundImage = Global.ex1.My.Resources.Resources.Button_Help_icon
        Me.btnhelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnhelp.FlatAppearance.BorderSize = 0
        Me.btnhelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhelp.Location = New System.Drawing.Point(595, 296)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(33, 31)
        Me.btnhelp.TabIndex = 34
        Me.ToolTip1.SetToolTip(Me.btnhelp, "Help")
        Me.btnhelp.UseVisualStyleBackColor = False
        '
        'showpw
        '
        Me.showpw.AutoSize = True
        Me.showpw.BackColor = System.Drawing.Color.Transparent
        Me.showpw.BackgroundImage = Global.ex1.My.Resources.Resources.eye1
        Me.showpw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.showpw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.showpw.Location = New System.Drawing.Point(575, 174)
        Me.showpw.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.showpw.Name = "showpw"
        Me.showpw.Size = New System.Drawing.Size(60, 24)
        Me.showpw.TabIndex = 32
        Me.showpw.Text = "        "
        Me.showpw.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.Transparent
        Me.btncancel.BackgroundImage = Global.ex1.My.Resources.Resources.Button_Previous_icon
        Me.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancel.FlatAppearance.BorderSize = 0
        Me.btncancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Location = New System.Drawing.Point(16, 23)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(31, 30)
        Me.btncancel.TabIndex = 0
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'txtid
        '
        Me.txtid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtid.Location = New System.Drawing.Point(237, 118)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(301, 27)
        Me.txtid.TabIndex = 35
        '
        'login
        '
        Me.AcceptButton = Me.btnlogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ex1.My.Resources.Resources.OSZB6Y0
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(655, 351)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btnhelp)
        Me.Controls.Add(Me.lbltype)
        Me.Controls.Add(Me.showpw)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.txtpw)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.btncancel)
        Me.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "log"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents txtpw As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents showpw As System.Windows.Forms.CheckBox
    Friend WithEvents lbltype As System.Windows.Forms.Label
    Friend WithEvents btnhelp As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtid As System.Windows.Forms.TextBox
End Class
