using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.OrmLite;
using SIRESEP.DATOS;
using SIRESEP.DS.Interfaces;

namespace SIRESEP.DS.Metodos
{
    public class MCertificaciones : ICertificaciones
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MCertificaciones()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public void ActualizarCertificacion(Certificaciones certificacion)
        {
            _db.Update(certificacion);
        }

        public Certificaciones BuscarCertificacion(int idCertificacion)
        {
            return _db.Select<Certificaciones>(x => x.idCertificacion == idCertificacion).FirstOrDefault();
        }

        public void EliminarCertificacion(int idCertificacion)
        {
            _db.Delete<Certificaciones>(x => x.idCertificacion == idCertificacion);
        }

        public void InsertarCertificacion(Certificaciones certificacion)
        {
            _db.Insert(certificacion);
        }

        public List<Certificaciones> ListarCertificaciones()
        {
            return _db.Select<Certificaciones>();
        }
    }
}
