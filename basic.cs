using System;

namespace ExBasicFunctions
{
    public class Basic
    {
        public static int getInt(string msg)
        {
            return Int32.Parse(getString(msg));
        }

        public static string getString(string msg)
        {
            Console.Write(msg);

            return Console.ReadLine();
        }

        public static string[] FillArr(string[] a0, string[] a1, int limit)
        {
            for (int i = 0; i < limit; i++)
            {
                a0[i] = a1[i];
            }

            return a0;
        }
    }
}