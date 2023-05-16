Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Xpf.PropertyGrid.Internal
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace pgrid_dictionary

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

        <DictionaryKey1()>
        Public Property Tags As IDictionary(Of String, Supplier) = New Dictionary(Of String, Supplier)()
    End Class

    Public Class DictionaryKey1Attribute
        Inherits NewItemInstanceInitializerAttribute

        Public Sub New()
            MyBase.New(GetType(Supplier))
        End Sub

        Public Overrides Function CreateInstance(ByVal context As ITypeDescriptorContext, ByVal dictionary As IEnumerable) As KeyValuePair(Of Object, Object)?
            Dim testObject = TryCast(CType(context, DescriptorContext).Value, IDictionary(Of String, Supplier))
            Dim key As Integer = testObject.Keys.Count
            While testObject.Keys.Contains(key.ToString())
                key += 1
            End While

            Return New KeyValuePair(Of Object, Object)(key.ToString(), New Supplier())
        End Function
    End Class

    Public Class ProductList
        Inherits List(Of Product)

        Public Sub New()
            MyBase.New()
            Add(New Product() With {.ProductName = "Chang", .Country = "UK", .City = "Cowes", .UnitPrice = 19, .Quantity = 10})
            Add(New Product() With {.ProductName = "Gravad lax", .Country = "Italy", .City = "Reggio Emilia", .UnitPrice = 12.5, .Quantity = 16})
            Add(New Product() With {.ProductName = "Ravioli Angelo", .Country = "Brazil", .City = "Rio de Janeiro", .UnitPrice = 19, .Quantity = 12})
            Add(New Product() With {.ProductName = "Tarte au sucre", .Country = "Germany", .City = "QUICK-Stop", .UnitPrice = 22, .Quantity = 50})
            Add(New Product() With {.ProductName = "Steeleye Stout", .Country = "USA", .City = "Reggio Emilia", .UnitPrice = 18, .Quantity = 20})
            Add(New Product() With {.ProductName = "Pavlova", .Country = "Austria", .City = "Graz", .UnitPrice = 21, .Quantity = 52})
            Add(New Product() With {.ProductName = "Longlife Tofu", .Country = "USA", .City = "Boise", .UnitPrice = 7.75, .Quantity = 120})
            Add(New Product() With {.ProductName = "Alice Mutton", .Country = "Canada", .City = "Tsawwassen", .UnitPrice = 44, .Quantity = 16})
        End Sub
    End Class
End Namespace
