using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace avalonia_learning.Views;

public partial class MusicStoreWindow : Window
{
    public MusicStoreWindow()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}