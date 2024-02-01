using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] Persone = new int[366];
            double[] Probabilita = new double[366];

            for (int i = 2; i < 366; i++)
            {
                int cont = 0; 

                for (int j = 0; j < 10000; j++)
                {
                    for (int p = 0; p < i; p++)
                    {
                        Persone[p] = random.Next(366);
                    }

                    for (int g = 0; g < i; g++)
                    {
                        for (int f = g + 1; f < i; f++)
                        {
                            if (Persone[g] == Persone[f])
                            {
                                cont = 1;
                            }
                        }
                    }

                    if (cont == 1)
                    {
                        Probabilita[i]++;
                    }

                    cont = 0;
                }

                Probabilita[i] = Probabilita[i] / 10000;
                Console.WriteLine("{0}", Probabilita[i]);
            }

            Console.ReadLine();
        }
    }
}

