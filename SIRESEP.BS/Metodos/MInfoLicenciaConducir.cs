using SIRESEP.BS.Interfaces;
using SIRESEP.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.BS.Metodos
{
    public class MInfoLicenciaConducir : IInfoLicenciaConducir
    {
        DS.Interfaces.IInfoLicenciaConducir carr;
        public MInfoLicenciaConducir()
        {
            carr = new DS.Metodos.MInfoLicenciaConducir();
        }
        public void ActualizarInfoLicenciaConducir(InfoLicenciaConducir InfoLicenciaConducir)
        {
            carr.ActualizarInfoLicenciaConducir(InfoLicenciaConducir);
        }

        public InfoLicenciaConducir BuscarInfoLicenciaConducir(int idInfoLicenciaConducir)
        {
            return carr.BuscarInfoLicenciaConducir(idInfoLicenciaConducir);
        }

        public void EliminarInfoLicenciaConducir(int idInfoLicenciaConducir)
        {
            carr.EliminarInfoLicenciaConducir(idInfoLicenciaConducir);
        }

        public void InsertarInfoLicenciaConducir(InfoLicenciaConducir InfoLicenciaConducir)
        {
            carr.InsertarInfoLicenciaConducir(InfoLicenciaConducir);
        }

        public List<InfoLicenciaConducir> ListarInfoLicenciaConducir()
        {
            return carr.ListarInfoLicenciaConducir();
        }
    }
}
