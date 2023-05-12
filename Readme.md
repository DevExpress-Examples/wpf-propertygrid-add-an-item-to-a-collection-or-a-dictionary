<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128655103/23.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4855)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF PropertyGrid - Add an Item to a Collection or a Dictionary

This example demonstrates how to implement a collection editing feature. With this feature, users can add items to a collection or a dictionary.

The image below illustrates user actions:

![Add an item to a collection](images/add-item.gif)

Set one of the following properties to `true` to allow users to add new items to the collection:

* [PropertyGridControl.UseCollectionEditor](https://docs.devexpress.com/WPF/DevExpress.Xpf.PropertyGrid.PropertyGridControl.UseCollectionEditor) - Toggles collection editing for the entire property grid.

* [CollectionDefinition.UseCollectionEditor](https://docs.devexpress.com/WPF/DevExpress.Xpf.PropertyGrid.CollectionDefinition.UseCollectionEditor) - Toggles collection editing for individual collections.
  
```xaml
<dxprg:CollectionDefinition UseCollectionEditor="True" >
```

## Implementation Details

The project includes the following examples:

* _Collection_ - Demonstrates how to add an item to a collection.
* _Dictionary_ - Demonstrates how to add an item to a dictionary.

### The Collection Example

Use the [XamlInitializer](https://docs.devexpress.com/WPF/DevExpress.Xpf.PropertyGrid.XamlInitializer) class to allow users to add an item to a collection.

1. Add the `XamlInitializer` class to the `Window.Resources` section.

```xml
<Window.Resources>
    <ResourceDictionary>
        <dxprg:XamlInitializer Initialize="XamlInitializer_Initialize" x:Key="xamlInitializer" />
    </ResourceDictionary>
</Window.Resources>
```

2. Specify the [TypeDefinition](https://docs.devexpress.com/WPF/DevExpress.Xpf.PropertyGrid.TypeDefinition) items.

```xml
<dxprg:XamlInitializer Initialize="XamlInitializer_Initialize" x:Key="xamlInitializer">
    <dxprg:TypeDefinition Type="{x:Type local:Supplier}"  Name="Supplier" Description="New Supplier"/>
</dxprg:XamlInitializer>
```

3. In the [XamlInitializer.Initialize](https://docs.devexpress.com/WPF/DevExpress.Xpf.PropertyGrid.XamlInitializer.Initialize) event handler, set the initial values for the new object's properties.

```csharp
private void XamlInitializer_Initialize(object sender, InstanceInitializeEventArgs e) {
    e.Instance.FirstName = "FIRSTNAME";
    e.Instance.LastName = "LASTNAME";
    e.Instance.Phone = "PHONE";
}
```

### The Dictionary Example

Use the [Property attributes](https://docs.devexpress.com/WPF/15623/controls-and-libraries/property-grid/property-attributes) to allow users to add items to a dictionary.

A dictionary key for a new item should be unique. In this example, the `DictionaryKey1Attribute` class creates a unique key for a new item. You can create your own attribute class to generate a unique key.

1. Add a `DictionaryKey1Attribute` class that inherits from the `DevExpress.Mvvm.DataAnnotations.NewItemInstanceInitializerAttribute` class.

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

2. Add the attribute to the dictionary property.

```csharp
[DictionaryKey1()]
public IDictionary<string, Supplier> Tags { get; set; } = new Dictionary<string, Supplier>();
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
