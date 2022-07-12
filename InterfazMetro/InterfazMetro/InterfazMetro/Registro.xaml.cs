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
    /// Lógica de interacción para Registro.xaml
    /// </summary>
    public partial class Registro : MetroWindow
    {
        public static List<Negocio.Cliente> cl = new List<Negocio.Cliente>();
        public Registro()
        {
            InitializeComponent();
            CargarActividadEmpresa();
            LimpiarControles();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Close();
        }




        private void LimpiarControles()
        {
            txtrut.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtemail.Text = string.Empty;
            txttelefono.Text = string.Empty;
            txtr_social.Text = string.Empty;
            txtdireccion.Text = string.Empty;
            txtfiltrar.Text = string.Empty;
            CargarActividadEmpresa();
        }
        private void CargarActividadEmpresa()
        {
            cbox_actEmp.ItemsSource = new Negocio.ActividadEmpresa().ReadAll();
            cbox_actEmp.DisplayMemberPath = "Descripcion";
            cbox_actEmp.SelectedValuePath = "IdActividadEmpresa";
            cbox_actEmp.SelectedIndex = 0;

            cbox_tEmp.ItemsSource = new Negocio.TipoEmpresa().ReadAll();
            cbox_tEmp.DisplayMemberPath = "Descripcion";
            cbox_tEmp.SelectedValuePath = "IdTipoEmpresa";
            cbox_tEmp.SelectedIndex = 0;
        }




        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                Negocio.Cliente cli = new Negocio.Cliente();
                if (txtfiltrar.Text != string.Empty)
                {
                    try
                    {
                        cli.RutCliente = txtfiltrar.Text;
                        if (cli.Read())
                        {
                            txtrut.Text = cli.RutCliente;
                            txtr_social.Text = cli.RazonSocial;
                            txtnombre.Text = cli.NombreContacto;
                            txtemail.Text = cli.MailContacto;
                            txtdireccion.Text = cli.Direccion;
                            txttelefono.Text = cli.Telefono;
                            cbox_actEmp.SelectedValue = cli.IdActividadEmpresa;
                            cbox_tEmp.SelectedValue = cli.IdTipoEmpresa;
                        }
                        else await this.ShowMessageAsync("Error..", "Cliente no encontrado..", MessageDialogStyle.Affirmative);
                    }
                    catch (Exception)
                    {
                        await this.ShowMessageAsync("Error..", "Cliente no encontrado..", MessageDialogStyle.Affirmative);
                    }
                }
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            {
                txtrut.Text = string.Empty;
                txtnombre.Text = string.Empty;
                txtemail.Text = string.Empty;
                txttelefono.Text = string.Empty;
                txtr_social.Text = string.Empty;
                txtdireccion.Text = string.Empty;
                CargarActividadEmpresa();

            }
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            {
                Negocio.Cliente cli = new Negocio.Cliente();
                if (txtrut.Text != string.Empty && txtnombre.Text != string.Empty && txtr_social.Text != string.Empty && txtemail.Text != string.Empty && txtdireccion.Text != string.Empty && txttelefono.Text != string.Empty)
                {
                    cli.RutCliente = txtrut.Text;
                    cli.RazonSocial = txtr_social.Text;
                    cli.NombreContacto = txtnombre.Text;
                    cli.MailContacto = txtemail.Text;
                    cli.Direccion = txtdireccion.Text;
                    cli.Telefono = txttelefono.Text;
                    if (!cli.Read())
                    {
                        cli.RutCliente = txtrut.Text;
                        cli.RazonSocial = txtr_social.Text;
                        cli.NombreContacto = txtnombre.Text;
                        cli.MailContacto = txtemail.Text;
                        cli.Direccion = txtdireccion.Text;
                        cli.Telefono = txttelefono.Text;
                        cli.IdActividadEmpresa = (int)cbox_actEmp.SelectedValue;
                        cli.IdTipoEmpresa = (int)cbox_tEmp.SelectedValue;
                        if (cli.Create())
                        {
                            await this.ShowMessageAsync("Cliente Registrado", "El Cliente a sido registrado con exito");
                            LimpiarControles();
                        }
                        else
                        {

                            await this.ShowMessageAsync("Invalido", "El Cliente no fue Registrado");
                        }
                    }
                    else
                    {
                        await this.ShowMessageAsync("Cliente existente", "El cliente ya ha sido registrado con anterioridad");
                    }
                }
                else
                {
                    await this.ShowMessageAsync("Campos nulos", "Debe ingresar todos los campos");
                }  


            }
        }


        private async void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Negocio.Cliente cli = new Negocio.Cliente();

            if (txtrut.Text != string.Empty && txtnombre.Text != string.Empty && txtr_social.Text != string.Empty && txtemail.Text != string.Empty && txtdireccion.Text != string.Empty && txttelefono.Text != string.Empty)
            {

                try
                {
                    cli.RutCliente = txtrut.Text;
                    cli.RazonSocial = txtr_social.Text;
                    cli.NombreContacto = txtnombre.Text;
                    cli.MailContacto = txtemail.Text;
                    cli.Direccion = txtdireccion.Text;
                    cli.Telefono = txttelefono.Text;
                    if (cli.Read())
                    {
                        cli.RutCliente = txtrut.Text;
                        cli.RazonSocial = txtr_social.Text;
                        cli.NombreContacto = txtnombre.Text;
                        cli.MailContacto = txtemail.Text;
                        cli.Direccion = txtdireccion.Text;
                        cli.Telefono = txttelefono.Text;
                        cli.IdActividadEmpresa = (int)cbox_actEmp.SelectedValue;
                        cli.IdTipoEmpresa = (int)cbox_tEmp.SelectedValue;
                        if (cli.Update())
                        {
                            await this.ShowMessageAsync("Éxito", "Registro actualizado...", MessageDialogStyle.Affirmative);
                        }
                    }
                    else
                        await this.ShowMessageAsync("Error..", "El cliente no está registrado....", MessageDialogStyle.Affirmative);
                }
                catch (Exception)
                {

                    await this.ShowMessageAsync("Error..", "Rut no está registrado....", MessageDialogStyle.Affirmative);
                }
            }
            else
            {
                await this.ShowMessageAsync("Error..", "No deben haber campos nulos....", MessageDialogStyle.Affirmative);
            }
        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Negocio.Cliente cli = new Negocio.Cliente();
            cli.RutCliente = txtrut.Text;
            if (cli.Read())
            {
                if (await this.ShowMessageAsync("¿Eliminar este Cliente?", "Confirmar", MessageDialogStyle.AffirmativeAndNegative) == MessageDialogResult.Affirmative)
                {   //Elimina un elemento de BD
                    if (cli.Delete())
                    {
                        await this.ShowMessageAsync("Eliminar Cliente", "Cliente Eliminado..", MessageDialogStyle.Affirmative);
                    }
                    else
                        await this.ShowMessageAsync("Error", "El Cliente no pudo ser Eliminado.", MessageDialogStyle.Affirmative);
                }
            }
            LimpiarControles();
        }
    }
}
