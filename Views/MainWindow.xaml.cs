using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using MvvmToolkitStarter.Services;
using MvvmToolkitStarter.ViewModels;

namespace MvvmToolkitStarter.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var services = new ServiceCollection();

            services.AddSingleton<MainViewModel>();
            services.AddTransient<Page1ViewModel>();
            services.AddTransient<Page2ViewModel>();

            INavigationService navigation = null!;
            services.AddSingleton<INavigationService>(provider =>
            {
                navigation = new NavigationService(provider, view => ContentHost.Content = view);
                return navigation;
            });

            var provider = services.BuildServiceProvider();
            DataContext = provider.GetRequiredService<MainViewModel>();
        }
    }
}
