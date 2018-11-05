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
    public class MInfoLaboral : IInfoLaboral
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MInfoLaboral()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public void ActualizarInfoLaboral(InfoLaboral InfoLaboral)
        {
            //error posible
            _db.Update(InfoLaboral);
        }

        public InfoLaboral BuscarInfoLaboral(int idInfoLaboral)
        {
            return _db.Select<InfoLaboral>(x => x.idInfoLaboral == idInfoLaboral).FirstOrDefault();
        }

        public void EliminarInfoLaboral(int idInfoLaboral)
        {
            _db.Delete<InfoLaboral>(x => x.idInfoLaboral == idInfoLaboral);
        }

        public void InsertarInfoLaboral(InfoLaboral InfoLaboral)
        {
            _db.Insert(InfoLaboral);
        }

        public List<InfoLaboral> ListarInfoLaboral()
        {
            return _db.Select<InfoLaboral>();
        }
    }
}
