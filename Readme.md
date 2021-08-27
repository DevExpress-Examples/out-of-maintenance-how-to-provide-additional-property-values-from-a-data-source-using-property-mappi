<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576768/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T289947)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/PropertyMappingsSample/Form1.cs) (VB: [Form1.vb](./VB/PropertyMappingsSample/Form1.vb))**
<!-- default file list end -->
# How to provide additional property values from a data source using property mappings


This example demonstrates how to provide values for the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapRectangle_Widthtopic">Width</a> and <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapRectangle_Heighttopic">Height</a> properties of <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapMapRectangletopic">MapRectangle</a> from a data source using <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument17870">Property Mappings</a>.


<h3>Description</h3>

To do this, create instances of the&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapMapRectangleWidthMappingtopic">MapRectangleWidthMapping</a>&nbsp;and&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapMapRectangleHeightMappingtopic">MapRectangleHeightMapping</a>&nbsp;classes, specify their properties and add&nbsp;them to the <a href="https://documentation.devexpress.com/#windowsforms/DevExpressXtraMapDataSourceAdapterBase_PropertyMappingstopic">DataSourceAdapterBase.PropertyMappings</a>&nbsp;collection.

<br/>


