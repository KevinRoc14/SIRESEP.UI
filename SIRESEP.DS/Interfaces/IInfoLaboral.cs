using SIRESEP.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DS.Interfaces
{
    public interface IInfoLaboral
    {
        List<InfoLaboral> ListarInfoLaboral();
        InfoLaboral BuscarInfoLaboral(int idInfoLaboral);
        void InsertarInfoLaboral(InfoLaboral InfoLaboral);
        void ActualizarInfoLaboral(InfoLaboral InfoLaboral);
        void EliminarInfoLaboral(int idInfoLaboral);
    }
}
