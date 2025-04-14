using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MvvmToolkitStarter.Services;

namespace MvvmToolkitStarter.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly INavigationService _navigation;

        public MainViewModel(INavigationService navigation)
        {
            _navigation = navigation;
        }

        [RelayCommand]
        private void GoToPage1() => _navigation.NavigateTo<Page1ViewModel>();

        [RelayCommand]
        private void GoToPage2() => _navigation.NavigateTo<Page2ViewModel>();
    }
}
