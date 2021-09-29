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


        private void NegritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            MuestraTextoTextBlock.Text = TextoUsuarioTextBox.Text;
            MuestraTextoTextBlock.FontWeight = FontWeights.Bold;
        }


        private void CursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            MuestraTextoTextBlock.Text = TextoUsuarioTextBox.Text;
            MuestraTextoTextBlock.FontStyle = FontStyles.Italic;
        }

        private void NegritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            MuestraTextoTextBlock.Text = TextoUsuarioTextBox.Text;
            MuestraTextoTextBlock.FontWeight = FontWeights.Normal;
        }

        private void CursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            MuestraTextoTextBlock.Text = TextoUsuarioTextBox.Text;
            MuestraTextoTextBlock.FontStyle = FontStyles.Normal;
        }

        private void ColorAzulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MuestraTextoTextBlock.Text = TextoUsuarioTextBox.Text;
            MuestraTextoTextBlock.Foreground = Brushes.Blue;
        }

        private void ColorAzulRadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            MuestraTextoTextBlock.Text = TextoUsuarioTextBox.Text;
            MuestraTextoTextBlock.Foreground = Brushes.Black;
        }

        private void ColorRojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MuestraTextoTextBlock.Text = TextoUsuarioTextBox.Text;
            MuestraTextoTextBlock.Foreground = Brushes.Red;
        }

        private void ColorRojoRadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            MuestraTextoTextBlock.Text = TextoUsuarioTextBox.Text;
            MuestraTextoTextBlock.Foreground = Brushes.Black;
        }

        private void ColorVerdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MuestraTextoTextBlock.Text = TextoUsuarioTextBox.Text;
            MuestraTextoTextBlock.Foreground = Brushes.Green;
        }

        private void ColorVerdeRadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            MuestraTextoTextBlock.Text = TextoUsuarioTextBox.Text;
            MuestraTextoTextBlock.Foreground = Brushes.Black;
        }

        private void TextoUsuarioTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            MuestraTextoTextBlock.Text = TextoUsuarioTextBox.Text;
        }
    }
}
