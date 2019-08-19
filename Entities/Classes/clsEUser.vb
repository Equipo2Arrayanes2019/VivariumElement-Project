Public Class clsEUser
    Private mUserName, mUserPassword, mUserId, mUserType As String
    Public Property userName As String
        Get
            Return mUserName
        End Get
        Set(value As String)
            mUserName = value
        End Set
    End Property
    Public Property userPassword As String
        Get
            Return mUserPassword
        End Get
        Set(value As String)
            mUserPassword = value
        End Set
    End Property
    Public Property userId As String
        Get
            Return mUserId
        End Get
        Set(value As String)
            mUserId = value
        End Set
    End Property
    Public Property userType As String
        Get
            Return mUserType
        End Get
        Set(value As String)
            mUserType = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(usName As String, usPass As String, usId As String, usType As String)
        userName = usName
        userPassword = userPassword
        userId = usId
        userType = usType
    End Sub

End Class
