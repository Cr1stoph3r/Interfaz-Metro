using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class ActividadEmpresa
    {
        public int IdActividadEmpresa{ get; set; }
        public string Descripcion { get; set; }

        public ActividadEmpresa()
        {
            this.Init();
        }

        private void Init()
        {
            IdActividadEmpresa = 0;
            Descripcion = string.Empty;
        }

        public bool Read()
        {
            AccesoDatos.OnBreakEntities bbdd = new AccesoDatos.OnBreakEntities();

            try
            {
                AccesoDatos.ActividadEmpresa act = bbdd.ActividadEmpresa.First(tb => tb.IdActividadEmpresa == IdActividadEmpresa);
                CommonBC.Syncronize(act, this);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<ActividadEmpresa> ReadAll()
        {
            AccesoDatos.OnBreakEntities bbdd = new AccesoDatos.OnBreakEntities();

            try
            {
                List<AccesoDatos.ActividadEmpresa> listaDatos = bbdd.ActividadEmpresa.ToList<AccesoDatos.ActividadEmpresa>();
                List<ActividadEmpresa> listaNegocio = GenerarListado(listaDatos);

                return listaNegocio;

            }
            catch (Exception ex)
            {
                return new List<ActividadEmpresa>();
            }
        }
        private List<ActividadEmpresa> GenerarListado(List<AccesoDatos.ActividadEmpresa> listaDatos)
        {
            List<ActividadEmpresa> listaNegocio = new List<ActividadEmpresa>();

            foreach (AccesoDatos.ActividadEmpresa datos in listaDatos)
            {
                ActividadEmpresa negocio = new ActividadEmpresa();
                CommonBC.Syncronize(datos, negocio);

                listaNegocio.Add(negocio);
            }

            return listaNegocio;
        }
    }
}
