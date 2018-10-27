using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DATOS;
using SIRESEP.BS.Interfaces;

namespace SIRESEP.BS.Metodos
{
    public class MCarrera : ICarrera
    {
        DS.Interfaces.ICarrera carr;
        public MCarrera()
        {
            carr = new DS.Metodos.MCarrera();
        }
        public void ActualizarCarrera(Carrera carrera)
        {
            carr.ActualizarCarrera(carrera);
        }

        public Carrera BuscarCarrera(int idCarrera)
        {
            return carr.BuscarCarrera(idCarrera);
        }

        public void EliminarCarrera(int idCarrera)
        {
            carr.EliminarCarrera(idCarrera);
        }

        public void InsertarCarrera(Carrera carrera)
        {
            carr.InsertarCarrera(carrera);
        }

        public List<Carrera> ListarCarrera()
        {
            return carr.ListarCarrera();
        }
    }
}
