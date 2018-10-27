using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DATOS;
namespace SIRESEP.BS.Interfaces
{
    public interface IInfoGenero
    {
        List<InfoGenero> ListarInfoGenero();
        InfoGenero BuscarInfoGenero(int idGenero);
        void InsertarInfoGenero(InfoGenero infogenero);
        void ActualizarInfoGenero(InfoGenero infogenero);
        void EliminarInfoGenero(int idGenero);
    }
}
