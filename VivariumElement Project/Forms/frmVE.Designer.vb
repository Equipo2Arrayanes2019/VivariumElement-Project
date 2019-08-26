<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVE
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVE))
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblLUser = New System.Windows.Forms.Label()
        Me.lblLPassword = New System.Windows.Forms.Label()
        Me.txtLUser = New System.Windows.Forms.TextBox()
        Me.txtLPassword = New System.Windows.Forms.TextBox()
        Me.cboxShowPassword = New System.Windows.Forms.CheckBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.imgLClose = New System.Windows.Forms.PictureBox()
        Me.loginPanel = New System.Windows.Forms.Panel()
        Me.generalmgrPanel = New System.Windows.Forms.Panel()
        Me.btnRegUser = New System.Windows.Forms.Button()
        Me.btnVivariumStatus = New System.Windows.Forms.Button()
        Me.btnShowGraphics = New System.Windows.Forms.Button()
        Me.btnViewLots = New System.Windows.Forms.Button()
        Me.headerPanel = New System.Windows.Forms.Panel()
        Me.unmPanel = New System.Windows.Forms.Panel()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.imgPanelMenu = New System.Windows.Forms.PictureBox()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.datetimePanel = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.horayfecha = New System.Windows.Forms.Timer(Me.components)
        Me.imgLogOut = New System.Windows.Forms.PictureBox()
        CType(Me.imgLClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.loginPanel.SuspendLayout()
        Me.generalmgrPanel.SuspendLayout()
        Me.headerPanel.SuspendLayout()
        Me.unmPanel.SuspendLayout()
        CType(Me.imgPanelMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.datetimePanel.SuspendLayout()
        CType(Me.imgLogOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.Transparent
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
        Me.lblLUser.BackColor = System.Drawing.Color.Transparent
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
        Me.lblLPassword.BackColor = System.Drawing.Color.Transparent
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
        Me.cboxShowPassword.TabStop = False
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
        'loginPanel
        '
        Me.loginPanel.Controls.Add(Me.btnLogin)
        Me.loginPanel.Controls.Add(Me.cboxShowPassword)
        Me.loginPanel.Controls.Add(Me.txtLPassword)
        Me.loginPanel.Controls.Add(Me.txtLUser)
        Me.loginPanel.Controls.Add(Me.lblLPassword)
        Me.loginPanel.Controls.Add(Me.lblLUser)
        Me.loginPanel.Controls.Add(Me.lblLogin)
        Me.loginPanel.Location = New System.Drawing.Point(12, 63)
        Me.loginPanel.Name = "loginPanel"
        Me.loginPanel.Size = New System.Drawing.Size(190, 109)
        Me.loginPanel.TabIndex = 8
        '
        'generalmgrPanel
        '
        Me.generalmgrPanel.Controls.Add(Me.btnRegUser)
        Me.generalmgrPanel.Controls.Add(Me.btnVivariumStatus)
        Me.generalmgrPanel.Controls.Add(Me.btnShowGraphics)
        Me.generalmgrPanel.Controls.Add(Me.btnViewLots)
        Me.generalmgrPanel.Location = New System.Drawing.Point(289, 63)
        Me.generalmgrPanel.Name = "generalmgrPanel"
        Me.generalmgrPanel.Size = New System.Drawing.Size(209, 93)
        Me.generalmgrPanel.TabIndex = 9
        Me.generalmgrPanel.Visible = False
        '
        'btnRegUser
        '
        Me.btnRegUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRegUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRegUser.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegUser.Location = New System.Drawing.Point(-219, 109)
        Me.btnRegUser.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegUser.Name = "btnRegUser"
        Me.btnRegUser.Size = New System.Drawing.Size(220, 80)
        Me.btnRegUser.TabIndex = 18
        Me.btnRegUser.Text = "Crear nuevo usuario"
        Me.btnRegUser.UseVisualStyleBackColor = False
        '
        'btnVivariumStatus
        '
        Me.btnVivariumStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnVivariumStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVivariumStatus.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVivariumStatus.Location = New System.Drawing.Point(199, -83)
        Me.btnVivariumStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVivariumStatus.Name = "btnVivariumStatus"
        Me.btnVivariumStatus.Size = New System.Drawing.Size(220, 80)
        Me.btnVivariumStatus.TabIndex = 17
        Me.btnVivariumStatus.Text = "Ver estado del vivero"
        Me.btnVivariumStatus.UseVisualStyleBackColor = False
        '
        'btnShowGraphics
        '
        Me.btnShowGraphics.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnShowGraphics.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnShowGraphics.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowGraphics.Location = New System.Drawing.Point(199, 109)
        Me.btnShowGraphics.Margin = New System.Windows.Forms.Padding(2)
        Me.btnShowGraphics.Name = "btnShowGraphics"
        Me.btnShowGraphics.Size = New System.Drawing.Size(220, 80)
        Me.btnShowGraphics.TabIndex = 19
        Me.btnShowGraphics.Text = "Mostrar gráficas"
        Me.btnShowGraphics.UseVisualStyleBackColor = False
        '
        'btnViewLots
        '
        Me.btnViewLots.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnViewLots.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnViewLots.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewLots.Location = New System.Drawing.Point(-219, -83)
        Me.btnViewLots.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewLots.Name = "btnViewLots"
        Me.btnViewLots.Size = New System.Drawing.Size(220, 80)
        Me.btnViewLots.TabIndex = 16
        Me.btnViewLots.Text = "Ver estado de lotes"
        Me.btnViewLots.UseVisualStyleBackColor = False
        '
        'headerPanel
        '
        Me.headerPanel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.headerPanel.Controls.Add(Me.unmPanel)
        Me.headerPanel.Controls.Add(Me.imgLogo)
        Me.headerPanel.Controls.Add(Me.datetimePanel)
        Me.headerPanel.Location = New System.Drawing.Point(0, 0)
        Me.headerPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.headerPanel.Name = "headerPanel"
        Me.headerPanel.Size = New System.Drawing.Size(796, 58)
        Me.headerPanel.TabIndex = 1
        '
        'unmPanel
        '
        Me.unmPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.unmPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.unmPanel.Controls.Add(Me.lblUserName)
        Me.unmPanel.Controls.Add(Me.imgPanelMenu)
        Me.unmPanel.Location = New System.Drawing.Point(604, 1)
        Me.unmPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.unmPanel.Name = "unmPanel"
        Me.unmPanel.Size = New System.Drawing.Size(192, 57)
        Me.unmPanel.TabIndex = 10
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Cambria", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(3, 15)
        Me.lblUserName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(119, 22)
        Me.lblUserName.TabIndex = 1
        Me.lblUserName.Text = "Jose Ramirez"
        '
        'imgPanelMenu
        '
        Me.imgPanelMenu.InitialImage = Nothing
        Me.imgPanelMenu.Location = New System.Drawing.Point(124, 6)
        Me.imgPanelMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.imgPanelMenu.Name = "imgPanelMenu"
        Me.imgPanelMenu.Size = New System.Drawing.Size(38, 46)
        Me.imgPanelMenu.TabIndex = 0
        Me.imgPanelMenu.TabStop = False
        '
        'imgLogo
        '
        Me.imgLogo.Image = CType(resources.GetObject("imgLogo.Image"), System.Drawing.Image)
        Me.imgLogo.Location = New System.Drawing.Point(16, 6)
        Me.imgLogo.Margin = New System.Windows.Forms.Padding(2)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(159, 50)
        Me.imgLogo.TabIndex = 6
        Me.imgLogo.TabStop = False
        '
        'datetimePanel
        '
        Me.datetimePanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.datetimePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.datetimePanel.Controls.Add(Me.lblDate)
        Me.datetimePanel.Controls.Add(Me.lblTime)
        Me.datetimePanel.Location = New System.Drawing.Point(299, 0)
        Me.datetimePanel.Margin = New System.Windows.Forms.Padding(2)
        Me.datetimePanel.Name = "datetimePanel"
        Me.datetimePanel.Size = New System.Drawing.Size(210, 57)
        Me.datetimePanel.TabIndex = 8
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(34, 26)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(67, 26)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "Fecha"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(71, 1)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(59, 26)
        Me.lblTime.TabIndex = 7
        Me.lblTime.Text = "Hora"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'horayfecha
        '
        Me.horayfecha.Enabled = True
        '
        'imgLogOut
        '
        Me.imgLogOut.Image = CType(resources.GetObject("imgLogOut.Image"), System.Drawing.Image)
        Me.imgLogOut.Location = New System.Drawing.Point(71, 485)
        Me.imgLogOut.Name = "imgLogOut"
        Me.imgLogOut.Size = New System.Drawing.Size(50, 50)
        Me.imgLogOut.TabIndex = 10
        Me.imgLogOut.TabStop = False
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(796, 547)
        Me.ControlBox = False
        Me.Controls.Add(Me.imgLogOut)
        Me.Controls.Add(Me.imgLClose)
        Me.Controls.Add(Me.generalmgrPanel)
        Me.Controls.Add(Me.loginPanel)
        Me.Controls.Add(Me.headerPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vivarium Element"
        CType(Me.imgLClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.loginPanel.ResumeLayout(False)
        Me.loginPanel.PerformLayout()
        Me.generalmgrPanel.ResumeLayout(False)
        Me.headerPanel.ResumeLayout(False)
        Me.unmPanel.ResumeLayout(False)
        Me.unmPanel.PerformLayout()
        CType(Me.imgPanelMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.datetimePanel.ResumeLayout(False)
        Me.datetimePanel.PerformLayout()
        CType(Me.imgLogOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblLUser As Label
    Friend WithEvents lblLPassword As Label
    Friend WithEvents txtLUser As TextBox
    Friend WithEvents txtLPassword As TextBox
    Friend WithEvents cboxShowPassword As CheckBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents imgLClose As PictureBox
    Friend WithEvents loginPanel As Panel
    Friend WithEvents generalmgrPanel As Panel
    Friend WithEvents btnRegUser As Button
    Friend WithEvents btnVivariumStatus As Button
    Friend WithEvents btnShowGraphics As Button
    Friend WithEvents btnViewLots As Button
    Friend WithEvents headerPanel As Panel
    Friend WithEvents unmPanel As Panel
    Friend WithEvents lblUserName As Label
    Friend WithEvents imgPanelMenu As PictureBox
    Friend WithEvents imgLogo As PictureBox
    Friend WithEvents datetimePanel As Panel
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents horayfecha As Timer
    Friend WithEvents imgLogOut As PictureBox
End Class
