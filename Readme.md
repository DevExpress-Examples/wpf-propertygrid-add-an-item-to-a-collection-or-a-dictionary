<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [Products.cs](./CS/Products.cs) (VB: [Products.vb](./VB/Products.vb))
<!-- default file list end -->
# How to: Add an Object with Predefined Property Values using the Collection Editor


<p>The DXPropertyGrid supports adding new objects to collections using the <a href="https://documentation.devexpress.com/#WPF/CustomDocument15719">collection editor</a>. To pre-set certain properties for a new object or create an object without the default constructor, use the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridCollectionDefinition_NewItemInitializertopic">CollectionDefinition.NewItemInitializer</a> property. Like <a href="https://www.devexpress.com/Support/Center/p/T135069">PropertyDefinitionBase.InstanceInitializer</a>, it should be set to an object that implements the <strong>DevExpress.Mvvm.Native.IInstanceInitializer</strong> interface.</p>

<br/>


