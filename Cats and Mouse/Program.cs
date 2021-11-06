using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats_and_Mouse
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                string result = catAndMouse(x, y, z);
                Console.WriteLine(result);
            }
        }

        static string catAndMouse(int x, int y, int z)
        {
            int distCat1 = Math.Abs(x - z);
            int distCat2 = Math.Abs(y - z);
            if (distCat1 < distCat2)
                return "Cat A";
            else if (distCat1 > distCat2)
                return "Cat B";
            else
                return "Mouse C";

        }
    }
}
