using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Animal
    {
        public string? nombre {  get; set; }
        public string? color { get; set; }
        public string? tamano { get; set; }
        public string? familia { get; set; }

        public void imprimir()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Color: " +  color);
            Console.WriteLine("Tamaño: " +  tamano);
            Console.WriteLine("Familia: " +  familia);
            
        }

        public bool validar()
        {
            if (nombre != null && color != null && tamano != null && familia != null) { 
            
                return true;

            }
            else
            {
                return false;
            }
        }
       
    }



   
}
