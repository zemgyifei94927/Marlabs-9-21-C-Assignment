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

namespace WpfDemo2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            myTextBlock1.Text = "Changed by CSharp code.";
            myTextBlock1.Foreground = Brushes.Green;

            TextBlock myTextBlock3 = new TextBlock();
            myTextBlock3.Text = "TextBlock3";
            myTextBlock3.Inlines.Add(" + addContent");
            myTextBlock3.TextWrapping = TextWrapping.Wrap;
            // TODO: add block3 or replace block2 by block3
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            myTextBox1.IsReadOnly = false;
        }

        private void myButton1_MouseEnter(object sender, MouseEventArgs e)
        {
            myButton1.FontSize = 15;
            myButton1.Background = Brushes.Blue;
        }

        private void myButton1_MouseLeave(object sender, MouseEventArgs e)
        {
            myButton1.FontSize = 12;
            myButton1.Background = Brushes.Red;
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            myTextBox1.IsReadOnly = true;
        }

        private void myButton2_MouseEnter(object sender, MouseEventArgs e)
        {
            myButton2.FontSize = 15;
            myButton2.Background = Brushes.Blue;
        }

        private void myButton2_MouseLeave(object sender, MouseEventArgs e)
        {
            myButton2.FontSize = 12;
            myButton2.Background = Brushes.Green;
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(myTextBlock1 != null)
            {   
                myTextBlock1.FontSize = (24) * (slider1.Value / slider1.Maximum + 0.1);
            }
            
        }
    }
}
