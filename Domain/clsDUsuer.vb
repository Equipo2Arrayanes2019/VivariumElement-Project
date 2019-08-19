Imports Entities
Imports Persistence

Public Class clsDUsuer

    Public Function userLogin(usr As clsEUser) As Boolean
        Dim vreturn As Boolean
        Dim clsPU As New clsPUser()
        vreturn = clsPU.userLogin(usr)
        Return vreturn
    End Function

End Class
