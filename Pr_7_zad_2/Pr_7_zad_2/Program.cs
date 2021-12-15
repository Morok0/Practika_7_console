using System;
using System.Linq;
using System.Text;
namespace Pr_7_zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int buf = 0;
            string str = "";
            string[] s;
            str = Console.ReadLine();
            s = str.Split();
            for (int i = 0; i < s.Length; i++)
            {
                buf = s[i].Length;
                for (int j = 0; j < s[i].Length; j++)
                {
                    if (char.IsUpper(s[i][j]))
                    {
                        for (int z = 0; z < s[i].Length; z++)
                        {
                            if (s[i][z] != ',')
                                    if (s[i][z] != '.')
                                                Console.Write(s[i][z]);
                        }
                        Console.WriteLine();
                    }
                }

            }
               
        }
    }
}
