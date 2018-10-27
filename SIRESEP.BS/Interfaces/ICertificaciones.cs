using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DATOS;

namespace SIRESEP.BS.Interfaces
{
    public interface ICertificaciones
    {
        List<Certificaciones> ListarCertificaciones();
        Certificaciones BuscarCertificacion(int idCertificacion);
        void InsertarCertificacion(Certificaciones certificacion);
        void ActualizarCertificacion(Certificaciones certificacion);
        void EliminarCertificacion(int idCertificacion);
    }
}
