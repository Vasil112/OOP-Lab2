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

namespace Task2_2
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

        private void text1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void text2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void text3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if ((double.TryParse(text1.Text, out double a)) && (double.TryParse(text2.Text, out double b)) && (double.TryParse(text3.Text, out double c)))
            {
                double d = b * b - (4 * a * c);
                dis.Content = $"Дискримінант: {d}";
                if (d > 0)
                {
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    root.Content = $"x1: {x1}, x2: {x2}";
                }
                else if (d == 0)
                {
                    double x = -b / (2 * a);
                    root.Content = $"Корінь: {x}";
                }
                else
                {
                    root.Content = "Немає розв'язку";
                }

            }
            else
            {
                root.Content = "Невірні дані";
            }
        }
    }
}