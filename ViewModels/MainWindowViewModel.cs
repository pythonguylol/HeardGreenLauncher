using System.Collections.ObjectModel;
using ReactiveUI;
using HeardGreenLauncher.Models;

namespace HeardGreenLauncher.ViewModels;

public class MainWindowViewModel : ReactiveObject
{
    private ObservableCollection<MinecraftVersion> _versions;
    private MinecraftVersion? _selectedVersion;
    private int _memoryGB = 2;

    public ObservableCollection<MinecraftVersion> Versions
    {
        get => _versions;
        set => this.RaiseAndSetIfChanged(ref _versions, value);
    }

    public MinecraftVersion? SelectedVersion
    {
        get => _selectedVersion;
        set => this.RaiseAndSetIfChanged(ref _selectedVersion, value);
    }

    public int MemoryGB
    {
        get => _memoryGB;
        set => this.RaiseAndSetIfChanged(ref _memoryGB, value);
    }

    public MainWindowViewModel()
    {
        _versions = new ObservableCollection<MinecraftVersion>
        {
            new MinecraftVersion { Id = "1.20.4", Type = "release", ReleaseTime = DateTime.Now },
            new MinecraftVersion { Id = "1.20.1", Type = "release", ReleaseTime = DateTime.Now.AddMonths(-2) },
            new MinecraftVersion { Id = "1.19.2", Type = "release", ReleaseTime = DateTime.Now.AddMonths(-6) }
        };
        _selectedVersion = _versions[0];
    }
}