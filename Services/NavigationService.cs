using System;
using System.Windows;
using MvvmToolkitStarter.ViewModels;

namespace MvvmToolkitStarter.Services
{
    public class NavigationService : INavigationService
    {
        private readonly IServiceProvider _provider;
        private readonly Action<object> _setContent;

        public NavigationService(IServiceProvider provider, Action<object> setContent)
        {
            _provider = provider;
            _setContent = setContent;
        }

        public void NavigateTo<TViewModel>() where TViewModel : class
        {
            var viewModel = _provider.GetRequiredService<TViewModel>();

            var viewTypeName = typeof(TViewModel).Name.Replace("ViewModel", "Page");
            var viewType = Type.GetType($"MvvmToolkitStarter.Views.{viewTypeName}");
            var view = Activator.CreateInstance(viewType!) as FrameworkElement;
            view!.DataContext = viewModel;
            _setContent(view);
        }
    }
}
