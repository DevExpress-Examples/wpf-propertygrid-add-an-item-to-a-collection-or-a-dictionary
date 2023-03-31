using DevExpress.Mvvm.Native;
using System.Collections.Generic;
using System.Windows;
using DevExpress.Xpf.PropertyGrid;

namespace pgrid_collection {

    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            grid.ItemsSource = new ProductList();
        }

        private void pGrid_CellValueChanged(object sender, CellValueChangedEventArgs args) {
            var rowhandle = grid.GetSelectedRowHandles()[0];
            grid.RefreshRow(rowhandle);
        }

        private void XamlInitializer_Initialize(object sender, InstanceInitializeEventArgs e) {
            e.Instance.FirstName = "FIRSTNAME";
            e.Instance.LastName = "LASTNAME";
            e.Instance.Phone = "PHONE";
        }
    }
}
