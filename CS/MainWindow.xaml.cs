using System.Collections.Generic;
using System.Windows;
using DevExpress.Mvvm.Native;
using DevExpress.Xpf.PropertyGrid;

namespace pgrid_collection {

    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            grid.ItemsSource = new ProductList();
        }

        private void pGrid_CellValueChanged(object sender, DevExpress.Xpf.PropertyGrid.CellValueChangedEventArgs args) {
            var rowhandle = grid.GetSelectedRowHandles()[0];
            grid.RefreshRow(rowhandle);
        }
    }
    public class ItemInitializer : IInstanceInitializer {
        public ItemInitializer() {
        }

        object IInstanceInitializer.CreateInstance(TypeInfo type) {
            var item = new Supplier();
            item.FirstName = "FIRSTNAME";
            item.LastName = "LASTNAME";
            item.Phone = "PHONE";
            return item;
        }


        IEnumerable<TypeInfo> IInstanceInitializer.Types {
            get {
                return new List<TypeInfo>() {
                        new TypeInfo(typeof(Supplier), "New Supplier"),
                    };
            }
        }
    }
}
