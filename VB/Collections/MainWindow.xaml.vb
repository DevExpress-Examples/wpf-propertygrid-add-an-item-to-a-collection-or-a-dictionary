Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.PropertyGrid

Namespace pgrid_collection
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits ThemedWindow
        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = New ProductList()
        End Sub
        Private Sub XamlInitializer_Initialize(ByVal sender As Object, ByVal e As InstanceInitializeEventArgs)
            e.Instance.FirstName = "FIRSTNAME"
            e.Instance.LastName = "LASTNAME"
            e.Instance.Phone = "PHONE"
        End Sub
        Private Sub pGrid_CellValueChanged(ByVal sender As Object, ByVal args As CellValueChangedEventArgs)
            Dim rowhandle = Me.grid.GetSelectedRowHandles()(0)
            Me.grid.RefreshRow(rowhandle)
        End Sub
    End Class
End Namespace
