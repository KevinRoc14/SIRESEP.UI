using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DATOS;
namespace SIRESEP.DS.Interfaces
{
    public interface ICarrera
    {
        List<Carrera> ListarCarrera();
        Carrera BuscarCarrera(int idCarrera);
        void InsertarCarrera(Carrera carrera);
        void ActualizarCarrera(Carrera carrera);
        void EliminarCarrera(int idCarrera);
    }
}
