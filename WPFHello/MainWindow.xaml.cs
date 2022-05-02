using System.Windows;
using System.Windows.Controls;
using WPFHello;

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
            ListBoxItem james = new();
            james.Content = "James";

            ListBoxItem david = new();
            david.Content = "David";

            peopleListBox.Items.Add(james);
            peopleListBox.Items.Add(david);

            peopleListBox.SelectedItem = james;
        }

        private void OnClickHello(object sender, RoutedEventArgs e)
        {
            if (txtName.Text.Length <= 1)
            {
                MessageBox.Show("Грешни данни, опитай отново");
            }
            else
            {
                MessageBox.Show("Здрасти " + txtName.Text + "!\n Това е твоята първа програма! ");
            }
        }
        private void BtnGreedClick(object sender, RoutedEventArgs e)
        {
            string greetingMsg;
            greetingMsg = (peopleListBox.SelectedItem as ListBoxItem).Content.ToString();
            MessageBox.Show("Hi " + greetingMsg);
        }
        private void BtnClick(object sender, RoutedEventArgs e)
        {

            MyMessage anotherWindow = new();
            anotherWindow.Show();

        }
    }
}
