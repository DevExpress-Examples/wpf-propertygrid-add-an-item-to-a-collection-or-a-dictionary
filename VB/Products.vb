Imports System.Collections.Generic

Namespace pgrid_collection

    Public Class Supplier
        Public Property FirstName() As String
        Public Property LastName() As String
        Public Property Phone() As String
    End Class

    Public Class SupplierBase
        Inherits List(Of Supplier)

        Public Sub New()
            MyBase.New()
        End Sub
    End Class

    Public Class Product
        Public Property ProductName() As String
        Public Property Country() As String
        Public Property City() As String
        Public Property UnitPrice() As Double
        Public Property Quantity() As Integer
        Public Property Suppliers() As SupplierBase
    End Class

    Public Class ProductList
        Inherits List(Of Product)

        Public Sub New()
            MyBase.New()
            Add(New Product() With { _
                .ProductName = "Chang", _
                .Country = "UK", _
                .City = "Cowes", _
                .UnitPrice = 19, _
                .Quantity = 10, _
                .Suppliers = New SupplierBase() _
            })
            Add(New Product() With { _
                .ProductName = "Gravad lax", _
                .Country = "Italy", _
                .City = "Reggio Emilia", _
                .UnitPrice = 12.5, _
                .Quantity = 16, _
                .Suppliers = New SupplierBase() _
            })
            Add(New Product() With { _
                .ProductName = "Ravioli Angelo", _
                .Country = "Brazil", _
                .City = "Rio de Janeiro", _
                .UnitPrice = 19, _
                .Quantity = 12, _
                .Suppliers = New SupplierBase() _
            })
            Add(New Product() With { _
                .ProductName = "Tarte au sucre", _
                .Country = "Germany", _
                .City = "QUICK-Stop", _
                .UnitPrice = 22, _
                .Quantity = 50, _
                .Suppliers = New SupplierBase() _
            })
            Add(New Product() With { _
                .ProductName = "Steeleye Stout", _
                .Country = "USA", _
                .City = "Reggio Emilia", _
                .UnitPrice = 18, _
                .Quantity = 20, _
                .Suppliers = New SupplierBase() _
            })
            Add(New Product() With { _
                .ProductName = "Pavlova", _
                .Country = "Austria", _
                .City = "Graz", _
                .UnitPrice = 21, _
                .Quantity = 52, _
                .Suppliers = New SupplierBase() _
            })
            Add(New Product() With { _
                .ProductName = "Longlife Tofu", _
                .Country = "USA", _
                .City = "Boise", _
                .UnitPrice = 7.75, _
                .Quantity = 120, _
                .Suppliers = New SupplierBase() _
            })
            Add(New Product() With { _
                .ProductName = "Alice Mutton", _
                .Country = "Canada", _
                .City = "Tsawwassen", _
                .UnitPrice = 44, _
                .Quantity = 16, _
                .Suppliers = New SupplierBase() _
            })
        End Sub
    End Class
End Namespace
