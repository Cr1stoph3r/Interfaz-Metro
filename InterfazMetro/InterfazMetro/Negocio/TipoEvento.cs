using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class TipoEvento
    {
        public int IdTipoEvento { get; set; }
        public string Descripcion { get; set; }

        public TipoEvento()
        {
            this.Init();
        }

        private void Init()
        {
            IdTipoEvento = 0;
            Descripcion = string.Empty;
        }

        public bool Read()
        {
            AccesoDatos.OnBreakEntities bbdd = new AccesoDatos.OnBreakEntities();

            try
            {
                AccesoDatos.TipoEvento act = bbdd.TipoEvento.First(tb => tb.IdTipoEvento == IdTipoEvento);
                CommonBC.Syncronize(act, this);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<TipoEvento> ReadAll()
        {
            AccesoDatos.OnBreakEntities bbdd = new AccesoDatos.OnBreakEntities();

            try
            {
                List<AccesoDatos.TipoEvento> listaDatos = bbdd.TipoEvento.ToList<AccesoDatos.TipoEvento>();
                List<TipoEvento> listaNegocio = GenerarListado(listaDatos);

                return listaNegocio;

            }
            catch (Exception ex)
            {
                return new List<TipoEvento>();
            }
        }
        private List<TipoEvento> GenerarListado(List<AccesoDatos.TipoEvento> listaDatos)
        {
            List<TipoEvento> listaNegocio = new List<TipoEvento>();

            foreach (AccesoDatos.TipoEvento datos in listaDatos)
            {
                TipoEvento negocio = new TipoEvento();
                CommonBC.Syncronize(datos, negocio);

                listaNegocio.Add(negocio);
            }

            return listaNegocio;
        }
    }
}
