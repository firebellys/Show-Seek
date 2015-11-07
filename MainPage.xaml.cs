using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Show_Seek.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Show_Seek
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<Event> _localList;
        public MainPage()
        {
            this.InitializeComponent();
            Loaded += MainPageLoaded;
        }

        private void MainPageLoaded(object sender, RoutedEventArgs e)
        {
            _localList = new ObservableCollection<Event>();
            for (var i = 0; i < 40; i++)
            {
                var ev = new Event { Name = "Test " + i };
                _localList.Add(ev);
            }
            MainList.ItemsSource = _localList;
        }

        private void PrivateClick(object sender, RoutedEventArgs e)
        {
            RowHeight.Height = new GridLength(0.0, GridUnitType.Star);
            SplitViewPanel.IsPaneOpen = !SplitViewPanel.IsPaneOpen;
        }

        private void RefreshClick(object sender, RoutedEventArgs e)
        {
            RowHeight.Height = new GridLength(0.0, GridUnitType.Star);
        }

        private void SettingsClick(object sender, RoutedEventArgs e)
        {
            RowHeight.Height = new GridLength(0.0, GridUnitType.Star);
            SplitViewPanel.IsPaneOpen = !SplitViewPanel.IsPaneOpen;
            SettingsPanel.Visibility = Visibility.Visible;
            MainList.Visibility = Visibility.Collapsed;
        }

        private void SaveButtonClick(object sender, RoutedEventArgs e)
        {
            RowHeight.Height = new GridLength(0.0, GridUnitType.Star);
            SettingsPanel.Visibility = Visibility.Collapsed;
            MainList.Visibility = Visibility.Visible;
        }

        private void HomeClick(object sender, RoutedEventArgs e)
        {
            RowHeight.Height = new GridLength(0.0, GridUnitType.Star);
            SplitViewPanel.IsPaneOpen = !SplitViewPanel.IsPaneOpen;
            SettingsPanel.Visibility = Visibility.Collapsed;
            MainList.Visibility = Visibility.Visible;
        }

        private void HamburgerButtonClick(object sender, RoutedEventArgs e)
        {
            RowHeight.Height = new GridLength(0.0, GridUnitType.Star);
            SplitViewPanel.IsPaneOpen = !SplitViewPanel.IsPaneOpen;
        }

        private void AboutClick(object sender, RoutedEventArgs e)
        {
            RowHeight.Height = new GridLength(0.0, GridUnitType.Star);
            SplitViewPanel.IsPaneOpen = !SplitViewPanel.IsPaneOpen;
        }

        private void ListBoxItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (RowHeight.Height == new GridLength(0.0, GridUnitType.Star))
            {
                RowHeight.Height = new GridLength(5.0, GridUnitType.Star);
            }
            else
            {
                RowHeight.Height = new GridLength(0.0, GridUnitType.Star);
            }
        }
    }
}
