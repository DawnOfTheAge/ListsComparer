using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_Comparer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> l2 = new List<int>() { 5, 6, 7, 8, 9 };

            var any = l2.Where(item => l1.Contains(item));

            foreach (var item in any)
            {
                Console.WriteLine((int)item);
            }

            Console.ReadLine();
        }
    }
}
