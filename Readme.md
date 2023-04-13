<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128655103/23.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4855)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF PropertyGrid - Add an Object with Predefined Property Values to a Collection

This example demonstrates how to implement a collection editing feature and allow users to add an item to a collection or a dictionary. Set one of these properties to `true` to allow users to add new items to the collection:

* [PropertyGridControl.UseCollectionEditor](https://docs.devexpress.com/WPF/DevExpress.Xpf.PropertyGrid.PropertyGridControl.UseCollectionEditor).
  
  Toggles collection editing for the entire property grid.

* [CollectionDefinition.UseCollectionEditor](https://docs.devexpress.com/WPF/DevExpress.Xpf.PropertyGrid.CollectionDefinition.UseCollectionEditor).
  
  Toggles collection editing for individual collections.
  
```xaml
<dxprg:CollectionDefinition UseCollectionEditor="True" >
```
This image illustrates how to add an item to a collection:

![Add an item to a collection](images/add-item.gif)

## Implementation Details

The project includes the following examples:

* _Collection_. This example demonstrates how to add an item to a collection.
* _Dictionary_. This example demonstrates how to add an item to a dictionary.

The _Collection_ example implements the [XamlInitializer](https://docs.devexpress.com/WPF/DevExpress.Xpf.PropertyGrid.XamlInitializer) class allows you to use XAML to add items to a collection. Add the [XamlInitializer](https://docs.devexpress.com/WPF/DevExpress.Xpf.PropertyGrid.XamlInitializer) instance to the `Window.Resources` and specify the [TypeDefinition](https://docs.devexpress.com/WPF/DevExpress.Xpf.PropertyGrid.TypeDefinition) items that an end-user can add to a collection.

```xml
<Window.Resources>
    <ResourceDictionary>
        <dxprg:XamlInitializer Initialize="XamlInitializer_Initialize" x:Key="xamlInitializer">
            <dxprg:TypeDefinition Type="{x:Type local:Supplier}"  Name="Supplier" Description="New Supplier"/>
        </dxprg:XamlInitializer>
    </ResourceDictionary>
</Window.Resources>
```

Add an event handler to the [XamlInitializer.Initialize](https://docs.devexpress.com/WPF/DevExpress.Xpf.PropertyGrid.XamlInitializer.Initialize) event to set the initial values for the new object's properties.

```csharp
private void XamlInitializer_Initialize(object sender, InstanceInitializeEventArgs e) {
    e.Instance.FirstName = "FIRSTNAME";
    e.Instance.LastName = "LASTNAME";
    e.Instance.Phone = "PHONE";
}
```

The _Dictionary_ example implements the [Property attributes](https://docs.devexpress.com/WPF/15623/controls-and-libraries/property-grid/property-attributes) and the `DevExpress.Mvvm.DataAnnotations.NewItemInstanceInitializerAttribute` class to add items to a dictionary. Add an attribute to the IDictionary property in the `Products` class.

```csharp
[DictionaryKey1()]
public IDictionary<string, Supplier> Tags { get; set; } = new Dictionary<string, Supplier>();
```

Add a `DictionaryKeyAttribute` class that inherits from the `NewItemInstanceInitializerAttribute` class.

```csharp
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
```

## Documentation

* [Collection Editing](https://docs.devexpress.com/WPF/15719/controls-and-libraries/property-grid/property-definitions/collection-definitions#collection-editing)
* [XamlInitializer](https://docs.devexpress.com/WPF/DevExpress.Xpf.PropertyGrid.XamlInitializer)

<!-- default file list -->
## Files to Review

_Collections_ example:

* [MainWindow.xaml](./CS/Collections/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/Collections/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/Collections/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/Collections/MainWindow.xaml.vb))
* [Products.cs](./CS/Collections/Products.cs) (VB: [Products.vb](./VB/Collections/Products.vb))

_Dictionary_ example:

* [MainWindow.xaml](./CS/Dictionary/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/Dictionary/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/Dictionary/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/Dictionary/MainWindow.xaml.vb))
* [Products.cs](./CS/Dictionary/Products.cs) (VB: [Products.vb](./VB/Dictionary/Products.vb))

<!-- default file list end -->
