using AppDevProject.Common;
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
    
    public sealed partial class AppointmentPage : Page
    {
        public LibraryCal libr = new LibraryCal();
        public AppointmentPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            //Handle Back Button
            SystemNavigationManager.GetForCurrentView().BackRequested += AppointmentPage_BackRequested;
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            //Remove Handle Back Button
            SystemNavigationManager.GetForCurrentView().BackRequested -= AppointmentPage_BackRequested;
        }

        private void AppointmentPage_BackRequested(object sender, BackRequestedEventArgs e)
        {
            e.Handled = true;
            if (Frame.CanGoBack)
                Frame.GoBack();
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            libr.New(StartDate, StartTime, Subject, Location, Details, Duration, AllDay);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            libr.Add(sender, StartDate, StartTime, Subject, Location, Details, Duration, AllDay);
        }

        private void Calendar_Click(object sender, RoutedEventArgs e)
        {
            libr.Calendar(StartDate, StartTime);
        }
    }
}
