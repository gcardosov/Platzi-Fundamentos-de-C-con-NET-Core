using System;
<<<<<<< HEAD
using CoreEscuela.Entidades;

namespace Etapa1
{
=======

namespace CoreEscuela
{

    class Escuela
    {
       public string nombre;

        public string direccion;

        public int añoFundacion;

        public string CEO;

        public void Timbrar()
        {
            //TODO
            Console.Beep(20000, 3000); 

        }


    }


>>>>>>> a02cdac015d5cfc1b09373df12f4a48bc53a9a09
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            var escuela = new Escuela("Platzi Academy", 2012);
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Bogota";
            
            Console.WriteLine(escuela.Nombre);
=======

            var miEscuela = new Escuela();

            miEscuela.nombre = "Platzi Academy";

            miEscuela.direccion = "Cr 9 calle 72";

            miEscuela.añoFundacion = 2012;

            Console.WriteLine("TIMBRE");

            miEscuela.Timbrar();

            //Console.WriteLine("Hello World!");
    
>>>>>>> a02cdac015d5cfc1b09373df12f4a48bc53a9a09
        }
    }
}
