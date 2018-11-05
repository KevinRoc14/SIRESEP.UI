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
    public class MEstado : IEstado
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MEstado()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public void ActualizarEstado(Estado Estado)
        {
            //error posible
            _db.Update(Estado);
        }

        public Estado BuscarEstado(int idEstado)
        {
            return _db.Select<Estado>(x => x.idEstado == idEstado).FirstOrDefault();
        }

        public void EliminarEstado(int idEstado)
        {
            _db.Delete<Estado>(x => x.idEstado == idEstado);
        }

        public void InsertarEstado(Estado Estado)
        {
            _db.Insert(Estado);
        }

        public List<Estado> ListarEstado()
        {
            return _db.Select<Estado>();
        }
    }
}
