using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Vertebrado : Animal
    {
        public string? tipo {  get; set; }
        public bool tienePatas { get; set; }
        public bool esDomestico { get; set; }

        public bool esHerbivoro {  get; set; }
        public bool esCarnivoro {  get; set; }

        public void imprimirVertebrado()
        {
            imprimir();
            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("Tiene patas: " +  tienePatas);
            Console.WriteLine("Es doméstico: " + esDomestico);
            Console.WriteLine("Es hervíboro: " + esHerbivoro);
            Console.WriteLine("Es carnívoro: " + esCarnivoro);
        }
    }

}
