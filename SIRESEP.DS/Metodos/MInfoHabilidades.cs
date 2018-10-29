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
    public class MInfoHabilidades : IInfoHabilidades
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MInfoHabilidades()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
               SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void ActualizarHabilidad(InfoHabilidad habilidad)
        {
            _db.Update(habilidad);
        }

        public InfoHabilidad BuscarHabilidad(int idHabilidad)
        {
            return _db.Select<InfoHabilidad>(x => x.idHabilidad == idHabilidad).FirstOrDefault();
        }

        public void EliminarHabilidad(int idHabilidad)
        {
            _db.Delete<InfoHabilidad>(x => x.idHabilidad == idHabilidad);
        }

        public void InsertarHabilidad(InfoHabilidad habilidad_)

        {
            _db.Insert(habilidad_);
        }

        public List<InfoHabilidad> ListarHabilidades()
        {
            return _db.Select<InfoHabilidad>();
        }
    }
}
