using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Cliente
    {
        string _descripcionActividad;
        string _descripcionEmpresa;


        #region Propiedades
        public string RutCliente { get; set; }

        public string RazonSocial { get; set; }

        public string NombreContacto { get; set; }

        public string MailContacto { get; set; }
        public string Direccion { get; set; }

        public string Telefono { get; set; }

        #region Constructor

        #endregion
        public int IdActividadEmpresa { get; set; }
        public int IdTipoEmpresa { get; set; }
        /*public ActividadEmpresa ActividadEmpresa { get; set; }
        public TipoEmpresa tipoEmpresa { get; set; }*/



        public string DescripcionActividad { get { return _descripcionActividad; } }
        public string DescripcionEmpresa { get { return _descripcionEmpresa; } }

        public Cliente()
        {
            this.Init();
        }
        private void Init()
        {
            RutCliente = string.Empty;
            RazonSocial = string.Empty;
            NombreContacto = string.Empty;
            MailContacto = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
            IdActividadEmpresa = 0;
            IdTipoEmpresa = 0;
            _descripcionActividad = string.Empty;
            _descripcionEmpresa = string.Empty;
        }

        public bool Create()
        {
            AccesoDatos.OnBreakEntities bbdd = new AccesoDatos.OnBreakEntities();
            AccesoDatos.Cliente cli = new AccesoDatos.Cliente();
            try
            {
                CommonBC.Syncronize(this, cli);
                bbdd.Cliente.Add(cli);
                bbdd.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                bbdd.Cliente.Remove(cli);
                return false;
            }
        }
        public bool Read()
        {
            AccesoDatos.OnBreakEntities bbdd = new AccesoDatos.OnBreakEntities();
            AccesoDatos.Cliente cli = new AccesoDatos.Cliente();
            try
            {
                cli = bbdd.Cliente.First(p => p.RutCliente == this.RutCliente);
                CommonBC.Syncronize(cli, this);

                LeerDescripcion();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void LeerDescripcion()
        {
            TipoEmpresa tp = new TipoEmpresa() { IdTipoEmpresa = IdTipoEmpresa };
            if (tp.Read())
            {
                _descripcionEmpresa = tp.Descripcion;
            }
            ActividadEmpresa tipo = new ActividadEmpresa() { IdActividadEmpresa = IdActividadEmpresa };

            if (tipo.Read())
            {
                _descripcionActividad = tipo.Descripcion;
            }
        }

        public bool Delete()
        {
            AccesoDatos.OnBreakEntities bbdd = new AccesoDatos.OnBreakEntities();
            AccesoDatos.Cliente cli = new AccesoDatos.Cliente();
            try
            {
                cli = bbdd.Cliente.First(p => p.RutCliente == this.RutCliente);
                bbdd.Cliente.Remove(cli);
                bbdd.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Cliente> ReadAll()
        {
            AccesoDatos.OnBreakEntities bbdd = new AccesoDatos.OnBreakEntities();
            try
            {
                List<AccesoDatos.Cliente> ListaBD = bbdd.Cliente.ToList<AccesoDatos.Cliente>();
                List<Cliente> ListaNegocio = GenerarLista(ListaBD);
                return ListaNegocio;
            }
            catch (Exception)
            {
                return null;
            }
        }
        private List<Cliente> GenerarLista(List<AccesoDatos.Cliente> ListaBD)
        {
            List<Cliente> Lista = new List<Cliente>();

            foreach (AccesoDatos.Cliente item in ListaBD)
            {
                Cliente cli = new Cliente();
                CommonBC.Syncronize(item, cli);
                cli.LeerDescripcion();
                Lista.Add(cli);
            }
            return Lista;
        }
        public bool Update()
        {
            AccesoDatos.OnBreakEntities bbdd = new AccesoDatos.OnBreakEntities();
            AccesoDatos.Cliente cli = new AccesoDatos.Cliente();
            try
            {
                cli = bbdd.Cliente.First(p => p.RutCliente == this.RutCliente);
                CommonBC.Syncronize(this, cli);
                bbdd.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Cliente> ReadByRut(string RutCliente)
        {
            AccesoDatos.OnBreakEntities bbdd = new AccesoDatos.OnBreakEntities();

            try
            {
                List<AccesoDatos.Cliente> listaDatos =
                    bbdd.Cliente.Where(b => b.RutCliente == RutCliente).ToList<AccesoDatos.Cliente>();

                List<Cliente> listaNegocio = GenerarLista(listaDatos);
                return listaNegocio;
            }
            catch (Exception ex)
            {
                return new List<Cliente>();
            }
        }
        public List<Cliente> ReadByActividadEmpresa(int IdActividadEmpresa)
        {
            AccesoDatos.OnBreakEntities bbdd = new AccesoDatos.OnBreakEntities();

            try
            {
                List<AccesoDatos.Cliente> listaDatos =
                    bbdd.Cliente.Where(b => b.IdActividadEmpresa == IdActividadEmpresa).ToList<AccesoDatos.Cliente>();

                List<Cliente> listaNegocio = GenerarLista(listaDatos);
                return listaNegocio;
            }
            catch (Exception ex)
            {
                return new List<Cliente>();
            }
        }
        public List<Cliente> ReadByTipoEmpresa(int IdTipoEmpresa)
        {
            AccesoDatos.OnBreakEntities bbdd = new AccesoDatos.OnBreakEntities();

            try
            {
                List<AccesoDatos.Cliente> listaDatos =
                    bbdd.Cliente.Where(b => b.IdTipoEmpresa == IdTipoEmpresa).ToList<AccesoDatos.Cliente>();

                List<Cliente> listaNegocio = GenerarLista(listaDatos);
                return listaNegocio;
            }
            catch (Exception ex)
            {
                return new List<Cliente>();
            }
        }
    }

}
#endregion