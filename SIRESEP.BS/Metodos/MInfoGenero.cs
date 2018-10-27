using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DATOS;
using SIRESEP.BS.Interfaces; 
namespace SIRESEP.BS.Metodos
{
    public class MInfoGenero : IInfoGenero
    {
        DS.Interfaces.IInfoGenero infog;
        public MInfoGenero()
        {
            infog = new DS.Metodos.MInfoGenero();
        }

        public void ActualizarInfoGenero(InfoGenero infoGenero)
        {
            infog.ActualizarInfoGenero(infoGenero);
        }

        public InfoGenero BuscarInfoGenero(int idGenero)
        {
            return infog.BuscarInfoGenero(idGenero);
        }

        public void EliminarInfoGenero(int idGenero)
        {
            infog.EliminarInfoGenero(idGenero);
        }

        public void InsertarInfoGenero(InfoGenero infoGenero)
        {
            infog.InsertarInfoGenero(infoGenero);
        }

        public List<InfoGenero> ListarInfoGenero()
        {
            return infog.ListarInfoGenero();
        }
    }
}
