Public Class Excepcion
    Inherits Exception
    Private Const _mensaje_predeterminado As String = "Ha ocurrido algo, contacte con el soporte técnico."

    Public Sub New()
        MyBase.New(_mensaje_predeterminado)
    End Sub

    Public Sub New(message As String)
        MyBase.New(message)
    End Sub

    Public Sub New(message As String, inner As Exception)
        MyBase.New(message, inner)
    End Sub
End Class
