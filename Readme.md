<!-- default file list -->
*Files to look at*:

* [CylindricalMapProjectionsTestPage.aspx](./CS/CylindricalMapProjections.Web/CylindricalMapProjectionsTestPage.aspx) (VB: [CylindricalMapProjectionsTestPage.aspx](./VB/CylindricalMapProjections.Web/CylindricalMapProjectionsTestPage.aspx))
* [MainPage.xaml](./CS/CylindricalMapProjections/MainPage.xaml) (VB: [MainPage.xaml](./VB/CylindricalMapProjections/MainPage.xaml))
* [MainPage.xaml.cs](./CS/CylindricalMapProjections/MainPage.xaml.cs) (VB: [MainPage.xaml](./VB/CylindricalMapProjections/MainPage.xaml))
<!-- default file list end -->
# How to provide cylindrical equal-area projections of a map


<p>This example illustrates how to get map equal-area projections (Lambert, Behrmann, Tristan Edwards, Peters and Balthasart) for the shapes loaded from the Shapefiles (<strong>Countries.shp</strong>, <strong>Countries.dbf</strong>).</p><p>To accomplish this task, create an <a href="http://help.devexpress.com/#Silverlight/clsDevExpressXpfMapEqualAreaProjectiontopic"><u>EqualAreaProjection</u></a> object and assign it to the <a href="http://help.devexpress.com/#Silverlight/DevExpressXpfMapVectorLayerBase_MapProjectiontopic"><u>VectorLayerBase.MapProjection</u></a> property. Then, specify the Width/height aspect ratio for each equal area projection using the <a href="http://help.devexpress.com/#Silverlight/DevExpressXpfMapVectorLayerBase_InitialMapSizetopic"><u>VectorLayerBase.InitialMapSize</u></a> property. </p><p>To learn more about the equal-area projections, see <a href="http://en.wikipedia.org/wiki/Cylindrical_equal-area_projection"><u>Cylindrical equal-area projection</u></a>. </p><p><br />
</p>

<br/>


