using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfClassWork26._12._2022
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement el in MainRoot.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = ((Button)e.OriginalSource).Content.ToString();
            textLabelInput.Text += str;
            if (str == "AC")
            {
                textLabelInput.Text = "";
                textLabelOutput.Text = "";
            }
        }

        private void Button_Click_D(object sender, RoutedEventArgs e)
        {
            double value = double.Parse(textLabelInput.Text) * 0.39;
            textLabelOutput.Text += value.ToString();
        }

        private void Button_Click_F(object sender, RoutedEventArgs e)
        {
            double value = double.Parse(textLabelInput.Text) * 0.032;
            textLabelOutput.Text += value.ToString();
        }

        private void Button_Click_Y(object sender, RoutedEventArgs e)
        {
            double value = double.Parse(textLabelInput.Text) * 0.0109;
            textLabelOutput.Text += value.ToString();
        }

        private void Button_Click_M(object sender, RoutedEventArgs e)
        {
            double value = double.Parse(textLabelInput.Text) * 6.21371e-6;
            textLabelOutput.Text += value.ToString();
        }
    }
}
