Public Class Carpet

    Private strColor As String
    Private strStyle As String
    Private dblPrice As Double

    Public Property Color() As String
        Get
            Return strColor
        End Get
        Set(ByVal value As String)
            strColor = value
        End Set
    End Property

    Public Property Style() As String
        Get
            Return strStyle
        End Get
        Set(ByVal value As String)
            strStyle = value
        End Set
    End Property

    Public Property Price() As Double
        Get
            Return dblPrice
        End Get
        Set(ByVal value As Double)
            dblPrice = value
        End Set
    End Property


    Function GetColorStyle() As String

        Return strColor & ", " & strStyle

    End Function

End Class
