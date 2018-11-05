using SIRESEP.BS.Interfaces;
using SIRESEP.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.BS.Metodos
{
    public class MInfoIdioma : IInfoIdioma
    {
        DS.Interfaces.IInfoIdioma carr;
        public MInfoIdioma()
        {
            carr = new DS.Metodos.MInfoIdioma();
        }
        public void ActualizarInfoIdioma(InfoIdioma InfoIdioma)
        {
            carr.ActualizarInfoIdioma(InfoIdioma);
        }

        public InfoIdioma BuscarInfoIdioma(int idInfoIdioma)
        {
            return carr.BuscarInfoIdioma(idInfoIdioma);
        }

        public void EliminarInfoIdioma(int idInfoIdioma)
        {
            carr.EliminarInfoIdioma(idInfoIdioma);
        }

        public void InsertarInfoIdioma(InfoIdioma InfoIdioma)
        {
            carr.InsertarInfoIdioma(InfoIdioma);
        }

        public List<InfoIdioma> ListarInfoIdioma()
        {
            return carr.ListarInfoIdioma();
        }
    }
}
