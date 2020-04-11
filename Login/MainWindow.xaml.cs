using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static public List<Users> UsersList = new List<Users>(); 
        private int LoginedIndex; 
        private bool Logined; 
        public MainWindow()
        {
            InitializeComponent();
            ReadAllLoginsFromBase();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush b = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            buttonClose.Background = b;
            Close();
        }

        private void ButtonRegClick1(object sender, RoutedEventArgs e)
        {
            Registration a = new Registration();
            Close();
            a.ShowDialog();

        }

        private void buttonEnter_Click_2(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxLogin.Text) || String.IsNullOrWhiteSpace(passwordBoxPass.Password))
            {
                MessageBox.Show("Please Enter the Correct Info");
                return;
            }
            for (int i = 0; i < UsersList.Count(); i++)
            {
                if(string.Compare(textBoxLogin.Text, UsersList[i].Login, StringComparison.OrdinalIgnoreCase) == 0 &&
                    string.Compare(passwordBoxPass.Password, UsersList[i].Password, StringComparison.CurrentCulture) ==0)
                {
                    MessageBox.Show("Welcome to the Health System");
                    Logined = true;
                    break;
                }
                
            }
            if(!Logined)
                MessageBox.Show("Try Login");
        }

        public static void WriteAllLoginsToBase()
        {
            if (!Directory.Exists(@"files"))
                Directory.CreateDirectory(@"files");

            BinaryWriter writer = new BinaryWriter(File.Open(@"files\base.dat", FileMode.Create),
                                                       Encoding.BigEndianUnicode);
            foreach (Users login in UsersList)
            {
                writer.Write(login.Login);
                writer.Write(login.Password);
            }
            writer.Close();
        }
        public static void ReadAllLoginsFromBase()
        {
            UsersList.Clear(); 
            try
            {
                BinaryReader reader = new BinaryReader(File.Open(@"files\base.dat", FileMode.Open), Encoding.BigEndianUnicode);
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    UsersList.Add(new Users(reader.ReadString(), reader.ReadString()));
                }
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("erro01");
            }
        }
    }
}
