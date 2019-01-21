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

namespace Ex43___GUI_01
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string temp = lineOne.Text;
            lineOne.Text = lineTwo.Text;
            lineTwo.Text = lineThree.Text;
            lineThree.Text = lineFour.Text;
            lineFour.Text = temp;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lineOne.Text = String.Empty;
            lineTwo.Text = String.Empty;
            lineThree.Text = String.Empty;
            lineFour.Text = String.Empty;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string temp = lineFour.Text;
            lineFour.Text = lineThree.Text;
            lineThree.Text = lineTwo.Text;
            lineTwo.Text = lineOne.Text;
            lineOne.Text = temp;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            lineOne.Text = "Line 1";
            lineTwo.Text = "Line 2";
            lineThree.Text = "Line 3";
            lineFour.Text = "Line 4";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            lineOne.TextAlignment = TextAlignment.Left;
            lineTwo.TextAlignment = TextAlignment.Left;
            lineThree.TextAlignment = TextAlignment.Left;
            lineFour.TextAlignment = TextAlignment.Left;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            lineOne.TextAlignment = TextAlignment.Right;
            lineTwo.TextAlignment = TextAlignment.Right;
            lineThree.TextAlignment = TextAlignment.Right;
            lineFour.TextAlignment = TextAlignment.Right;
        }
    }
}
