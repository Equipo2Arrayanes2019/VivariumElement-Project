<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblLUser = New System.Windows.Forms.Label()
        Me.lblLPassword = New System.Windows.Forms.Label()
        Me.txtLUser = New System.Windows.Forms.TextBox()
        Me.txtLPassword = New System.Windows.Forms.TextBox()
        Me.cboxShowPassword = New System.Windows.Forms.CheckBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.imgLClose = New System.Windows.Forms.PictureBox()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgLogo
        '
        Me.imgLogo.Image = CType(resources.GetObject("imgLogo.Image"), System.Drawing.Image)
        Me.imgLogo.Location = New System.Drawing.Point(9, 10)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(225, 81)
        Me.imgLogo.TabIndex = 0
        Me.imgLogo.TabStop = False
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblLogin.ForeColor = System.Drawing.Color.Green
        Me.lblLogin.Location = New System.Drawing.Point(298, 106)
        Me.lblLogin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(262, 44)
        Me.lblLogin.TabIndex = 0
        Me.lblLogin.Text = "Iniciar Sesión"
        '
        'lblLUser
        '
        Me.lblLUser.AutoSize = True
        Me.lblLUser.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblLUser.ForeColor = System.Drawing.Color.Green
        Me.lblLUser.Location = New System.Drawing.Point(53, 211)
        Me.lblLUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLUser.Name = "lblLUser"
        Me.lblLUser.Size = New System.Drawing.Size(126, 36)
        Me.lblLUser.TabIndex = 1
        Me.lblLUser.Text = "Usuario"
        '
        'lblLPassword
        '
        Me.lblLPassword.AutoSize = True
        Me.lblLPassword.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblLPassword.ForeColor = System.Drawing.Color.Green
        Me.lblLPassword.Location = New System.Drawing.Point(53, 298)
        Me.lblLPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLPassword.Name = "lblLPassword"
        Me.lblLPassword.Size = New System.Drawing.Size(178, 36)
        Me.lblLPassword.TabIndex = 2
        Me.lblLPassword.Text = "Contraseña"
        '
        'txtLUser
        '
        Me.txtLUser.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtLUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.txtLUser.Location = New System.Drawing.Point(310, 211)
        Me.txtLUser.Name = "txtLUser"
        Me.txtLUser.Size = New System.Drawing.Size(314, 37)
        Me.txtLUser.TabIndex = 3
        '
        'txtLPassword
        '
        Me.txtLPassword.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtLPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.txtLPassword.Location = New System.Drawing.Point(310, 298)
        Me.txtLPassword.Name = "txtLPassword"
        Me.txtLPassword.Size = New System.Drawing.Size(314, 37)
        Me.txtLPassword.TabIndex = 4
        Me.txtLPassword.UseSystemPasswordChar = True
        '
        'cboxShowPassword
        '
        Me.cboxShowPassword.AutoSize = True
        Me.cboxShowPassword.Location = New System.Drawing.Point(310, 346)
        Me.cboxShowPassword.Name = "cboxShowPassword"
        Me.cboxShowPassword.Size = New System.Drawing.Size(118, 17)
        Me.cboxShowPassword.TabIndex = 5
        Me.cboxShowPassword.Text = "Mostrar Contraseña"
        Me.cboxShowPassword.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.ForestGreen
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnLogin.Location = New System.Drawing.Point(398, 392)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(144, 54)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Ingresar"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'imgLClose
        '
        Me.imgLClose.Image = CType(resources.GetObject("imgLClose.Image"), System.Drawing.Image)
        Me.imgLClose.Location = New System.Drawing.Point(9, 485)
        Me.imgLClose.Name = "imgLClose"
        Me.imgLClose.Size = New System.Drawing.Size(50, 50)
        Me.imgLClose.TabIndex = 7
        Me.imgLClose.TabStop = False
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(796, 547)
        Me.ControlBox = False
        Me.Controls.Add(Me.imgLClose)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.cboxShowPassword)
        Me.Controls.Add(Me.txtLPassword)
        Me.Controls.Add(Me.txtLUser)
        Me.Controls.Add(Me.lblLPassword)
        Me.Controls.Add(Me.lblLUser)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.imgLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgLogo As PictureBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblLUser As Label
    Friend WithEvents lblLPassword As Label
    Friend WithEvents txtLUser As TextBox
    Friend WithEvents txtLPassword As TextBox
    Friend WithEvents cboxShowPassword As CheckBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents imgLClose As PictureBox
End Class
