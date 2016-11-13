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
using System.Windows.Shapes;

namespace ePoll
{
    /// <summary>
    /// Interaction logic for ePoll_Select.xaml
    /// </summary>
    public partial class ePoll_Select : Window
    {
        public ePoll_Select()
        {
            InitializeComponent();
        }

        private void radioButton_Checked(object sender, EventArgs e)
        {
           
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            if (radioButtonDark.IsChecked == true)
            {
                MessageBox.Show("You vote for Dark Empire. You`re Darkside. Thanks!");
                Application.Current.Shutdown();
            }
            else if (radioButtonLight.IsChecked == true)
            {
                MessageBox.Show("You vote for Jedis. You`re Lightside. Thanks!");
                Application.Current.Shutdown();
            }
            else
            {
                MessageBox.Show("Please Vote or Get out here !");
            }
        }
    }
}
