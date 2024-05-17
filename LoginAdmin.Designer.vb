<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginAdmin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.keluar = New System.Windows.Forms.Button()
        Me.login = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaShell
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 169)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(99, -52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(302, 282)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.SeaShell
        Me.Label2.Location = New System.Drawing.Point(39, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.Label3.ForeColor = System.Drawing.Color.SeaShell
        Me.Label3.Location = New System.Drawing.Point(39, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.Label4.ForeColor = System.Drawing.Color.SeaShell
        Me.Label4.Location = New System.Drawing.Point(162, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.Label5.ForeColor = System.Drawing.Color.SeaShell
        Me.Label5.Location = New System.Drawing.Point(162, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = ":"
        '
        'username
        '
        Me.username.BackColor = System.Drawing.Color.SeaShell
        Me.username.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!)
        Me.username.ForeColor = System.Drawing.Color.Black
        Me.username.Location = New System.Drawing.Point(193, 264)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(246, 28)
        Me.username.TabIndex = 6
        '
        'password
        '
        Me.password.BackColor = System.Drawing.Color.SeaShell
        Me.password.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!)
        Me.password.ForeColor = System.Drawing.Color.Black
        Me.password.Location = New System.Drawing.Point(193, 309)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.password.Size = New System.Drawing.Size(246, 28)
        Me.password.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.0!)
        Me.Label6.ForeColor = System.Drawing.Color.SeaShell
        Me.Label6.Location = New System.Drawing.Point(40, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "*Silahkan login terlebih dahulu"
        '
        'keluar
        '
        Me.keluar.BackColor = System.Drawing.Color.MidnightBlue
        Me.keluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keluar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keluar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!)
        Me.keluar.ForeColor = System.Drawing.Color.White
        Me.keluar.Location = New System.Drawing.Point(255, 447)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(89, 38)
        Me.keluar.TabIndex = 10
        Me.keluar.Text = "Keluar"
        Me.keluar.UseVisualStyleBackColor = False
        '
        'login
        '
        Me.login.BackColor = System.Drawing.Color.SeaShell
        Me.login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!)
        Me.login.ForeColor = System.Drawing.Color.MidnightBlue
        Me.login.Location = New System.Drawing.Point(350, 447)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(89, 38)
        Me.login.TabIndex = 11
        Me.login.Text = "Log In"
        Me.login.UseVisualStyleBackColor = False
        '
        'LoginAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(482, 518)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.keluar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "LoginAdmin"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents keluar As System.Windows.Forms.Button
    Friend WithEvents login As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
