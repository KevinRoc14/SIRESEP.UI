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
    public class MInfoIdioma : IInfoIdioma
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MInfoIdioma()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public void ActualizarInfoIdioma(InfoIdioma InfoIdioma)
        {
            //error posible
            _db.Update(InfoIdioma);
        }

        public InfoIdioma BuscarInfoIdioma(int idInfoIdioma)
        {
            return _db.Select<InfoIdioma>(x => x.idIdioma == idInfoIdioma).FirstOrDefault();
        }

        public void EliminarInfoIdioma(int idInfoIdioma)
        {
            _db.Delete<InfoIdioma>(x => x.idIdioma == idInfoIdioma);
        }

        public void InsertarInfoIdioma(InfoIdioma InfoIdioma)
        {
            _db.Insert(InfoIdioma);
        }

        public List<InfoIdioma> ListarInfoIdioma()
        {
            return _db.Select<InfoIdioma>();
        }
    }
}
