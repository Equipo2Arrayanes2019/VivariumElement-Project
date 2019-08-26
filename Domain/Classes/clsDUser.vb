Imports Entities
Imports Persistence

Public Class clsDUser
    'Creamos una función para tomar el dato retornado por la persistencia y retornamos nuevamente el valor.
    Public Function userLogin(usr As clsEUser) As Boolean
        Dim vreturn As Boolean
        Dim clsPU As New clsPUser()
        vreturn = clsPU.userLogin(usr)
        Return vreturn
    End Function

End Class