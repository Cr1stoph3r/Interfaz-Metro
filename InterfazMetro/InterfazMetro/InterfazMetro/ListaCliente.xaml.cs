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
    /// Lógica de interacción para ListaCliente.xaml
    /// </summary>
    public partial class ListaCliente : MetroWindow
    {
        int banderin = 0;
        
        
        public ListaCliente()
        {
            InitializeComponent();
            CargarActividadEmpresa();
        }
        private void LimpiarControles()
        {
            txtrut.Text = string.Empty;
            CargarActividadEmpresa();
        }
        private void CargarActividadEmpresa()
        {
            cbox_actEmp.ItemsSource = new Negocio.ActividadEmpresa().ReadAll();
            cbox_actEmp.DisplayMemberPath = "Descripcion";
            cbox_actEmp.SelectedValuePath = "IdActividadEmpresa";

            cbox_tEmp.ItemsSource = new Negocio.TipoEmpresa().ReadAll();
            cbox_tEmp.DisplayMemberPath = "Descripcion";
            cbox_tEmp.SelectedValuePath = "IdTipoEmpresa";

            MostrarClientes();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FiltrarCliente();

        }
        private async void FiltrarCliente()
        {
            Negocio.Cliente FiltroClie = new Negocio.Cliente();
            List<Negocio.Cliente> Clientes = new List<Negocio.Cliente>();
            Clientes = FiltroClie.ReadAll();
            dgPersonas.ItemsSource = Clientes;
            try
            {
                if (!txtrut.Text.Equals(string.Empty))
                {
                    dgPersonas.ItemsSource = Clientes.Where(r => r.RutCliente == txtrut.Text);

                    if (dgPersonas.Items.Count == 0)
                    {
                        await this.ShowMessageAsync("Error", "no existe cliente con este rut " + txtrut.Text);
                        dgPersonas.ItemsSource = Clientes;
                    }
                }
                else
                {
                    if ((int)cbox_actEmp.SelectedIndex != -1 && (int)cbox_tEmp.SelectedIndex != -1)
                    {
                        //si ambos combo box estan alterados  
                        FiltroClie.IdActividadEmpresa = (int)cbox_actEmp.SelectedValue;
                        FiltroClie.IdTipoEmpresa = (int)cbox_tEmp.SelectedValue;
                        dgPersonas.ItemsSource = Clientes.Where(p => p.IdActividadEmpresa == (int)cbox_actEmp.SelectedValue && p.IdTipoEmpresa == (int)cbox_tEmp.SelectedValue);
                        dgPersonas.Items.Refresh();

                    }
                    else
                    {
                        if ((int)cbox_tEmp.SelectedIndex != -1)
                        {
                            dgPersonas.ItemsSource = Clientes.Where(p => p.IdTipoEmpresa == (int)cbox_tEmp.SelectedValue);
                            dgPersonas.Items.Refresh();
                        }

                        else

                            if ((int)cbox_actEmp.SelectedIndex != -1)
                        {
                            dgPersonas.ItemsSource = Clientes.Where(p => p.IdActividadEmpresa == (int)cbox_actEmp.SelectedValue);
                            dgPersonas.Items.Refresh();
                        }

                        else
                        {
                            dgPersonas.ItemsSource = Clientes;
                            dgPersonas.Items.Refresh();
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
        private void MostrarClientes()
        {
            Negocio.Cliente cli = new Negocio.Cliente();
            dgPersonas.ItemsSource = cli.ReadAll();
            dgPersonas.Items.Refresh();
        }

        private void dgPersonas_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            Negocio.Cliente cli = new Negocio.Cliente();
            dgPersonas.ItemsSource = cli.ReadAll();
            dgPersonas.Items.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtrut.Text = string.Empty;
            CargarActividadEmpresa();
        }
    }
}
