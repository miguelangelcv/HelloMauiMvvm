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
        [NotifyPropertyChangedFor(nameof(FullName))]
        string _firstName;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        string _lastName;

        public string FullName => $"{FirstName} {LastName}".Trim();

        [RelayCommand]
        void Counter() => Count += 1;

        [RelayCommand]
        void GoToSecond() => NavigationService.Instance.NavigateToAsync<SecondViewModel>(FullName);

        [RelayCommand]
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