Public Class Customer
    Dim name As String
    Dim adress As String
    Dim mobileNumber As String
    Dim month As Integer
    Dim year As Integer
    Dim minutes As Integer
    Dim texts As Integer
    Dim data As Integer
    Public Sub New()

    End Sub


    Public Function setName(name As String)
        Me.name = name
    End Function

    Public Function getName()
        Return Me.name
    End Function

    Public Function setAdress(adress As String)
        Me.adress = adress
    End Function

    Public Function getAdress()
        Return Me.adress
    End Function
    Public Function setmonth(month As Integer)
        Me.month = month
    End Function

    Public Function getMonth()
        Return Me.month
    End Function
    Public Function setminutes(minutes As String)
        Me.minutes = minutes
    End Function
    Public Function setMobileNumber(mobileNumber As String)
        Me.mobileNumber = mobileNumber
    End Function
    Public Function GetMobileNumber()
        Return Me.mobileNumber
    End Function

End Class
