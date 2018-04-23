Imports System.Collections.Generic
Imports System.Windows
Imports DevExpress.Mvvm.Native
Imports DevExpress.Xpf.PropertyGrid

Namespace pgrid_collection

    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            grid.ItemsSource = New ProductList()
        End Sub

        Private Sub pGrid_CellValueChanged(ByVal sender As Object, ByVal args As DevExpress.Xpf.PropertyGrid.CellValueChangedEventArgs)
            Dim rowhandle = grid.GetSelectedRowHandles()(0)
            grid.RefreshRow(rowhandle)
        End Sub
    End Class
    Public Class ItemInitializer
        Implements IInstanceInitializer

        Public Sub New()
        End Sub

        Private Function IInstanceInitializer_CreateInstance(ByVal type As TypeInfo) As Object Implements IInstanceInitializer.CreateInstance
            Dim item = New Supplier()
            item.FirstName = "FIRSTNAME"
            item.LastName = "LASTNAME"
            item.Phone = "PHONE"
            Return item
        End Function


        Private ReadOnly Property IInstanceInitializer_Types() As IEnumerable(Of TypeInfo) Implements IInstanceInitializer.Types
            Get
                Return New List(Of TypeInfo)() From {New TypeInfo(GetType(Supplier), "New Supplier")}
            End Get
        End Property
    End Class
End Namespace
