using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HelloMauiMvvm.Services;

namespace HelloMauiMvvm.ViewModels
{
    public partial class HomeViewModel : ViewModelBase
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
        void GoToSecond() => NavigationService.Instance.NavigateToAsync<SecondViewModel>(FullName);

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