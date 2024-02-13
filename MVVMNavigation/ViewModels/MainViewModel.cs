using CommunityToolkit.Mvvm.ComponentModel;

namespace MVVMNavigation.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    public bool isHovering;
    public string Greeting => "Welcome to Avalonia!";
}
