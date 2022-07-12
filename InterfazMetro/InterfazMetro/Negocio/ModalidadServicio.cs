using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ModalidadServicio
    {
        string _descripcionEvento;
        public String IdModalidad { get; set; }
        public int IdTipoEvento { get; set; }
        public string Nombre { get; set; }
        public float ValorBase { get; set; }
        public int PersonalBase { get; set; }
        public string DescripcionEvento { get { return _descripcionEvento; } }
        public ModalidadServicio()
        {
            this.Init();
        }

        private void Init()
        {
            IdModalidad = string.Empty;
            IdTipoEvento = 0;
            Nombre = string.Empty;
            ValorBase = 0;
            PersonalBase = 0;
            _descripcionEvento = string.Empty;
        }

        public bool Read()
        {
            AccesoDatos.OnBreakEntities bbdd = new AccesoDatos.OnBreakEntities();

            try
            {
                AccesoDatos.ModalidadServicio act = bbdd.ModalidadServicio.First(tb => tb.IdModalidad == IdModalidad);
                CommonBC.Syncronize(act, this);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<ModalidadServicio> ReadAll()
        {
            AccesoDatos.OnBreakEntities bbdd = new AccesoDatos.OnBreakEntities();

            try
            {
                List<AccesoDatos.ModalidadServicio> listaDatos = bbdd.ModalidadServicio.ToList<AccesoDatos.ModalidadServicio>();
                List<ModalidadServicio> listaNegocio = GenerarListado(listaDatos);

                return listaNegocio;

            }
            catch (Exception ex)
            {
                return new List<ModalidadServicio>();
            }
        }
        public void LeerDescripcion()
        {
            TipoEvento act = new TipoEvento() { IdTipoEvento = IdTipoEvento };
            if(act.Read())
            {
                _descripcionEvento = act.Descripcion;
            }
            else
            {
                _descripcionEvento = string.Empty;
            }
        }
        private List<ModalidadServicio> GenerarListado(List<AccesoDatos.ModalidadServicio> listaDatos)
        {
            List<ModalidadServicio> listaNegocio = new List<ModalidadServicio>();

            foreach (AccesoDatos.ModalidadServicio datos in listaDatos)
            {
                ModalidadServicio negocio = new ModalidadServicio();
                CommonBC.Syncronize(datos, negocio);
                negocio.LeerDescripcion();
                listaNegocio.Add(negocio);
            }

            return listaNegocio;
        }
    }
}
