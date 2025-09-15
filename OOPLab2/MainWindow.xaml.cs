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
using System;

namespace OOPLab2
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        { 
        }


        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((double.TryParse(Lab1.Text, out double x)) && (double.TryParse(Lab2.Text, out double y)) && (double.TryParse(Lab3.Text, out double z)))
            {
                double s = Math.Pow(3 + Math.Tan(x) - (y / 2), (1 / 3)) / (Math.Pow(x, 2) + Math.Pow(z, 3) + 4);
                LabExt.Content = $"Результат: {Math.Round(s,3)}";
            }
            else 
            {
                LabExt.Content = "Невірні дані";
            }
            
        }
    }
}