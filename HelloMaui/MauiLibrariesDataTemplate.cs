using CommunityToolkit.Maui.Markup;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;
using Microsoft.Maui.Controls.Shapes;


namespace HelloMaui;
public class MauiLibrariesDataTemplate : DataTemplate
{
    const int imageRadius = 25; 
    const int imagePadding = 8;
    public MauiLibrariesDataTemplate() : base(() => CreateTemplate())
    {
        
    }

    static Grid CreateTemplate() => new()
    {
        RowDefinitions = Rows.Define(
            (Row.Title, 22),
            (Row.Description, 44),
            (Row.BottomPadding, 8)),
            
       ColumnDefinitions = Columns.Define(
           (Column.Icon, (imageRadius * 2) + (imagePadding *2)),
           (Column.Text, Auto)),
           
        RowSpacing = 4,
           
        Children =
        {
            new Image()
                .Row(Row.Title).RowSpan(2)
                .Column(Column.Icon)
                .Center()
                .Aspect(Aspect.AspectFit)
                .Size(imageRadius * 2)
                .Bind(Image.SourceProperty,
                    getter: static (LibraryModel model) => model.ImageSource,
                    mode: BindingMode.OneWay),
            new Label()
                .Row(Row.Title).Column(Column.Text)
                .Font(size: 18, bold: true)
                .TextTop()
                .TextStart()
                .Bind(Label.TextProperty,
                    getter: static (LibraryModel model) => model.Title,
                    mode: BindingMode.OneWay),
            
            new Label()
                .Row(Row.Description).Column(Column.Text)
                .Font(size: 12)
                .TextTop()
                .TextStart()
                .Bind(Label.TextProperty,
                    getter: (LibraryModel model) => model.Description,
                    mode: BindingMode.OneWay),
        }   

    };
    
    enum Column { Icon, Text}
    enum Row { Title, Description, BottomPadding}
}