Imports Entities
Imports Domain
Public Class frmVE
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se cambia el nombre de la ventana por Log In
        Me.Text = "Montes del Plata - Log In"
        'Se ajusta el panel del Login para que ocupe toda la ventana
        loginPanel.Dock = DockStyle.Fill
        'Se oculta el panel de Gerente General, ya que al no estar logueado. No debe ser mostrado.
        generalmgrPanel.Hide()
        'También se oculta el panel de los datos del Usuario. (Por lo mismo que lo anterior)
        unmPanel.Hide()
        'Se oculta el botón de Logout (Por lo mismo que las dos anteriores).
        imgLogOut.Hide()
        'Se lleva el panel de la cabecera hacia adelante.
        headerPanel.BringToFront()
        'Se le da un valor máximo para poder escribir a los TextBox, así coincide con la base de datos.
        txtLUser.MaxLength = 10
    End Sub
    Private Sub cboxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cboxShowPassword.CheckedChanged
        'Se crea una condición para que la contraseña sea mostrada o ocultada.
        If txtLPassword.UseSystemPasswordChar = True Then
            'mostrar contraseña
            txtLPassword.UseSystemPasswordChar = False
        Else
            'ocultar contraseña
            txtLPassword.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub txtLPassword_Enter() Handles txtLPassword.Enter
        'Al hacer focus con el tabulador, se selecciona todo el contenido del TextBox de la contraseña.
        txtLPassword.SelectAll()
    End Sub

    Private Sub cboxShowPassword_MouseDown(ByVal sender As Object, ByVal e As EventArgs) Handles cboxShowPassword.MouseDown
        'Mientras se mantenga presionado el click, se mostrará la contraseña.
        cboxShowPassword.CheckState = CheckState.Checked
    End Sub

    Private Sub cboxShowPassword_MouseUp(ByVal sender As Object, ByVal e As EventArgs) Handles cboxShowPassword.MouseUp
        'Cuando se suelte el clic, se volverá a ocultar la contraseña
        cboxShowPassword.CheckState = CheckState.Unchecked
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Creamos una nueva variable de tipo clsEUser
        Dim user As clsEUser = New clsEUser()
        'Le damos el valor a la variable user con los datos ingresados por el usuario
        user.userName = txtLUser.Text
        user.userPassword = txtLPassword.Text
        'Creamos una nueva variable de tipo clsDUser
        Dim clsDom As New clsDUser
        'Aquí creamos una condición la cual comparará una variable de tipo booleana retornada por el dominio
        'y se basa en que si la persistencia encontró el usuario en la base de datos y la contraseña coincide
        'con ese usuario, el usuario será logueado y se le mostrará su panel de usuario.
        'y si no es correcto, se le mostrarán los errores correspondientes
        Dim vreturn As Boolean = clsDom.userLogin(user)
        If (vreturn = True) Then
            MessageBox.Show("Logueo exitoso")
            'Si el logueo fue exitoso, cambiamos al panel de Gerente General.
            Me.Text = "Montes del Plata - Gerente General"
            loginPanel.Hide()
            generalmgrPanel.Dock = DockStyle.Fill
            generalmgrPanel.Show()
            unmPanel.Show()
            imgLogOut.Show()
            txtLUser.Text = ""
            txtLPassword.Text = ""
        Else
            'Aquí se crearán nuevas condiciones para los distintos tipos de errores.
            '1- Si los campos de usuario y contraseña están vacíos, se mostrará un error relacionado a ello
            '2- Si el campo de usuario está vacío, se mostrará un error relacionado a ello
            '3- Si el campo de contraseña está vacío, se mostrará un error relacionado a ello
            '4- Si los dos campos son erroneos, se mostrará un error relacionado a ello.
            If (txtLUser.Text = "" And txtLPassword.Text = "") Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                MessageBox.Show("Los campos están vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf (txtLUser.Text = "") Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                MessageBox.Show("El campo de usuario está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf (txtLPassword.Text = "") Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                MessageBox.Show("El campo de la contraseña está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                MessageBox.Show("Introduce los datos correctamente", "Usuario y/o contraseña incorrecto/s", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtLUser.Text = ""
                txtLPassword.Text = ""
                txtLUser.Focus()
            End If
        End If
    End Sub

    Private Sub imgLClose_Click(sender As Object, e As EventArgs) Handles imgLClose.Click
        'Al dar click al botón con la cruz, se cerrará el programa.
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles horayfecha.Tick
        'Se les dará valores de Hora y Fecha a los Labels correspondientes gracias al Control Timer.
        'La hora y la fecha se adapta automáticamente a la hora y fecha del ordenador.
        lblTime.Text = Date.Now.ToString("HH:MM")
        lblDate.Text = Date.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub imgLogOut_Click(sender As Object, e As EventArgs) Handles imgLogOut.Click
        'Al dar click al botón con una flecha hacia la izquierda, se desconectará la sesión del usuario
        'y se mostrará denuevo el panel de logueo.
        loginPanel.Show()
        generalmgrPanel.Hide()
        unmPanel.Hide()
        imgLogOut.Hide()
    End Sub
End Class
