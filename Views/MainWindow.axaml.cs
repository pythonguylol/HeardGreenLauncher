using Avalonia.Controls;
using HeardGreenLauncher.ViewModels;

namespace HeardGreenLauncher.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}