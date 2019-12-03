using System;

namespace team_generator
{
    public class Members
    {
        private string[] arr;

        public Members(string[] a)
        {
            arr = a;
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
    }
}