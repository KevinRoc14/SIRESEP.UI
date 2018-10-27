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
    public class MInfoGradoEstudio : IInfoGradoEstudio
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MInfoGradoEstudio()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void ActualizarGradoEstudio(InfoGradoEstudio gradoestudio)
        {
            _db.Update(gradoestudio);
        }

        public InfoGradoEstudio BuscarGradoEstudio(int idGradoEstudio)
        {
            return _db.Select<InfoGradoEstudio>(x => x.idGradoEstudio == idGradoEstudio).FirstOrDefault();
        }

        public void EliminarGradoEstudio(int idGradoEstudio)
        {
            _db.Delete<InfoGradoEstudio>(x => x.idGradoEstudio == idGradoEstudio);
        }

        public void InsertarGradoEstudio(InfoGradoEstudio gradoestudio)
        {
            _db.Insert(gradoestudio);
        }

        public List<InfoGradoEstudio> ListarGradoEstudio()
        {
            return _db.Select<InfoGradoEstudio>();
        }
    }
}
