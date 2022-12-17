<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128655103/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4855)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
* [Products.cs](./CS/Products.cs) (VB: [Products.vb](./VB/Products.vb))
<!-- default file list end -->
# How to: Add an Object with Predefined Property Values using the Collection Editor


<p>The DXPropertyGrid supports adding new objects to collections using the <a href="https://documentation.devexpress.com/#WPF/CustomDocument15719">collection editor</a>. To pre-set certain properties for a new object or create an object without the default constructor, use the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridCollectionDefinition_NewItemInitializertopic">CollectionDefinition.NewItemInitializer</a> property. Like <a href="https://www.devexpress.com/Support/Center/p/T135069">PropertyDefinitionBase.InstanceInitializer</a>, it should be set to an object that implements the <strong>DevExpress.Mvvm.Native.IInstanceInitializer</strong> interface.</p>

<br/>


