// See https://aka.ms/new-console-template for more information
using EjercicioHerencia;
using System.Drawing;





Vertebrado vertebrado = new Vertebrado();

vertebrado.nombre = "León";
vertebrado.color = "Amarillo";
vertebrado.tamano = "Grande";
vertebrado.familia = "Felidae";
vertebrado.tipo = "Mamifero";
vertebrado.tienePatas = true;
vertebrado.esDomestico = false;
vertebrado.esHerbivoro = false;
vertebrado.esCarnivoro = true;

if (vertebrado.validar())
{
    vertebrado.imprimirVertebrado();
    Console.WriteLine("Tipo: " + vertebrado.tipo);
    Console.WriteLine("Tiene patas: " + vertebrado.tienePatas);
    Console.WriteLine("Es domestico: " + vertebrado.esDomestico);
    Console.WriteLine("Es herviboro: " + vertebrado.esHerbivoro);
    Console.WriteLine("ES canivoro: " + vertebrado.esCarnivoro);
    Console.WriteLine();

}

else
{
    Console.WriteLine("Ingrese todos los datos");
}



Vertebrado vertebrado1 = new Vertebrado();

vertebrado1.nombre = "Aguila";
vertebrado1.color = "Marrón";
vertebrado1.tamano = "Mediano";
vertebrado1.familia = "Accipitridae";
vertebrado1.tipo = "Aves";
vertebrado1.tienePatas = true;
vertebrado1.esDomestico = false;
vertebrado1.esHerbivoro = false;
vertebrado1.esCarnivoro = true;

if (vertebrado.validar())
{
    vertebrado1.imprimirVertebrado();
    Console.WriteLine("Tipo: " + vertebrado1.tipo);
    Console.WriteLine("Tiene patas: " + vertebrado1.tienePatas);
    Console.WriteLine("Es domestico: " + vertebrado1.esDomestico);
    Console.WriteLine("Es herviboro: " + vertebrado1.esHerbivoro);
    Console.WriteLine("ES canivoro: " + vertebrado1.esCarnivoro);
    Console.WriteLine();
}
else
{
    Console.WriteLine("Ingrese todos los datos");
}

Invertebrado invertebrado1 = new Invertebrado();

invertebrado1.nombre = "Araña";
invertebrado1.color = "Negro";
invertebrado1.tamano = "Pequeño";
invertebrado1.familia = "Arachnida";
invertebrado1.tipo = "Arácnido";
invertebrado1.tienePatas = true;
invertebrado1.numeroPatas = 8;
invertebrado1.tieneConcha = false;

if (invertebrado1.validar())
{
    invertebrado1.imprimirInvertebrado();
    Console.WriteLine("Tipo: " + invertebrado1.tipo);
    Console.WriteLine("Tine patas: " + invertebrado1.tienePatas);
    Console.WriteLine("Numero de patas: " + invertebrado1.numeroPatas);
    Console.WriteLine("Tiene concha" + invertebrado1.tieneConcha);
    Console.WriteLine();

}
else
{
    Console.WriteLine(" Ingrese todos los datos");
}


Invertebrado invertebrado2 = new Invertebrado();

invertebrado2.nombre = "Caracol";
invertebrado2.color = "Marrón";
invertebrado2.tamano = "Pequeño";
invertebrado2.familia = "Mollusca";
invertebrado2.tipo = "Molusco";
invertebrado2.tienePatas = false;
invertebrado2.numeroPatas = 0;
invertebrado2.tieneConcha = true;

if (invertebrado2.validar())
{
    invertebrado2.imprimirInvertebrado();
    Console.WriteLine("Tipo: " + invertebrado2.tipo);
    Console.WriteLine("Tine patas: " + invertebrado2.tienePatas);
    Console.WriteLine("Numero de patas: " + invertebrado2.numeroPatas);
    Console.WriteLine("Tiene concha" + invertebrado2.tieneConcha);
    Console.WriteLine();

}
else
{
    Console.WriteLine(" Ingrese todos los datos");
}





