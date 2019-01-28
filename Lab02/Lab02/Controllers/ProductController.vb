Imports System.Web.Mvc

Namespace Controllers
    Public Class ProductController
        Inherits Controller

        ' GET: Product
        Function Index() As String
            Return "Product/Index is displayed"
        End Function

        ' GET: Products/Browse
        Function Browse() As String
            Return "Browse is displayed"
        End Function

        ' GET: Products/Details/105
        Function Details() As String
            Return "Details displayed for id=105 "
        End Function

        ' GET: Products/Location?zip=44124
        Function Location() As String
            Return "Location displayed for zip=44124"
        End Function

    End Class
End Namespace