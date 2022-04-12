using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HelloMauiMvvm.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(CountInfo))]
        int _count;

        [ObservableProperty]
        string _countInfo = "Current count: 0";

        [ICommand]
        void Counter() => Count += 1;
    }
}