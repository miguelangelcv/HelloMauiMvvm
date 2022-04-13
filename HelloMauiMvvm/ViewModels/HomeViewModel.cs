using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HelloMauiMvvm.Services;

namespace HelloMauiMvvm.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        private readonly ISampleService _sampleService;

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

        [ICommand]
        void RandomName()
        {
            FirstName = _sampleService.GetRandomString();
            LastName = "Developer";
        }

        public HomeViewModel()
        {
            _sampleService = DependencyService.Get<ISampleService>();

            FirstName = ".NET";
            LastName = "Developer";
        }
    }
}