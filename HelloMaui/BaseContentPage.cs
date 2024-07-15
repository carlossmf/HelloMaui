using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;


namespace HelloMaui;

public abstract class BaseContentPage : ContentPage
{
    public BaseContentPage()
    {
        On<iOS>().SetUseSafeArea(true);
    }
}