using CommunityToolkit.Mvvm.ComponentModel;

namespace HelloMauiMvvm.ViewModels
{
    // Source: https://github.com/jsuarezruiz
    public class ViewModelBase : ObservableObject
    {
        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
    }
}
