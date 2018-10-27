using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DATOS;
using SIRESEP.DS.Interfaces;
using ServiceStack.OrmLite;
using System.Data;

namespace SIRESEP.DS.Metodos
{
    public class MInfoPuesto : IInfoPuesto
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MInfoPuesto()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public void ActualizarInfoPuesto(InfoPuesto infopuesto)
        {
            _db.Update(infopuesto);
        }

        public InfoPuesto BuscarInfoPuesto(int idPuesto)
        {
            return _db.Select<InfoPuesto>(x => x.idPuesto== idPuesto).FirstOrDefault();

        }

        public void EliminarInfoPuesto(int idPuesto)
        {
            _db.Delete<InfoPuesto>(x => x.idPuesto == idPuesto);
        }

        public void InsertarInfoPuesto(InfoPuesto infopuesto)
        {
            _db.Insert(infopuesto);
        }

        public List<InfoPuesto> ListarInfoPuesto()
        {
            return _db.Select<InfoPuesto>();
        }
    }
}
