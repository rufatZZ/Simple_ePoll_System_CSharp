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
            //var Age = DateTime.Now.Year.ToString() - dateHop.Value.Years.ToString();
            //else if (Age < 18)
            //{
            //    MessageBox.Show("Invalid Age");
            //}

            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Please enter your name !");
            }
            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter your surname !");
            }
            else
            {
                ePoll_Select secondWindow = new ePoll_Select();
                secondWindow.ShowDialog();
                Application.Current.Shutdown();

            }
            










        }


    }
}
