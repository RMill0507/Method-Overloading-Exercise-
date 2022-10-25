using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    public class Program
    {






        static void Main(string[] args)
        {

            //var answer = Add(2, 2);
            //Console.WriteLine(answer);
            var answer = Add(3, 5, true);
            {

                Console.WriteLine(answer);
            }

        }
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x = y;
        }
        public static string Add(int x, int y, bool withDollars)

        {
            if (withDollars && (x + y) != 1)
            {
                return $"{x + y} dollars";

            }
            else if (withDollars && (x + y) == 1)
            {
                return $"{x + y} dollar";
            }
            else
            {
                return $"{x = y}";
            }





        }


    }
}
