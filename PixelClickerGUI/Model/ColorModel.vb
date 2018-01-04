Imports Newtonsoft.Json

Namespace Model
    Public Class ColorModel
        Public Sub New()
        End sub
        Private _searchColor As Integer
        Public Property SearchColor As Integer
            Get
                Return _searchColor
            End Get
            Set(value As Integer)
                Dim col As Color = Color.FromArgb(value)
                _searchColor = value

                R = Convert.ToInt32(col.R)
                G = Convert.ToInt32(col.G)
                B = Convert.ToInt32(col.B)
            End Set
        End Property
         <JsonIgnore>
        Public R As Integer
         <JsonIgnore> 
        Public G As Integer
        <JsonIgnore> 
        Public B As Integer
        
        Public Property ShadeVariation As Integer = 5
    End Class
End NameSpace