Imports Entities
Imports MySql.Data.MySqlClient

Public Class clsPUser
    Inherits clsPersistence
    'Creamos una función de tipo Booleana, la cual retornará un valor de tipo clsEUser.
    'Dicha función tomará los datos enviados por la Entidad y hará una consulta a la base de datos
    'la cual, buscará si los datos ingresados existen en la misma.
    Public Function userLogin(usr As clsEUser) As Boolean
        'creamos una variable de tipo String para la consulta.
        Dim query1 As String
        'Creamos una variable de tipo MySqlDataReader, la cual ejecutará la función ejecutarYdevolver
        'con los datos de la consulta (variable query1).
        Dim results As MySqlDataReader
        'Creamos una variable de tipo booleana, la cual retornará los valores de la consulta
        Dim vreturn As Boolean
        'Le damos el valor a la variable query1 con un código propio de MySQL.
        query1 = "SELECT * FROM tbl_usuarios WHERE nombre='" & usr.userName & "' AND clave='" & usr.userPassword & "';"
        'Le damos un valor a la variable results ejecutando la función mencionada anteriormente.
        results = ejecutarYdevolver(query1)
        'Creamos una condición, la cual se le dará un valor a la variable vreturn dependiendo si es verdadero o falso.
        If (results.HasRows() = False) Then
            vreturn = False
        ElseIf (results.HasRows() = True) Then
            vreturn = True
        End If
        'Retornamos el valor.
        Return vreturn
    End Function
End Class

