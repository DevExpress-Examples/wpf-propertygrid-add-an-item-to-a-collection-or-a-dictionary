using DevExpress.Xpf.PropertyGrid;
using System.Windows;
using System.Windows.Controls;

namespace pgrid_dictionary {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            grid.ItemsSource = new ProductList();
        }
        private void pGrid_CellValueChanged(object sender, CellValueChangedEventArgs args) {
            var rowhandle = grid.GetSelectedRowHandles()[0];
            grid.RefreshRow(rowhandle);
        }
    }
}
