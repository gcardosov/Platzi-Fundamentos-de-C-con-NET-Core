﻿using System;

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


    class Program
    {
        static void Main(string[] args)
        {

            var miEscuela = new Escuela();

            miEscuela.nombre = "Platzi Academy";

            miEscuela.direccion = "Cr 9 calle 72";

            miEscuela.añoFundacion = 2012;

            Console.WriteLine("TIMBRE");

            miEscuela.Timbrar();

            //Console.WriteLine("Hello World!");
    
        }
    }
}
