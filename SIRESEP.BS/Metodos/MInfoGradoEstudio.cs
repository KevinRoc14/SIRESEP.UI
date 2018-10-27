using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DATOS;
using SIRESEP.BS.Interfaces;

namespace SIRESEP.BS.Metodos
{
    public class MInfoGradoEstudio : IInfoGradoEstudio
    {
        DS.Interfaces.IInfoGradoEstudio grado;
        public MInfoGradoEstudio()
        {
            grado = new DS.Metodos.MInfoGradoEstudio();
        }
        public void ActualizarGradoEstudio(InfoGradoEstudio gradoestudio)
        {
            grado.ActualizarGradoEstudio(gradoestudio);
        }

        public InfoGradoEstudio BuscarGradoEstudio(int idGradoEstudio)
        {
            return grado.BuscarGradoEstudio(idGradoEstudio);
        }

        public void EliminarGradoEstudio(int idGradoEstudio)
        {
            grado.EliminarGradoEstudio(idGradoEstudio);
        }

        public void InsertarGradoEstudio(InfoGradoEstudio gradoestudio)
        {
            grado.InsertarGradoEstudio(gradoestudio);
        }

        public List<InfoGradoEstudio> ListarGradoEstudio()
        {
            return grado.ListarGradoEstudio();
        }
    }
}
