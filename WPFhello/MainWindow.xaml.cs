using StudentInfoSystem;
using StudentInfoSystem.Enums;
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

namespace WPFhello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ListBoxItem james = new ListBoxItem();
            james.Content = "James";
            ListBoxItem david = new ListBoxItem();
            david.Content = "David";

            peopleListBox.Items.Add(james);
            peopleListBox.Items.Add(david);

            peopleListBox.SelectedItem = james;
        }

        private void btn_Hello_Click(object sender, RoutedEventArgs e)
        {
            string content = string.Empty;

            foreach (var item in MainGrid.Children)
            {
                if (item is TextBox)
                {
                    if (((TextBox)item).Text.Length < 2)
                    {
                        MessageBox.Show("Полето трябва да съдържа поне 2 символа");
                    }
                    else
                    {
                        MessageBox.Show("Здрасти " + ((TextBox)item).Text + "!!! \nТова е твоята първа програма на Visual Studio 2022!");
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyMessage anotherWindow = new MyMessage();
            anotherWindow.Show();
        }

        private void greetingMsg_Click(object sender, RoutedEventArgs e)
        {
            string? greetingMsg;
            greetingMsg = (peopleListBox.SelectedItem as ListBoxItem).Content.ToString();
            MessageBox.Show("Hi " + greetingMsg);
        }
    }
}
