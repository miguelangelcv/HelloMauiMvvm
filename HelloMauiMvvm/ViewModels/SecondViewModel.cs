using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMauiMvvm.ViewModels
{
    public partial class SecondViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _parameter;


        public override Task InitializeAsync(object navigationData)
        {
            Parameter = navigationData as string;

            return base.InitializeAsync(navigationData);
        }
    }
}
