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

namespace TextoConFormato2._5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void TextoUsuarioTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            MuestraTextoTextBlock.Text = TextoUsuarioTextBox.Text;
        }
        private void NegritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {

            MuestraTextoTextBlock.FontWeight = FontWeights.Bold;
        }


        private void CursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {

            MuestraTextoTextBlock.FontStyle = FontStyles.Italic;
        }

        private void NegritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {

            MuestraTextoTextBlock.FontWeight = FontWeights.Normal;
        }

        private void CursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {

            MuestraTextoTextBlock.FontStyle = FontStyles.Normal;
        }

        private void ColorAzulRadioButton_Checked(object sender, RoutedEventArgs e)
        {

            MuestraTextoTextBlock.Foreground = Brushes.Blue;
        }



        private void ColorRojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {

            MuestraTextoTextBlock.Foreground = Brushes.Red;
        }



        private void ColorVerdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
        
            MuestraTextoTextBlock.Foreground = Brushes.Green;
        }




    }
}
