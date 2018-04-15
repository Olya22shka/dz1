using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
 
                Console.WriteLine("Input n: ");
                string inputN = Console.ReadLine();
                int n;
                bool parseResult = int.TryParse(inputN, out n);
                if (!parseResult)
                {
                    Console.WriteLine("Error while parsing text to number");
                    return;
                }
                if (n < 1 || n >= 100)
                {
                    Console.WriteLine("Wrong number limits");
                    return;
                }
                Console.WriteLine("Input text: ");
                string str = Console.ReadLine();
                if (str.Length != n)
                {
                    Console.WriteLine("Input string does not match input length");
                    return;
                }
                char[] changedStr = new Char[n];
                var counter = 0;
                for (int i = 0; i < n; i++)
                {
                    if (i + 1 >= n)
                    {
                        changedStr[counter] = str[i];
                        break;
                    }
                    var diagonalCondition1 = str[i] == 'R' && str[i + 1] == 'U';
                    var diagonalCondition2 = str[i] == 'U' && str[i + 1] == 'R';
                    if (diagonalCondition1 || diagonalCondition2)
                    {
                        changedStr[counter] = 'D';
                        counter++;
                        i++;
                    }
                    else
                    {
                        changedStr[counter] = str[i];
                        counter++;
                    }
                }
                Console.WriteLine(changedStr);
                Console.ReadKey();
          
        }
    }
}
