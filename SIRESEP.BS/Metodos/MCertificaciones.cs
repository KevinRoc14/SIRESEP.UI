using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DATOS;
using SIRESEP.BS.Interfaces;
namespace SIRESEP.BS.Metodos
{
    public class MCertificaciones : ICertificaciones
    {
        DS.Interfaces.ICertificaciones cert;
        public MCertificaciones()
        {
            cert = new DS.Metodos.MCertificaciones();
        }

        public void ActualizarCertificacion(Certificaciones certificacion)
        {
            cert.ActualizarCertificacion(certificacion);
        }

        public Certificaciones BuscarCertificacion(int idCertificacion)
        {
            return cert.BuscarCertificacion(idCertificacion);
        }

        public void EliminarCertificacion(int idCertificacion)
        {
            cert.EliminarCertificacion(idCertificacion);
        }

        public void InsertarCertificacion(Certificaciones certificacion)
        {
            cert.InsertarCertificacion(certificacion);
        }

        public List<Certificaciones> ListarCertificaciones()
        {
            return cert.ListarCertificaciones();
        }
    }
}
