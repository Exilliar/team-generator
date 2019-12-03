using System;

namespace team_generator
{
    public class Members
    {
        private string[] arr;

        public Members(string[] a, int maxPlaces)
        {
            if (a.Length != maxPlaces)
            {
                if (maxPlaces < a.Length)
                {
                    Console.WriteLine($"More names than team places available, only taking first {maxPlaces} names");

                    arr = GetMax(a, maxPlaces);
                }
                else
                {
                    Console.WriteLine("Less names than team places available, remaining names will be blank");

                    arr = FillArr(a,maxPlaces);
                }
            }
            else
            {
                arr = a;
            }
        }

        public void RemoveMember(int namePos)
        {
            string[] newArr = new string[arr.Length-1];
            int currentPos = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i != namePos)
                {
                    newArr[currentPos] = arr[i];
                    currentPos ++;
                }
            }

            arr = newArr;
        }

        public int Length()
        {
            return arr.Length;
        }

        public string GetName(int pos)
        {
            return arr[pos];
        }

        private static string[] GetMax(string[] a, int max)
        {
            string[] result = new string[max];

            for (int i = 0; i < max; i++)
            {
                result[i] = a[i];
            }

            return result;
        }

        private static string[] FillArr(string[] a, int max)
        {
            string[] result = new string[max];

            for (int i = 0; i < a.Length; i++)
            {
                result[i] = a[i];
            }

            for (int b = max-a.Length; b < max; b++)
            {
                result[b] = "";
            }

            return result;
        }
    }
}