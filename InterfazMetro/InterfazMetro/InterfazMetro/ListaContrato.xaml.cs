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
    /// Lógica de interacción para ListaContrato.xaml
    /// </summary>
    public partial class ListaContrato : MetroWindow
    {
        public ListaContrato()
        {
            InitializeComponent();
            LimpiarControles();
            MostrarContratos();
        }
        private void LimpiarControles()
        {
            txtrut.Text = string.Empty;
            txtnumero.Text = string.Empty;
            CargarDescripcion();
        }
        private void CargarDescripcion()
        {

            cbox_tipoevento.ItemsSource = new Negocio.TipoEvento().ReadAll();
            cbox_tipoevento.DisplayMemberPath = "Descripcion";
            cbox_tipoevento.SelectedValuePath = "IdTipoEvento";
            cbox_tipoevento.SelectedIndex = 0;
        }
        private void MostrarContratos()
        {
            Negocio.Contrato cli = new Negocio.Contrato();
            dgContrato.ItemsSource = cli.ReadAll();
            dgContrato.Items.Refresh();
        }

        private void dgPersonas_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            Negocio.Contrato cli = new Negocio.Contrato();
            dgContrato.ItemsSource = cli.ReadAll();
            dgContrato.Items.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtrut.Text = string.Empty;
            txtnumero.Text = string.Empty;
            CargarDescripcion();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Negocio.Contrato FiltroCon = new Negocio.Contrato();
            List<Negocio.Contrato> Con = new List<Negocio.Contrato>();
            Con = FiltroCon.ReadAll();
            dgContrato.ItemsSource = Con;
            try
            {
                if (!txtrut.Text.Equals(string.Empty))
                {
                    dgContrato.ItemsSource = Con.Where(r => r.RutCliente == txtrut.Text);

                    if (dgContrato.Items.Count == 0)
                    {
                        await this.ShowMessageAsync("Error", "no existe contrato con este rut " + txtrut.Text);
                        dgContrato.ItemsSource = Con;
                    }
                }
                else
                {
                    if (!txtnumero.Text.Equals(string.Empty))
                    {
                        dgContrato.ItemsSource = Con.Where(p => p.Numero == txtnumero.Text);
                        dgContrato.Items.Refresh();
                    }

                    else { 

                        if ((int)cbox_tipoevento.SelectedIndex != -1)
                    {
                        dgContrato.ItemsSource = Con.Where(p => p.IdTipoEvento == (int)cbox_tipoevento.SelectedValue);
                        dgContrato.Items.Refresh();
                    }

                    else
                    {
                        dgContrato.ItemsSource = Con;
                        dgContrato.Items.Refresh();
                        await this.ShowMessageAsync("", "sin Filtro");
                    }
                }
                }
            }



            catch (Exception ex)
            {
                await this.ShowMessageAsync("ERROR", "Durante el filtrado se produjo la siguiente excepción --> " + ex);
            }
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Close();

        }
    }
}
