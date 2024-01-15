using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono tel1 = new Telefono("A30s", "samsung");

            Console.WriteLine("Marca : " + tel1.Marca);
            Console.WriteLine("Modelo : " + tel1.Modelo);
            Console.WriteLine("Numero : " + tel1.NumeroTelefonico);
            Console.WriteLine("(sin asignar)Codigo Operador : " + tel1.CodigoOperador);

            tel1.CodigoOperador = 8;
            Console.WriteLine("(asignando 8)Codigo Operador : " + tel1.CodigoOperador);

            tel1.CodigoOperador = 1;
            Console.WriteLine("(asignando 1)Codigo Operador : " + tel1.CodigoOperador);

            Console.WriteLine(tel1.Llamar());
            Console.WriteLine(tel1.Llamar("0303456"));
        }
    }
}
