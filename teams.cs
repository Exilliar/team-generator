using System;

namespace team_generator
{
    public class Teams
    {
        string[,] arr;

        public Teams(int a, int b)
        {
            arr = new string[a,b];
        }

        public void Print()
        {
            for (int a = 0; a < arr.GetLength(0); a++)
            {
                Console.WriteLine($"\nTeam {a+1}");
                for (int b = 0; b < arr.GetLength(1); b++)
                {
                    Console.Write(arr[a,b] + " ");
                }
            }
        }

        public void SetPos(int a, int b, string val)
        {
            arr[a,b] = val;
        }
    }
}