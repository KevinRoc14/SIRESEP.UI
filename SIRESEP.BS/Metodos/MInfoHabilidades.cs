using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DATOS;
using SIRESEP.BS.Interfaces;
namespace SIRESEP.BS.Metodos
{
    public class MInfoHabilidades : IInfoHabilidades
    {
        DS.Interfaces.IInfoHabilidades habi;
        public MInfoHabilidades()
        {
            habi = new DS.Metodos.MInfoHabilidades();
        }
        public void ActualizarHabilidad(InfoHabilidad habilidad)
        {
            habi.ActualizarHabilidad(habilidad);
        }

        public InfoHabilidad BuscarHabilidad(int idHabilidad)
        {
            return habi.BuscarHabilidad(idHabilidad);
        }

        public void EliminarHabilidad(int idHabilidad)
        {
            habi.EliminarHabilidad(idHabilidad);
        }

        public void InsertarHabilidad(InfoHabilidad habilidad)
        {
            habi.InsertarHabilidad(habilidad);
        }

        public List<InfoHabilidad> ListarHabilidades()
        {
            return habi.ListarHabilidades();
        }
    }
}
