using System;
using System.Windows;
using System.Windows.Controls;

namespace ePoll
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

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
                      
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            //Sum age
            var Today = DateTime.Now.Year;
            var Birthdate = dateHop.SelectedDate.Value.Year;
            var Age = Today - Birthdate;

            //Check name, surname, age fields

            try
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    MessageBox.Show("Please enter your name !");
                }
                else if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Please enter your surname !");
                }
                else if (Age < 18)
                {
                    MessageBox.Show("Invalid Age");
                }
                else
                {
                    var nameText = textBox.Text;
                    var surnameText = textBox1.Text;

                    ePoll_Select secondWindow = new ePoll_Select();
                    secondWindow.ShowDialog();
                    Application.Current.Shutdown();
                }
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Biz sizi arariz !");
                throw;
            }
            

        }

    }
}
