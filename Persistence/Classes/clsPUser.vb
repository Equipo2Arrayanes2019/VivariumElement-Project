Imports Entities
Imports MySql.Data.MySqlClient

Public Class clsPUser
    Inherits clsPersistence
    Public Function userLogin(usr As clsEUser) As Boolean
        Dim query1 As String
        Dim results As MySqlDataReader
        Dim vreturn As Boolean
        query1 = "SELECT * FROM tbl_usuarios WHERE nombre='" & usr.userName & "' AND clave='" & usr.userPassword & "';"
        results = ejecutarYdevolver(query1)
        If (results.HasRows() = False) Then
            vreturn = False
        ElseIf (results.HasRows() = True) Then
            vreturn = True
        End If
        Return vreturn
    End Function
End Class

