using Demo_TS_WinUI.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Demo_TS_WinUI.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
