Imports Entities
Imports Domain
Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub cboxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cboxShowPassword.CheckedChanged
        If txtLPassword.UseSystemPasswordChar = True Then
            'mostrar contraseña
            txtLPassword.UseSystemPasswordChar = False
        Else
            'ocultar contraseña
            txtLPassword.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub txtLPassword_Enter() Handles txtLPassword.Enter
        txtLPassword.SelectAll()
    End Sub

    Private Sub cboxShowPassword_MouseDown(ByVal sender As Object, ByVal e As EventArgs) Handles cboxShowPassword.MouseDown
        cboxShowPassword.CheckState = CheckState.Checked
    End Sub

    Private Sub cboxShowPassword_MouseUp(ByVal sender As Object, ByVal e As EventArgs) Handles cboxShowPassword.MouseUp
        cboxShowPassword.CheckState = CheckState.Unchecked
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user As clsEUser = New clsEUser()
        user.userName = txtLUser.Text
        user.userPassword = txtLPassword.Text
        Dim clsDom As New clsDUser
        Dim vreturn As Boolean = clsDom.userLogin(user)
        If (vreturn = True) Then
            MessageBox.Show("Logueo exitoso")
            'Dim siguienteFormulario As New frmInicio
            'siguienteFormulario.Show()
            'Me.Hide()
        Else
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MessageBox.Show("Introduce los datos correctamente", "Usuario y/o contraseña incorrecto/s", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLUser.Text = ""
            txtLPassword.Text = ""
            txtLUser.Focus()
        End If
    End Sub

    Private Sub imgLClose_Click(sender As Object, e As EventArgs) Handles imgLClose.Click
        Me.Close()
    End Sub
End Class
