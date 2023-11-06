using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Invertebrado : Animal
    {
        public string? tipo {  get; set; }
        public bool tienePatas { get; set; }
        public int numeroPatas { get; set; }
        public bool tieneConcha {  get; set; }

        public void imprimirInvertebrado()
        {
            imprimir();
            Console.WriteLine("Tipo: " +  tipo);
            Console.WriteLine("Tiene patas: " +  tienePatas);
            Console.WriteLine("Numero de patas " +  numeroPatas);
            Console.WriteLine("Tiene concha: " + tieneConcha);
        }

    }
}
