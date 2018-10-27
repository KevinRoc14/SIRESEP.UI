using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DATOS;
namespace SIRESEP.DS.Interfaces
{
    public interface IInfoGradoEstudio
    {
        List<InfoGradoEstudio> ListarGradoEstudio();
        InfoGradoEstudio BuscarGradoEstudio(int idGradoEstudio);
        void InsertarGradoEstudio(InfoGradoEstudio gradoestudio);
        void ActualizarGradoEstudio(InfoGradoEstudio gradoestudio);
        void EliminarGradoEstudio(int idGradoEstudio);
    }
}
