using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPerrera
{
    #region Autor Cindy Carolina Alonzo
    #endregion
    /*La funcionalidad de esta clase es gestionar las mascotas que tiene un dueño
      así mismo como tambien mostrar la información personal del dueño.
     */
    public class Duenio
    {
        #region Atributos
        private String strNombre;
        private String strTelefono;
        private String strDireccion;
        private List<Mascota> listaMascota;
        #endregion
        #region Constructor
        /* constructor que recibe los atributos del objeto dueño, con el objetivo
         * de instanciar las propiedades del dueño
         */
            public Duenio(String strNombre, String strDireccion, String strTelefono)
            {
                this.strNombre = strNombre;
                this.strDireccion = strDireccion;
                this.strTelefono = strTelefono;
            }
       #endregion
        #region Agregar Mascota
         /*Metodo que agrega a la lista de mascotas que tiene el dueño una mascota
          * recibe como parametro los atributos de la mascota.
          */
        public bool agregarMascota() {

            return false;
        }
        #endregion
    }
}
