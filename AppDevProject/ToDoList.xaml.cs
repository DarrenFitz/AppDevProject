using System;
using System.Collections.Generic;
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

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            Library.Remove(Display);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Library.Add(Display, Value.Text, Colour, sender);
        }
    }
}
