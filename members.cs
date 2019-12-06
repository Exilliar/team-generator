using System;
using ExBasicFunctions;

namespace team_generator
{
    public class Members
    {
        private string[] names;

        public Members(string[] a, int maxPlaces)
        {
            if (a.Length != maxPlaces)
            {
                if (maxPlaces < a.Length)
                {
                    Console.WriteLine($"More names than team places available, only taking first {maxPlaces} names");

                    names = GetMax(a, maxPlaces);
                }
                else
                {
                    Console.WriteLine("Less names than team places available, remaining names will be blank");

                    names = FillNames(a,maxPlaces);
                }
            }
            else names = a;
        }

        public void RemoveMember(int namePos)
        {
            string[] newnames = new string[names.Length-1];
            int currentPos = 0;

            for (int i = 0; i < names.Length; i++)
            {
                if (i != namePos)
                {
                    newnames[currentPos] = names[i];
                    currentPos ++;
                }
            }

            names = newnames;
        }

        public int Length()
        {
            return names.Length;
        }

        public string GetName(int pos)
        {
            return names[pos];
        }

        private string[] GetMax(string[] a, int max)
        {
            string[] result = new string[max];

            result = Basic.FillArr(result,a,max);

            return result;
        }

        private string[] FillNames(string[] a, int max)
        {
            string[] result = new string[max];

            result = Basic.FillArr(result,a,a.Length);

            for (int b = max-a.Length; b < max; b++)
            {
                result[b] = "";
            }

            return result;
        }
    }
}