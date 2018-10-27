using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DATOS;

namespace SIRESEP.BS.Interfaces
{
    public interface IInfoPuesto
    {
        List<InfoPuesto> ListarInfoPuesto();
        InfoPuesto BuscarInfoPuesto(int idPuesto);
        void InsertarInfoPuesto(InfoPuesto infopuesto);
        void ActualizarInfoPuesto(InfoPuesto infopuesto);

        void EliminarInfoPuesto(int idPuesto);
    }
}
