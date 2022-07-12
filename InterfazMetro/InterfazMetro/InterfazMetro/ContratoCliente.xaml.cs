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
    /// Lógica de interacción para ContratoCliente.xaml
    /// </summary>
    public partial class ContratoCliente : MetroWindow
    {
        public ContratoCliente()
        {
            InitializeComponent();
            LimpiarControles();
        }
        private void LimpiarControles()
        {
            txtnumero.Text = string.Empty;
            dateCreacion.SelectedDate = new DateTime(1990, 01, 01);
            dateTermino.SelectedDate = new DateTime(1990, 01, 01);
            txtrut.Text = string.Empty;
            dateinicio.SelectedDate = new DateTime(1990, 01, 01);
            datetermino.SelectedDate = new DateTime(1990, 01, 01);
            txtasistentes.Text = string.Empty;
            txtpersonal.Text = string.Empty;
            check.IsChecked = false;
            txtvalor.Text = string.Empty;
            txtobservacion.Text = string.Empty;
            CargarDescripcion();
        }
        private void CargarDescripcion()
        {
            cbox_mod.ItemsSource = new Negocio.ModalidadServicio().ReadAll();
            cbox_mod.DisplayMemberPath = "Nombre";
            cbox_mod.SelectedValuePath = "IdModalidad";
            cbox_mod.SelectedIndex = 0;

            cbox_tEvent.ItemsSource = new Negocio.TipoEvento().ReadAll();
            cbox_tEvent.DisplayMemberPath = "Descripcion";
            cbox_tEvent.SelectedValuePath = "IdTipoEvento";
            cbox_tEvent.SelectedIndex = 0;
        }


        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Negocio.Contrato cli = new Negocio.Contrato();
            Negocio.Cliente con = new Negocio.Cliente();

            if (txtnumero.Text != string.Empty && txtrut.Text != string.Empty && txtasistentes.Text != string.Empty && txtpersonal.Text != string.Empty && txtvalor.Text != string.Empty && txtobservacion.Text != string.Empty)
            {
                try
                {
                    con.RutCliente = txtrut.Text;
                    if (con.Read())
                    {
                        cli.Numero = txtnumero.Text;
                        cli.RutCliente = txtrut.Text;
                        cli.Asistentes = int.Parse(txtasistentes.Text);
                        cli.PersonalAdicional = int.Parse(txtpersonal.Text);
                        cli.ValorTotalContrato = double.Parse(txtvalor.Text);
                        cli.Observaciones = txtobservacion.Text;
                        if (!cli.Read())
                        {
                            cli.Numero = txtnumero.Text;
                            cli.Creacion = ((DateTime)dateCreacion.SelectedDate);
                            cli.Termino = ((DateTime)dateTermino.SelectedDate);
                            cli.RutCliente = txtrut.Text;
                            cli.IdModalidad = (string)cbox_mod.SelectedValue;
                            cli.IdTipoEvento = (int)cbox_tEvent.SelectedValue;
                            cli.FechaHoraInicio = ((DateTime)dateinicio.SelectedDate);
                            cli.FechaHoraTermino = ((DateTime)datetermino.SelectedDate);
                            cli.Asistentes = int.Parse(txtasistentes.Text);
                            cli.PersonalAdicional = int.Parse(txtpersonal.Text);
                            cli.ValorTotalContrato = double.Parse(txtvalor.Text);
                            cli.Realizado = (bool)check.IsChecked;
                            cli.Observaciones = txtobservacion.Text;
                            if (cli.Create())
                            {
                                await this.ShowMessageAsync("Contrato Registrado", "El Contrato a sido registrado con exito");
                                LimpiarControles();
                            }
                            else
                            {

                                await this.ShowMessageAsync("Error..", "Cliente no encontrado..", MessageDialogStyle.Affirmative);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    await this.ShowMessageAsync("Cliente existente", "El cliente ya ha sido registrado con anterioridad");
                }
                }
                else
                {
                    await this.ShowMessageAsync("Campos nulos", "Debe ingresar todos los campos");
                }
            

        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Close();
        }

        private async void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Negocio.Contrato cli = new Negocio.Contrato();

            if (txtnumero.Text != string.Empty && txtrut.Text != string.Empty && txtasistentes.Text != string.Empty && txtpersonal.Text != string.Empty && txtvalor.Text != string.Empty && txtobservacion.Text != string.Empty)
            {

                try
                {
                    cli.Numero = txtnumero.Text;
                    cli.RutCliente = txtrut.Text;
                    cli.Asistentes = int.Parse(txtasistentes.Text);
                    cli.PersonalAdicional = int.Parse(txtpersonal.Text);
                    cli.ValorTotalContrato = double.Parse(txtvalor.Text);
                    cli.Observaciones = txtobservacion.Text;
                    if (cli.Read())
                    {
                        cli.Numero = txtnumero.Text;
                        cli.Creacion = ((DateTime)dateCreacion.SelectedDate);
                        cli.Termino = ((DateTime)dateTermino.SelectedDate);
                        cli.RutCliente = txtrut.Text;
                        cli.IdModalidad = (string)cbox_mod.SelectedValue;
                        cli.IdTipoEvento = (int)cbox_tEvent.SelectedValue;
                        cli.FechaHoraInicio = ((DateTime)dateinicio.SelectedDate);
                        cli.FechaHoraTermino = ((DateTime)datetermino.SelectedDate);
                        cli.Asistentes = int.Parse(txtasistentes.Text);
                        cli.PersonalAdicional = int.Parse(txtpersonal.Text);
                        cli.ValorTotalContrato = double.Parse(txtvalor.Text);
                        cli.Realizado = (bool)check.IsChecked;
                        cli.Observaciones = txtobservacion.Text;
                        if (cli.Update())
                        {
                            await this.ShowMessageAsync("Éxito", "Registro actualizado...", MessageDialogStyle.Affirmative);
                        }
                    }
                    else
                        await this.ShowMessageAsync("Error..", "No hay contrato....", MessageDialogStyle.Affirmative);
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
            Negocio.Contrato cli = new Negocio.Contrato();
            cli.Numero = txtnumero.Text;
            if (cli.Read())
            {
                if (await this.ShowMessageAsync("¿Terminar este Contrato?", "Confirmar", MessageDialogStyle.AffirmativeAndNegative) == MessageDialogResult.Affirmative)
                {   //Elimina un elemento de BD
                    if (cli.Delete())
                    {
                        await this.ShowMessageAsync("Eliminar Contrato", "Contrato Terminado..", MessageDialogStyle.Affirmative);
                    }
                    else
                        await this.ShowMessageAsync("Error", "El Contrato no pudo ser Terminado.", MessageDialogStyle.Affirmative);
                }
            }
            LimpiarControles();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Negocio.Contrato cli = new Negocio.Contrato();
            if (txtfiltrar.Text != string.Empty)
            {
                try
                {
                    cli.Numero = txtfiltrar.Text;
                    if (cli.Read())
                    {
                        txtnumero.Text = cli.Numero;
                        dateCreacion.SelectedDate= cli.Creacion;
                        dateTermino.SelectedDate = cli.Termino;
                        txtrut.Text = cli.RutCliente;
                        cbox_mod.SelectedValue = cli.IdModalidad;
                        cbox_tEvent.SelectedValue = cli.IdTipoEvento;
                        dateinicio.SelectedDate = cli.FechaHoraInicio;
                        datetermino.SelectedDate = cli.FechaHoraTermino;
                        txtasistentes.Text = cli.Asistentes.ToString();
                        txtpersonal.Text = cli.PersonalAdicional.ToString();
                        txtvalor.Text = cli.ValorTotalContrato.ToString();
                        check.IsChecked = cli.Realizado;
                        txtobservacion.Text = cli.Observaciones;
                    }
                    else await this.ShowMessageAsync("Error..", "Contrato no encontrado..", MessageDialogStyle.Affirmative);
                }
                catch (Exception)
                {
                    await this.ShowMessageAsync("Error..", "Contrato no encontrado..", MessageDialogStyle.Affirmative);
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LimpiarControles();
        }

        private async void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double valorbase;
            int personalbase;
            Negocio.ModalidadServicio moda = new Negocio.ModalidadServicio();
            Negocio.Contrato con = new Negocio.Contrato();
            con.IdModalidad = cbox_mod.SelectedValue.ToString();
            moda.IdModalidad = con.IdModalidad;
            if (moda.Read())
            {
                valorbase = moda.ValorBase;
                personalbase = moda.PersonalBase;
            }
            else
            {
                await this.ShowMessageAsync("Error ..", "No se a encontrado modalidad ..", MessageDialogStyle.Affirmative);
                valorbase = 0;
                personalbase = 0;
            }
            
            try
            {
                if (txtasistentes.Text != string.Empty && txtpersonal.Text != string.Empty && (int)cbox_mod.SelectedIndex != -1)
                {
                    Negocio.Valorizador val = new Negocio.Valorizador();
                   txtvalor.Text = val.CalcularValorEvento(int.Parse(txtasistentes.Text), int.Parse(txtpersonal.Text), valorbase, personalbase).ToString();
                }
                else
                {
                    await this.ShowMessageAsync("Error de calculo..", "Hay campos sin llenar ..", MessageDialogStyle.Affirmative);
                }
            }
            catch
            {
                await this.ShowMessageAsync("Error de calculo..", "Ups algo a salido terrible mal ..", MessageDialogStyle.Affirmative);
            }
        }
    }
}
