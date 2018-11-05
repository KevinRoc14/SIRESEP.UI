using SIRESEP.BS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DATOS;


namespace SIRESEP.BS.Metodos
{
    public class MInfoNacionalidad : IInfoNacionalidad
    {
        DS.Interfaces.IInfoNacionalidad carr;
        public MInfoNacionalidad()
        {
            carr = new DS.Metodos.MInfoNacionalidad();
        }
        public void ActualizarInfoNacionalidad(InfoNacionalidad InfoNacionalidad)
        {
            carr.ActualizarInfoNacionalidad(InfoNacionalidad);
        }

        public InfoNacionalidad BuscarInfoNacionalidad(int idInfoNacionalidad)
        {
            return carr.BuscarInfoNacionalidad(idInfoNacionalidad);
        }

        public void EliminarInfoNacionalidad(int idInfoNacionalidad)
        {
            carr.EliminarInfoNacionalidad(idInfoNacionalidad);
        }

        public void InsertarInfoNacionalidad(InfoNacionalidad InfoNacionalidad)
        {
            carr.InsertarInfoNacionalidad(InfoNacionalidad);
        }

        public List<InfoNacionalidad> ListarInfoNacionalidad()
        {
            return carr.ListarInfoNacionalidad();
        }
    }

}
