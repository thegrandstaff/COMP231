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

namespace BookAppointment
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

        private void nineToHalf_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Create appointment for 9:00 to 9:30?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Appointment created.", "Confirmation");
                nineToHalf_Btn.IsEnabled = false;
            }
        }

        private void tenToHalf_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Create appointment for 10:00 to 10:30?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Appointment created.", "Confirmation");
                tenToHalf_Btn.IsEnabled = false;
            }
        }

        private void elevenToHalf_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Create appointment for 11:00 to 11:30?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Appointment created.", "Confirmation");
                elevenToHalf_Btn.IsEnabled = false;
            }
        }

        private void oneToHalf_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Create appointment for 1:00 to 1:30?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Appointment created.", "Confirmation");
                oneToHalf_Btn.IsEnabled = false;
            }
        }

        private void twoToHalf_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Create appointment for 2:00 to 2:30?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Appointment created.", "Confirmation");
                twoToHalf_Btn.IsEnabled = false;
            }
        }

        private void threeToHalf_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Create appointment for 3:00 to 3:30?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Appointment created.", "Confirmation");
                threeToHalf_Btn.IsEnabled = false;
            }
        }

        private void fourToHalf_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Create appointment for 4:00 to 4:30?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Appointment created.", "Confirmation");
                fourToHalf_Btn.IsEnabled = false;
            }
        }

        private void fiveToHalf_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Create appointment for 5:00 to 5:30?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Appointment created.", "Confirmation");
                fiveToHalf_Btn.IsEnabled = false;
            }
        }

        private void halfToTen_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Create appointment for 9:30 to 10:00?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Appointment created.", "Confirmation");
                halfToTen_Btn.IsEnabled = false;
            }
        }

        private void halfToEleven_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Create appointment for 10:30 to 11:00?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Appointment created.", "Confirmation");
                halfToEleven_Btn.IsEnabled = false;
            }
        }

        private void halfToTwelve_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Create appointment for 11:30 to 12:00?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Appointment created.", "Confirmation");
                halfToTwelve_Btn.IsEnabled = false;
            }
        }

        private void halfToTwo_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Create appointment for 1:30 to 2:00?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Appointment created.", "Confirmation");
                halfToTwo_Btn.IsEnabled = false;
            }
        }

        private void halfToThree_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Create appointment for 2:30 to 3:00?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Appointment created.", "Confirmation");
                halfToThree_Btn.IsEnabled = false;
            }
        }

        private void halfToFour_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Create appointment for 3:30 to 4:00?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Appointment created.", "Confirmation");
                halfToFour_Btn.IsEnabled = false;
            }
        }

        private void halfToFive_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Create appointment for 4:30 to 5:00?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Appointment created.", "Confirmation");
                halfToFive_Btn.IsEnabled = false;
            }
        }

        private void halfToSix_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Create appointment for 5:30 to 6:00?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Appointment created.", "Confirmation");
                halfToSix_Btn.IsEnabled = false;
            }
        }
    }
}
