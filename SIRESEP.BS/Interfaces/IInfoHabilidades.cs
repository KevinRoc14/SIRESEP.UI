using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DATOS;
namespace SIRESEP.BS.Interfaces
{
    public interface IInfoHabilidades
    {
        List<InfoHabilidad> ListarHabilidades();
        InfoHabilidad BuscarHabilidad(int idHabilidad);
        void InsertarHabilidad(InfoHabilidad habilidad);
        void ActualizarHabilidad(InfoHabilidad habilidad);
        void EliminarHabilidad(int idHabilidad);
    }
}
