using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DATOS;
using SIRESEP.BS.Interfaces;

namespace SIRESEP.BS.Metodos
{
    public class MInfoPuesto : IInfoPuesto
    {
        DS.Interfaces.IInfoPuesto info;
        public MInfoPuesto()
        {
            info = new DS.Metodos.MInfoPuesto();
        }

        public void ActualizarInfoPuesto(InfoPuesto infopuesto)
        {
            info.ActualizarInfoPuesto(infopuesto);
        }

        public InfoPuesto BuscarInfoPuesto(int idPuesto)
        {
            return info.BuscarInfoPuesto(idPuesto);
        }

        public void EliminarInfoPuesto(int idPuesto)
        {
            info.EliminarInfoPuesto(idPuesto);
        }

        public void InsertarInfoPuesto(InfoPuesto infopuesto)
        {
            info.InsertarInfoPuesto(infopuesto);
        }

        public List<InfoPuesto> ListarInfoPuesto()
        {
            return info.ListarInfoPuesto();
        }
    }
}
