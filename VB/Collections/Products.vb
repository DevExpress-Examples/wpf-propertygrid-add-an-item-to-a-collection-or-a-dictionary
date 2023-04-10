
Imports System.Collections.Generic

Namespace pgrid_collection
    Public Class Supplier
        Public Property FirstName As String
        Public Property LastName As String
        Public Property Phone As String
    End Class
    Public Class Product
        Public Property ProductName As String
        Public Property Country As String
        Public Property City As String
        Public Property UnitPrice As Double
        Public Property Quantity As Integer
        Public Property Suppliers As List(Of Supplier) = New List(Of Supplier)()
    End Class
    Public Class ProductList
        Inherits List(Of Product)
        Public Sub New()
            MyBase.New()
            Add(New Product() With {
                .ProductName = "Chang",
                .Country = "UK",
                .City = "Cowes",
                .UnitPrice = 19,
                .Quantity = 10
            })
            Add(New Product() With {
                .ProductName = "Gravad lax",
                .Country = "Italy",
                .City = "Reggio Emilia",
                .UnitPrice = 12.5,
                .Quantity = 16
            })
            Add(New Product() With {
                .ProductName = "Ravioli Angelo",
                .Country = "Brazil",
                .City = "Rio de Janeiro",
                .UnitPrice = 19,
                .Quantity = 12
            })
            Add(New Product() With {
                .ProductName = "Tarte au sucre",
                .Country = "Germany",
                .City = "QUICK-Stop",
                .UnitPrice = 22,
                .Quantity = 50
            })
            Add(New Product() With {
                .ProductName = "Steeleye Stout",
                .Country = "USA",
                .City = "Reggio Emilia",
                .UnitPrice = 18,
                .Quantity = 20
            })
            Add(New Product() With {
                .ProductName = "Pavlova",
                .Country = "Austria",
                .City = "Graz",
                .UnitPrice = 21,
                .Quantity = 52
            })
            Add(New Product() With {
                .ProductName = "Longlife Tofu",
                .Country = "USA",
                .City = "Boise",
                .UnitPrice = 7.75,
                .Quantity = 120
            })
            Add(New Product() With {
                .ProductName = "Alice Mutton",
                .Country = "Canada",
                .City = "Tsawwassen",
                .UnitPrice = 44,
                .Quantity = 16
            })
        End Sub
    End Class
End Namespace
