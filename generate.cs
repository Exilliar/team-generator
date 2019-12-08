using System;
using ExBCSL;

namespace team_generator
{
    class Generate
    {
        static void Main(string[] args)
        {
            int numTeams = BRead.getInt("Number of teams: ");

            int numMembers = BRead.getInt("Number of members in each team: ");

            int maxMembers = numMembers*numTeams;

            string[] allNames = BRead.getString("First names of the members: ").Split(' ');

            Members mems = new Members(allNames,maxMembers);

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
    }
}