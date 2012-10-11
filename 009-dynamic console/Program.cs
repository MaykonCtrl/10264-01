using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _009_dynamic_console
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic i = Criar();
            i.Imprimir();
            Console.ReadKey();
        }

        private static Object Criar()
        {
            int x = new Random().Next(1, 5);

            Object retorno = new Etiquetadora();

            switch (x)
            {
             
                case 1: retorno = new Monitor(); break;
                case 2: retorno = new Impressora(); break;

            }

            return retorno;
        }

    }


    interface IImpressora
    {
        void Imprimir();
    }

    class Monitor : IImpressora
    {
        public  void Imprimir() { Console.WriteLine("Monitor.Imprimir()"); }
    }


    class Impressora : IImpressora
    {
        public void Imprimir() { Console.WriteLine("Impressora.Imprimir()"); }
    }

    class Etiquetadora
    {
        public void Imprimir() { Console.WriteLine("Etiquetadora.Imprimir()"); }
    }

}
