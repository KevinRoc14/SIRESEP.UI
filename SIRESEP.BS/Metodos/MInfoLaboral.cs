using SIRESEP.BS.Interfaces;
using SIRESEP.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.BS.Metodos
{
    public class MInfoLaboral : IInfoLaboral
    {
        DS.Interfaces.IInfoLaboral carr;
        public MInfoLaboral()
        {
            carr = new DS.Metodos.MInfoLaboral();
        }
        public void ActualizarInfoLaboral(InfoLaboral InfoLaboral)
        {
            carr.ActualizarInfoLaboral(InfoLaboral);
        }

        public InfoLaboral BuscarInfoLaboral(int idInfoLaboral)
        {
            return carr.BuscarInfoLaboral(idInfoLaboral);
        }

        public void EliminarInfoLaboral(int idInfoLaboral)
        {
            carr.EliminarInfoLaboral(idInfoLaboral);
        }

        public void InsertarInfoLaboral(InfoLaboral InfoLaboral)
        {
            carr.InsertarInfoLaboral(InfoLaboral);
        }

        public List<InfoLaboral> ListarInfoLaboral()
        {
            return carr.ListarInfoLaboral();
        }
    }
}
