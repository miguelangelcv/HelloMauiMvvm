using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HelloMauiMvvm.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        [ObservableProperty]
        int _count;

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(FullName))]
        string _firstName;

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(FullName))]
        string _lastName;

        public string FullName => $"{FirstName} {LastName}".Trim();

        [ICommand]
        void Counter() => Count += 1;

        public HomeViewModel()
        {
            FirstName = ".NET";
            LastName = "Developer";
        }
    }
}