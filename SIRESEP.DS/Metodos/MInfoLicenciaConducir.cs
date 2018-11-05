using ServiceStack.OrmLite;
using SIRESEP.DATOS;
using SIRESEP.DS.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DS.Metodos
{
    public class MInfoLicenciaConducir : IInfoLicenciaConducir
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MInfoLicenciaConducir()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public void ActualizarInfoLicenciaConducir(InfoLicenciaConducir InfoLicenciaConducir)
        {
            //error posible
            _db.Update(InfoLicenciaConducir);
        }

        public InfoLicenciaConducir BuscarInfoLicenciaConducir(int idInfoLicenciaConducir)
        {
            return _db.Select<InfoLicenciaConducir>(x => x.idLicenciaConducir == idInfoLicenciaConducir).FirstOrDefault();
        }

        public void EliminarInfoLicenciaConducir(int idInfoLicenciaConducir)
        {
            _db.Delete<InfoLicenciaConducir>(x => x.idLicenciaConducir == idInfoLicenciaConducir);
        }

        public void InsertarInfoLicenciaConducir(InfoLicenciaConducir InfoLicenciaConducir)
        {
            _db.Insert(InfoLicenciaConducir);
        }

        public List<InfoLicenciaConducir> ListarInfoLicenciaConducir()
        {
            return _db.Select<InfoLicenciaConducir>();
        }

    }
}
