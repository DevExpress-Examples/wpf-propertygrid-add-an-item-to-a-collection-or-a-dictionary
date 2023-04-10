using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.PropertyGrid.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace pgrid_dictionary {
    public class Supplier {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
    }
    public class Product {
        public string ProductName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }

        [DictionaryKey1()]
        public IDictionary<string, Supplier> Tags { get; set; } = new Dictionary<string, Supplier>();
    }
    public class DictionaryKey1Attribute : NewItemInstanceInitializerAttribute {
        public DictionaryKey1Attribute() : base(typeof(Supplier)) { }
        public override KeyValuePair<object, object>? CreateInstance(ITypeDescriptorContext context, IEnumerable dictionary) {
            var testObject = ((DescriptorContext)context).Value as IDictionary<string, Supplier>;
            int key = testObject.Keys.Count;
            while(testObject.Keys.Contains(key.ToString()))
                key++;
            return new KeyValuePair<object, object>(key.ToString(), new Supplier());
        }
    }
    public class ProductList : List<Product> {
        public ProductList()
            : base() {
            Add(new Product() { ProductName = "Chang", Country = "UK", City = "Cowes", UnitPrice = 19, Quantity = 10 });
            Add(new Product() { ProductName = "Gravad lax", Country = "Italy", City = "Reggio Emilia", UnitPrice = 12.5, Quantity = 16 });
            Add(new Product() { ProductName = "Ravioli Angelo", Country = "Brazil", City = "Rio de Janeiro", UnitPrice = 19, Quantity = 12 });
            Add(new Product() { ProductName = "Tarte au sucre", Country = "Germany", City = "QUICK-Stop", UnitPrice = 22, Quantity = 50 });
            Add(new Product() { ProductName = "Steeleye Stout", Country = "USA", City = "Reggio Emilia", UnitPrice = 18, Quantity = 20 });
            Add(new Product() { ProductName = "Pavlova", Country = "Austria", City = "Graz", UnitPrice = 21, Quantity = 52 });
            Add(new Product() { ProductName = "Longlife Tofu", Country = "USA", City = "Boise", UnitPrice = 7.75, Quantity = 120 });
            Add(new Product() { ProductName = "Alice Mutton", Country = "Canada", City = "Tsawwassen", UnitPrice = 44, Quantity = 16 });
        }
    }
}
