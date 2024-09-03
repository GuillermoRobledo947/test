using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono telefono1 = new Telefono("a10", "Samsung")
            {
                numeroTelefonico = 1168700251,
                codigoOperador = 1
            };

            Console.WriteLine("El modelo del telefono es un " + telefono1.getModelo() +
                              ", su marca es " + telefono1.getMarca() +
                              ", su numero es " + telefono1.numeroTelefonico +
                              ", su codigo de Operador es " + telefono1.getCodigoOperador());
            Console.WriteLine(telefono1.llamar("maxi"));
            Console.ReadKey();
        }
    }
}