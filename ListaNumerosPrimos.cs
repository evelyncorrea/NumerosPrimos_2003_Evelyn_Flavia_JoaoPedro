using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerosprimos_2003_Evelyn_Flavia_JoaoPedro
{
    class ListaNumerosPrimos
    {
       public List<int> nprimos = new List<int>();

       public void Lista(int n)
       {
           for (int i = 2; i <= n; i++)
           {
               nprimos.Add(i);
               //Console.WriteLine(i);
           }
       }

        public void Primos()
       {
           for (int i = 0; i < nprimos.Count; i++)
           {
               int ElementList = nprimos.ElementAt(i);

               for (int j = i + 1; j < nprimos.Count; j++)
               {
                   int DivisibleElements = nprimos.ElementAt(j);

                   if (DivisibleElements % ElementList == 0)
                   {
                       nprimos.RemoveAt(j);
                   }
               }
           }
       }
        public string PrintPrimos()
        {
           string primeNumbersPrinted = "Prime Numbers: ";            
            foreach (var item in nprimos)
            {
                primeNumbersPrinted += item + " ; ";
		 
	        }
            return primeNumbersPrinted;
        }
    }
}
