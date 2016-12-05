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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ToDoList : Page
    {
        Library Library = new Library();
        public ToDoList()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            //Handle Back Button
            SystemNavigationManager.GetForCurrentView().BackRequested += ToDoList_BackRequested;
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            //Remove Handle Back Button
            SystemNavigationManager.GetForCurrentView().BackRequested -= ToDoList_BackRequested;
        }

        private void ToDoList_BackRequested(object sender, BackRequestedEventArgs e)
        {
            e.Handled = true;
            if (Frame.CanGoBack)
                Frame.GoBack();
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            Library.Remove(Display);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Library.Add(Display, Value.Text, Colour, sender);
            Value.Text = "";
        }

        private void Display_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
