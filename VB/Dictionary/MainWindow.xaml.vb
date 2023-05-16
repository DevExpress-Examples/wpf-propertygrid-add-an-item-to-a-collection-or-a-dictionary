Imports DevExpress.Xpf.PropertyGrid
Imports System.Windows
Imports System.Windows.Controls

Namespace pgrid_dictionary

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = New ProductList()
        End Sub

        Private Sub pGrid_CellValueChanged(ByVal sender As Object, ByVal args As CellValueChangedEventArgs)
            Dim rowhandle = Me.grid.GetSelectedRowHandles()(0)
            Me.grid.RefreshRow(rowhandle)
        End Sub
    End Class
End Namespace
