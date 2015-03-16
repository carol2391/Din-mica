using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPerrera
{
    class Program
    {
        static void Main(string[] args)
        {
            int intOpcion = 0;
	         do {
		 
                Console.WriteLine("Bienvenido al Veterinarium 9000");
		        Console.WriteLine("Seleccione una opcion: ");
                Console.WriteLine("1. para registrar duenios");
                Console.WriteLine("2. para registrar mascotas a duenios");
                Console.WriteLine("0. para salir");
              
		        switch(intOpcion) {
			    
                    case 1:
                        Console.Write("Ingrese nombre: ");
                        string Nombre = Console.ReadLine();
			        break;
			        
                    case 2:
				
			        break;
			        
                    case 3:
				    
                    break;
			        
                    case 4:
				    
                    break;
		          }

               Console.ReadLine();
		    }while(intOpcion != 0);

        }
    }
}
