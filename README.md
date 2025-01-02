# How to Customize the Legend Layout in .NET MAUI Pyramid Chart
This article provides a detailed walkthrough on how to customize the legend layout in [.NET MAUI Pyramid Chart](https://www.syncfusion.com/maui-controls/maui-pyramid-charts).

The [SfPyramidChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html) supports [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Legend) functionality, allowing you to enhance chart visualization by presenting chart data items in a legend. The layout of the legend can be customized using the [ItemsLayout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_ItemsLayout) property in [ChartLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html) class.

The Legend includes following properties:
* [IsVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_IsVisible) - Gets or sets a value that indicates whether the legend is visible or not.
* [Placement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_Placement) - Gets or sets the placement for the legend in a chart.
* [ToggleSeriesVisibility](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_ToggleSeriesVisibility) - Gets or sets a value indicating whether the chart series visibility by tapping the legend item.
* [ItemsLayout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_ItemsLayout) - Gets or sets the layout configuration for the items in the chart legend.
* [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_ItemTemplate) - Gets or sets a template to customize the appearance of each legend item.
* [LabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_LabelStyle) - Gets or sets the value to customize the appearance of chart legend labels.

Learn step-by-step instructions and gain insights to customize the legend layout.

**Step 1:** Initialize the [SfPyramidChart](https://help.syncfusion.com/maui/pyramid-charts/getting-started) and add the title to it as follows.

**XAML**

 ```xml
<chart:SfPyramidChart ItemsSource="{Binding Data}"
                      XBindingPath="Stage"
                      YBindingPath="Value"
                      GapRatio="0.1"
                      PaletteBrushes="{Binding CustomBrushes}">

    <chart:SfPyramidChart.Title>
        <Label Text="Social Media Sharing" FontSize="17" FontAttributes="Bold" HorizontalTextAlignment="Center"/>
    </chart:SfPyramidChart.Title>

</chart:SfPyramidChart> 
 ```

**C#**

```csharp
SfPyramidChart chart = new SfPyramidChart()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "Stage",
    YBindingPath = "Value",
    GapRatio = 0.1,
    PaletteBrushes = new ViewModel().CustomBrushes
};

chart.Title = new Label
{
    Text = "Social Media Sharing",
    FontSize = 17,
    FontAttributes = FontAttributes.Bold,
    HorizontalTextAlignment = TextAlignment.Center
}; 
 ```
 
**Step 2:** Initialize the LegendExt class by inheriting from the [ChartLegend](https://help.syncfusion.com/maui/pyramid-charts/legend) class. Enhance the [ChartLegend](https://help.syncfusion.com/maui/pyramid-charts/legend) functionality by overriding the [GetMaximumSizeCoefficient](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_GetMaximumSizeCoefficient) method to limit the legend's maximum size and utilize the UniformItemsLayout in the [ItemsLayout](https://help.syncfusion.com/maui/pyramid-charts/legend#items-layout) property to organize legend items into rows and columns.

**XAML**
 
 ```xml
<chart:SfPyramidChart>

    ......

    <chart:SfPyramidChart.Legend>
        <local:LegendExt Placement="Right">
            <local:LegendExt.ItemsLayout>
                <local:UniformLayouts MaxRows="12" MaxColumns="4" WidthRequest="600" FlowDirection="LeftToRight" />
            </local:LegendExt.ItemsLayout>
            <local:LegendExt.ItemTemplate>
                .....
            </local:LegendExt.ItemTemplate>
        </local:LegendExt>
    </chart:SfPyramidChart.Legend>

</chart:SfPyramidChart> 
 ```

**C#**

```csharp
SfPyramidChart chart = new SfPyramidChart()
{
    ......
};

var legendExt = new LegendExt
{
    Placement = LegendPlacement.Right,
    ItemsLayout = new UniformLayouts
    {
        MaxRows = 12,
        MaxColumns = 4,
        WidthRequest = 600,
        FlowDirection = FlowDirection.LeftToRight
    },
    ItemTemplate = new DataTemplate(() =>
    {
       ......
    })
};

chart.Legend = legendExt;

this.Content = chart; 
 ```
 
**C#**
 
 ```csharp
public class LegendExt:ChartLegend
{
    protected override double GetMaximumSizeCoefficient()
    {
        return 0.7;
    }
} 

public class UniformLayouts : UniformItemsLayout
{

}
 ```
 

**Output:**

![CustomizeLegendLayout](https://github.com/user-attachments/assets/ab4c09a8-7760-4707-8f4a-6f838fd5c6c7)

