using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nTermsNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, terms;

            Console.WriteLine("Veuillez entrez le n termes de nombre natuels");
            try
            {
                terms = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Veuillez recommencer");
                terms = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 1; i <= terms; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }

            Console.WriteLine("\nThe Sum is : " + sum);
            Console.ReadLine();
        }
    }
}
