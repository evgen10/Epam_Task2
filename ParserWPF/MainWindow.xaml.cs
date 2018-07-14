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
using Task2Library;

namespace ParserWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Parser parser = new Parser();
        
        public MainWindow()
        {
            InitializeComponent();
            textBox.Focus();
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                numberLabel.Content = parser.ParseStringToInt(textBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("The entered string has an incorrect format" , "Error!");
                numberLabel.Content = "Can't parse!";
                textBox.Focus();

            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("The entered string is empty", "Error!");
                numberLabel.Content = "Can't parse!";
                textBox.Focus();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Arithmetic operation resulted in an overflow", "Error!");
                numberLabel.Content = "Can't parse!";
                textBox.Focus();
            }
         



        }
    }
}
