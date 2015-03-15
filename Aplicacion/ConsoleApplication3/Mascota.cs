using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPerrera
{
   public class Mascota
    {
        private String strNombre;
        private int intEdad;
        private String strRaza;


        public Mascota(String nombre, int edad, String raza)
        {
            this.strNombre = nombre;
            this.strRaza = raza;
            this.intEdad = edad;
        }


        public string Nombre
        {
            set
            {
                strNombre = value;
            }

            get
            {
                return strNombre;
            }

        }




        public string Raza
        {

            set
            {
                strRaza = value;
            }

            get
            {
                return strRaza;
            }

        }


        public int Edad
        {
            set
            {
                intEdad = value;
            }

            get
            {
                return intEdad;
            }


        }


    }
}
