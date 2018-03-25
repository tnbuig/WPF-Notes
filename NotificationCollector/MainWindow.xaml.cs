using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NotificationCollector
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
         }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("alerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a conditionalerts tA warning message is a modal dialog box, in-place message, notification, or balloon that alerts the user of a condition", "Warning",  MessageBoxButton.OK,MessageBoxImage.Warning);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CustomMessageBox customMessageBox = new CustomMessageBox();
            customMessageBox.ShowDialog();
            this.Button_Click(this,null);
            customMessageBox = new CustomMessageBox();
            customMessageBox.Show();
            customMessageBox = new CustomMessageBox();
            customMessageBox.Show();

        }
    }
}
