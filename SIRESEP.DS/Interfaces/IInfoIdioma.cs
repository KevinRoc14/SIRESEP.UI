using SIRESEP.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DS.Interfaces
{
    public interface IInfoIdioma
    {
        List<InfoIdioma> ListarInfoIdioma();
        InfoIdioma BuscarInfoIdioma(int idInfoIdioma);
        void InsertarInfoIdioma(InfoIdioma InfoIdioma);
        void ActualizarInfoIdioma(InfoIdioma InfoIdioma);
        void EliminarInfoIdioma(int idInfoIdioma);
    }
}
