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
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;

namespace InterfazMetro
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : MetroWindow
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            ListaContrato ls = new ListaContrato();
            ls.Show();
            this.Close();
        }

        private void Tile_Click_1(object sender, RoutedEventArgs e)
        {
            Registro rg = new Registro();
            rg.Show();
            this.Close();
        }

        private void Tile_Click_2(object sender, RoutedEventArgs e)
        {
            ListaCliente lc = new ListaCliente();

            lc.Show();
            this.Close();
        }

        private void Tile_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Tile_Click_4(object sender, RoutedEventArgs e)
        {
            ContratoCliente con = new ContratoCliente();
            con.Show();
            this.Close();
        }
    }
}
