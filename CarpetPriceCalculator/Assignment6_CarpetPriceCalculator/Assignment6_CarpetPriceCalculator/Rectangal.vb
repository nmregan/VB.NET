Public Class Rectangal

    Private intWidth As Integer
    Private intLength As Integer
    Private intArea As Integer

    Public Property Width() As Integer
        Get
            Return intWidth
        End Get
        Set(ByVal value As Integer)
            intWidth = value
        End Set
    End Property

    Public Property Length() As Integer
        Get
            Return intLength
        End Get
        Set(ByVal value As Integer)
            intLength = value
        End Set
    End Property

    Public Property Area() As Integer
        Get
            Return intArea
        End Get
        Set(ByVal value As Integer)
            intArea = value
        End Set
    End Property


    Function GetArea() As Integer

        Return intWidth * intLength

    End Function


End Class
