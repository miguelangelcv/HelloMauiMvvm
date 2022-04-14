using HelloMauiMvvm.ViewModels;

namespace HelloMauiMvvm.Services
{
    public interface INavigationService
    {
        Task NavigateBackAsync();
        Task NavigateToAsync(Type viewModelType);
        Task NavigateToAsync(Type viewModelType, object parameter);
        Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase;
        Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase;
    }
}