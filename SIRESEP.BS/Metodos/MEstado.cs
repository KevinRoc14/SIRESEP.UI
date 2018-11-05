using SIRESEP.BS.Interfaces;
using SIRESEP.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.BS.Metodos
{
    public class MEstado : IEstado
    {
        DS.Interfaces.IEstado carr;
        public MEstado()
        {
            carr = new DS.Metodos.MEstado();
        }
        public void ActualizarEstado(Estado Estado)
        {
            carr.ActualizarEstado(Estado);
        }

        public Estado BuscarEstado(int idEstado)
        {
            return carr.BuscarEstado(idEstado);
        }

        public void EliminarEstado(int idEstado)
        {
            carr.EliminarEstado(idEstado);
        }

        public void InsertarEstado(Estado Estado)
        {
            carr.InsertarEstado(Estado);
        }

        public List<Estado> ListarEstado()
        {
            return carr.ListarEstado();
        }
    }
}
