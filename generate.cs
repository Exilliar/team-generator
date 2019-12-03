using System;

namespace team_generator
{
    class Generate
    {
        static void Main(string[] args)
        {
            int numTeams = getInt("Number of teams: ");

            int numMembers = getInt("Number of members in each team: ");

            int maxMembers = numMembers*numTeams;

            Members mems = new Members(getString("First names of the members: ").Split(' '),maxMembers);

            Teams teams = new Teams(numTeams,numMembers);

            for (int i = 0; i < numTeams; i++)
            {
                for (int a = 0; a < numMembers; a++)
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