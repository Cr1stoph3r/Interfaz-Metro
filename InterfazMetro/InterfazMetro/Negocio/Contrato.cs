using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Contrato
    {
        string _descripcionModalidad;
        string _descripcionEvento;
        public string Numero { get; set; }
        public DateTime Creacion { get; set; }
        public DateTime Termino { get; set; }
        public string RutCliente { get; set; }
        public string IdModalidad { get; set; }
        public int IdTipoEvento { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime FechaHoraTermino { get; set; }
        public int Asistentes { get; set; }
        public int PersonalAdicional { get; set; }
        public bool Realizado { get; set; }
        public double ValorTotalContrato { get; set; }
        public string Observaciones { get; set; }
        public string DescripcionModalidad { get { return _descripcionModalidad; } }
        public string DescripcionEvento { get { return _descripcionEvento; } }
        public Contrato()
        {
            this.Init();
        }

        private void Init()
        {
            Numero = string.Empty;
            Creacion = new DateTime(1990, 01, 01);
            Termino = new DateTime(1990, 01, 01);
            RutCliente = string.Empty;
            IdModalidad = string.Empty;
            IdTipoEvento = 1;
            FechaHoraInicio = new DateTime(1990, 01, 01);
            FechaHoraTermino = new DateTime(1990, 01, 01);
            Asistentes = 0;
            PersonalAdicional = 0;
            ValorTotalContrato = 0;
            Observaciones = string.Empty;

            _descripcionModalidad = string.Empty;

        }

        public bool Create()
        {
            AccesoDatos.OnBreakEntities bbdd = new AccesoDatos.OnBreakEntities();
            AccesoDatos.Contrato cli = new AccesoDatos.Contrato();
            try
            {
                CommonBC.Syncronize(this, cli);
                bbdd.Contrato.Add(cli);
                bbdd.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                bbdd.Contrato.Remove(cli);
                return false;
            }
        }
        public bool Read()
        {
            AccesoDatos.OnBreakEntities bbdd = new AccesoDatos.OnBreakEntities();
            AccesoDatos.Contrato cli = new AccesoDatos.Contrato();
            try
            {
                cli = bbdd.Contrato.First(p => p.Numero == this.Numero);
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
            ModalidadServicio modalidad = new ModalidadServicio() { IdModalidad = IdModalidad};
            if (modalidad.Read())
            {
                _descripcionModalidad = modalidad.Nombre;
                modalidad.LeerDescripcion();
                this._descripcionEvento = modalidad.DescripcionEvento;
            }

        }
        public bool Delete()
        {
            AccesoDatos.OnBreakEntities bbdd = new AccesoDatos.OnBreakEntities();
            AccesoDatos.Contrato cli = new AccesoDatos.Contrato();
            try
            {
                cli = bbdd.Contrato.First(p => p.Numero == this.Numero);
                bbdd.Contrato.Remove(cli);
                bbdd.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Contrato> ReadAll()
        {
            AccesoDatos.OnBreakEntities bbdd = new AccesoDatos.OnBreakEntities();
            try
            {
                List<AccesoDatos.Contrato> ListaBD = bbdd.Contrato.ToList<AccesoDatos.Contrato>();
                List<Contrato> ListaNegocio = GenerarLista(ListaBD);
                return ListaNegocio;
            }
            catch (Exception)
            {
                return null;
            }
        }
        private List<Contrato> GenerarLista(List<AccesoDatos.Contrato> ListaBD)
        {
            List<Contrato> Lista = new List<Contrato>();

            foreach (AccesoDatos.Contrato item in ListaBD)
            {
                Contrato cli = new Contrato();
                CommonBC.Syncronize(item, cli);
                cli.LeerDescripcion();
                Lista.Add(cli);
            }
            return Lista;
        }
        public bool Update()
        {
            AccesoDatos.OnBreakEntities bbdd = new AccesoDatos.OnBreakEntities();
            AccesoDatos.Contrato cli = new AccesoDatos.Contrato();
            try
            {
                cli = bbdd.Contrato.First(p => p.Numero == this.Numero);
                CommonBC.Syncronize(this, cli);
                bbdd.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Contrato> ReadByRut(string RutCliente)
        {
            AccesoDatos.OnBreakEntities bbdd = new AccesoDatos.OnBreakEntities();

            try
            {
                List<AccesoDatos.Contrato> listaDatos =
                    bbdd.Contrato.Where(b => b.RutCliente == RutCliente).ToList<AccesoDatos.Contrato>();

                List<Contrato> listaNegocio = GenerarLista(listaDatos);
                return listaNegocio;
            }
            catch (Exception ex)
            {
                return new List<Contrato>();
            }
        }
        public List<Contrato> ReadByNumeroContrato(string Numero)
        {
            AccesoDatos.OnBreakEntities bbdd = new AccesoDatos.OnBreakEntities();

            try
            {
                List<AccesoDatos.Contrato> listaDatos =
                    bbdd.Contrato.Where(b => b.Numero == Numero).ToList<AccesoDatos.Contrato>();

                List<Contrato> listaNegocio = GenerarLista(listaDatos);
                return listaNegocio;
            }
            catch (Exception ex)
            {
                return new List<Contrato>();
            }
        }
        public List<Contrato> ReadByTipoEvento(int idTipoEvento)
        {
            AccesoDatos.OnBreakEntities bbdd = new AccesoDatos.OnBreakEntities();

            try
            {
                List<AccesoDatos.Contrato> listaDatos =
                    bbdd.Contrato.Where(b => b.IdTipoEvento == idTipoEvento).ToList<AccesoDatos.Contrato>();

                List<Contrato> listaNegocio = GenerarLista(listaDatos);
                return listaNegocio;
            }
            catch (Exception ex)
            {
                return new List<Contrato>();
            }
        }
    }
}
