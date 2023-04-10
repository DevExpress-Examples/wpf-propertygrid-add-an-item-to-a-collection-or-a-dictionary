using DevExpress.Xpf.Core;
using DevExpress.Xpf.PropertyGrid;
using System.Windows.Controls;

namespace pgrid_collection {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow {
        public MainWindow() {
            InitializeComponent();
            grid.ItemsSource = new ProductList();
        }
        private void XamlInitializer_Initialize(object sender, InstanceInitializeEventArgs e) {
            e.Instance.FirstName = "FIRSTNAME";
            e.Instance.LastName = "LASTNAME";
            e.Instance.Phone = "PHONE";
        }
        private void pGrid_CellValueChanged(object sender, CellValueChangedEventArgs args) {
            var rowhandle = grid.GetSelectedRowHandles()[0];
            grid.RefreshRow(rowhandle);
        }
    }
}
