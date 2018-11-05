using SIRESEP.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DS.Interfaces
{
    public interface IEstado
    {
        List<Estado> ListarEstado();
        Estado BuscarEstado(int idEstado);
        void InsertarEstado(Estado Estado);
        void ActualizarEstado(Estado Estado);
        void EliminarEstado(int idEstado);
    }
}
