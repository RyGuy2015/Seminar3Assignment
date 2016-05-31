using System;
using NavigationServiceAssignment.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;

namespace NavigationServiceAssignment.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        //protected override void OnNavigatedTo(NavigationEventArgs e)
        //{
        //    var x = e.Parameter as String;
        //}
    }
}
