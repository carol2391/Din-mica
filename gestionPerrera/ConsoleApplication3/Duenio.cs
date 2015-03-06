using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPerrera
{
    public class Duenio
    {
        private String strNombre;
        private String strTelefono;
        private String strDireccion;
        private List<Mascota> listaMascota;

        public Duenio(String strNombre, String strDireccion, String strTelefono)
        {
            this.strNombre = strNombre;
            this.strDireccion = strDireccion;
            this.strTelefono = strTelefono;
        }
	


    }
}
