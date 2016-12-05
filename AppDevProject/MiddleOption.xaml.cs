using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AppDevProject
{
    public sealed partial class MiddleOption : Page
    {
        public MiddleOption()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            //Handle Back Button
            SystemNavigationManager.GetForCurrentView().BackRequested += MiddleOption_BackRequested;
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            //Remove Handle Back Button
            SystemNavigationManager.GetForCurrentView().BackRequested -= MiddleOption_BackRequested;
        }

        private void MiddleOption_BackRequested(object sender, BackRequestedEventArgs e)
        {
            e.Handled = true;
            if (Frame.CanGoBack)
                Frame.GoBack();
        }

        private void btnToDO_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ToDoList));//Navigating between Pages
        }

        private void btnCalendar_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AppointmentPage));//Navigating between Pages
        }
    }
}
