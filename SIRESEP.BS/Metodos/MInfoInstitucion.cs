using SIRESEP.BS.Interfaces;
using SIRESEP.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.BS.Metodos
{
    public class MInfoInstitucion : IInfoInstitucion
    {
        DS.Interfaces.IInfoInstitucion carr;
        public MInfoInstitucion()
        {
            carr = new DS.Metodos.MInfoInstitucion();
        }
        public void ActualizarInfoInstitucion(InfoInstitucion InfoInstitucion)
        {
            carr.ActualizarInfoInstitucion(InfoInstitucion);
        }

        public InfoInstitucion BuscarInfoInstitucion(int idInfoInstitucion)
        {
            return carr.BuscarInfoInstitucion(idInfoInstitucion);
        }

        public void EliminarInfoInstitucion(int idInfoInstitucion)
        {
            carr.EliminarInfoInstitucion(idInfoInstitucion);
        }

        public void InsertarInfoInstitucion(InfoInstitucion InfoInstitucion)
        {
            carr.InsertarInfoInstitucion(InfoInstitucion);
        }

        public List<InfoInstitucion> ListarInfoInstitucion()
        {
            return carr.ListarInfoInstitucion();
        }
    }
}
