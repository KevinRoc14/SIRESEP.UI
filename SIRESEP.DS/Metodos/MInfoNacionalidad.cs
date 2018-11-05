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
    public class MInfoNacionalidad : IInfoNacionalidad
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MInfoNacionalidad()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public void ActualizarInfoNacionalidad(InfoNacionalidad InfoNacionalidad)
        {
            //error posible
            _db.Update(InfoNacionalidad);
        }

        public InfoNacionalidad BuscarInfoNacionalidad(int idInfoNacionalidad)
        {
            return _db.Select<InfoNacionalidad>(x => x.idNacionalidad == idInfoNacionalidad).FirstOrDefault();
        }

        public void EliminarInfoNacionalidad(int idInfoNacionalidad)
        {
            _db.Delete<InfoNacionalidad>(x => x.idNacionalidad == idInfoNacionalidad);
        }

        public void InsertarInfoNacionalidad(InfoNacionalidad InfoNacionalidad)
        {
            _db.Insert(InfoNacionalidad);
        }

        public List<InfoNacionalidad> ListarInfoNacionalidad()
        {
            return _db.Select<InfoNacionalidad>();
        }
    }
}
