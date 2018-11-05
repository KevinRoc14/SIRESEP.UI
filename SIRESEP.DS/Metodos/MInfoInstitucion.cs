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
    public class MInfoInstitucion : IInfoInstitucion
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MInfoInstitucion()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public void ActualizarInfoInstitucion(InfoInstitucion InfoInstitucion)
        {
            //error posible
            _db.Update(InfoInstitucion);
        }

        public InfoInstitucion BuscarInfoInstitucion(int idInfoInstitucion)
        {
            return _db.Select<InfoInstitucion>(x => x.idInstitucion == idInfoInstitucion).FirstOrDefault();
        }

        public void EliminarInfoInstitucion(int idInfoInstitucion)
        {
            _db.Delete<InfoInstitucion>(x => x.idInstitucion == idInfoInstitucion);
        }

        public void InsertarInfoInstitucion(InfoInstitucion InfoInstitucion)
        {
            _db.Insert(InfoInstitucion);
        }

        public List<InfoInstitucion> ListarInfoInstitucion()
        {
            return _db.Select<InfoInstitucion>();
        }
    }
}
