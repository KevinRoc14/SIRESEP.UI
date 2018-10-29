using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DS.Interfaces;
using SIRESEP.DATOS;
using ServiceStack.OrmLite;
using System.Data;

namespace SIRESEP.DS.Metodos
{
    public class MCarrera : ICarrera
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MCarrera()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public void ActualizarCarrera(Carrera carrera)
        {
            //error posible
            _db.Update(carrera);
        }

        public Carrera BuscarCarrera(int idCarrera)
        {
            return _db.Select<Carrera>(x => x.idCarrera == idCarrera).FirstOrDefault();
        }

        public void EliminarCarrera(int idCarrera)
        {
            _db.Delete<Carrera>(x => x.idCarrera == idCarrera);
        }

        public void InsertarCarrera(Carrera carrera)
        {
            _db.Insert(carrera);
        }

        public List<Carrera> ListarCarrera()
        {
            return _db.Select<Carrera>();
        }
    }
}
