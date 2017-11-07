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

    Function CalcPrice(ByVal Width As Single, ByVal Length As Single, ByVal Price As Decimal) As Double

        Dim dblTotalPrice As Double

        dblTotalPrice = (Width * Length) * Price

        Return dblTotalPrice

    End Function

    Function CalcPrice(ByVal Width As Single, ByVal Length As Single, ByVal Price As String) As Double

        Dim dblTotalPrice As Double

        dblTotalPrice = (Width * Length) * CDbl(Price)

        Return dblTotalPrice

    End Function

    Function CalcPrice(ByVal Width As Single, ByVal Length As Single, ByVal Price As Decimal, ByVal DiscountCode As String) As Double

        Dim dblTotalPrice As Double

        dblTotalPrice = ((Width * Length) * Price) * CDbl(DiscountCode)

        Return dblTotalPrice

    End Function


End Class
