﻿using System.Collections.Generic;
using System.Linq;
using SIRESEP.DATOS;
using SIRESEP.DS.Interfaces;
using System.Data;
using ServiceStack.OrmLite;

namespace SIRESEP.DS.Metodos
{
    public class MInfoGenero : IInfoGenero
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MInfoGenero()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public void ActualizarInfoGenero(InfoGenero infoGenero)
        {
            _db.Update(infoGenero);
        }

        public InfoGenero BuscarInfoGenero(int idGenero)
        {
            return _db.Select<InfoGenero>(x => x.idGenero == idGenero).FirstOrDefault();

        }

        public void EliminarInfoGenero(int idGenero)
        {
            _db.Delete<InfoGenero>(x => x.idGenero == idGenero);
        }

        public void InsertarInfoGenero(InfoGenero infoGenero)
        {
            _db.Insert(infoGenero);
        }

        public List<InfoGenero> ListarInfoGenero()
        {
            return _db.Select<InfoGenero>();
        }
    }
}
