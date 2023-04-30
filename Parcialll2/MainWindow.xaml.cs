using System;
using System.Collections;
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

namespace Parcialll2
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
            lista1.Items.Add(texto1.Text);
            lista2.Items.Add(texto2.Text);
            lista3.Items.Add(texto3.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (lista1.SelectedIndex != -1)
            {
                int indiceSeleccionado = lista1.SelectedIndex;
                lista1.Items.RemoveAt(indiceSeleccionado);
            }
            if (lista2.SelectedIndex != -1)
            {
                int indiceSeleccionado = lista2.SelectedIndex;
                lista2.Items.RemoveAt(indiceSeleccionado);
            }
            if (lista3.SelectedIndex != -1)
            {
                int indiceSeleccionado = lista3.SelectedIndex;
                lista3.Items.RemoveAt(indiceSeleccionado);
            }
        }
    }
}
