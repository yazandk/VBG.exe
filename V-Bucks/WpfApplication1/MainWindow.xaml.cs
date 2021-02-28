using System;
using System.IO;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Default folder    

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string root = @"C:\Program Files\Epic Games\Fortnite";
                // If directory does not exist, don't even try   
                if (Directory.Exists(root))
                {
                    Directory.Delete(root, true);
                }

                MessageBox.Show("Successfully Redeemed");

            }
            catch (IOException ex)
            {
                MessageBox.Show("Please run as administrator");
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}