using System; // import
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4 
{
    class Program
    {

        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {Lib1.MathLibrary.Add(a,b)}");
            Console.ReadKey();
        }
    }
}
