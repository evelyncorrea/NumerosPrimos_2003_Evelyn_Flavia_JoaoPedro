using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerosprimos_2003_Evelyn_Flavia_JoaoPedro
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaNumerosPrimos numbers = new ListaNumerosPrimos();
            int Limit = int.Parse(Console.ReadLine());
            Console.WriteLine("Limit's User " + Limit);
            numbers.Lista(Limit);
            numbers.Primos();
            Console.WriteLine(numbers.PrintPrimos());
            Console.ReadKey();
        }
    }
}
