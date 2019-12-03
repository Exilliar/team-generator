using System;

namespace team_generator
{
    class Generate
    {
        static void Main(string[] args)
        {
            int numTeams = getInt("Number of teams: ");

            int numMemebers = getInt("Number of members in each team: ");

            Members mems = new Members(getString("Names of the members: ").Split(' '));

            Teams teams = new Teams(numTeams,numMemebers);

            for (int i = 0; i < numTeams; i++)
            {
                for (int a = 0; a < numMemebers; a++)
                {
                    Random rand = new Random();

                    int namePos = rand.Next(mems.Length());

                    teams.SetPos(i,a,mems.GetName(namePos));

                    mems.RemoveMember(namePos);
                }
            }

            teams.Print();
        }

        static int getInt(string msg)
        {
            Console.Write(msg);

            return Int32.Parse(Console.ReadLine());
        }

        static string getString(string msg)
        {
            Console.Write(msg);

            return Console.ReadLine();
        }
    }
}