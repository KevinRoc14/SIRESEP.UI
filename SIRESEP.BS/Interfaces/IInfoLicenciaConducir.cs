using SIRESEP.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.BS.Interfaces
{
    public interface IInfoLicenciaConducir
    {
        List<InfoLicenciaConducir> ListarInfoLicenciaConducir();
        InfoLicenciaConducir BuscarInfoLicenciaConducir(int idInfoLicenciaConducir);
        void InsertarInfoLicenciaConducir(InfoLicenciaConducir InfoLicenciaConducir);
        void ActualizarInfoLicenciaConducir(InfoLicenciaConducir InfoLicenciaConducir);
        void EliminarInfoLicenciaConducir(int idInfoLicenciaConducir);
    }
}
