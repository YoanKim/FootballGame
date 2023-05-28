using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFootball
{
    public class Game
    {
        public Team TeamA { get; private set; }
        public Team TeamB { get; private set; }
        public Referee Referee { get; private set; }
        public List<Referee> AssistantReferees { get; private set; }
        public List<(int Minute, FootballPlayer Player)> Goals { get; private set; }
        public Team Winner { get; private set; }
        int teama, teamb;

        public Game(Team teama, Team teamb, Referee referee, List<Referee> assistantReferees)
        {
            if (teama.Players.Count != 11 || teamb.Players.Count != 11)
            {
                throw new Exception("Game cannot start when players are not equal to 11!");
            }
            TeamA = teama;
            TeamB = teamb;
            Referee = referee;
            AssistantReferees = assistantReferees;
            Goals = new List<(int Minute, FootballPlayer Player)>();
        }

        public void AddGoal(int minute, FootballPlayer player)
        {
            Goals.Add((minute, player));
            teama += Convert.ToInt32(TeamA.Players.Where(p => p.Number == player.Number).FirstOrDefault() != null);
            teamb += Convert.ToInt32(TeamB.Players.Where(p => p.Number == player.Number).FirstOrDefault() != null);
            if (teama > teamb) { Winner = TeamA; }
            else if (teamb > teama) { Winner = TeamB; }
            else { Winner = null; }
        }

        public void PrintResult()
        {
            Console.WriteLine("\nGame Result:");
            Console.WriteLine("\nTeam 1's Coach: " + TeamA.Coach.Name);
            Console.Write("Players: ");
            foreach (FootballPlayer player in TeamA.Players)
            {
                Console.Write(player.Name + "; ");
            }
            Console.WriteLine("\n\nTeam 2's Coach: " + TeamB.Coach.Name);
            Console.Write("Players: ");
            foreach (FootballPlayer player in TeamB.Players)
            {
                Console.Write(player.Name + "; ");
            }
            Console.WriteLine("\n\nReferee: " + Referee.Name);
            Console.Write("Assistant Referees: ");
            foreach (Referee assistantReferee in AssistantReferees)
            {
                Console.Write(assistantReferee.Name + "; ");
            }
            Console.WriteLine("\n\nGoals:");
            foreach (var goal in Goals)
            {
                Console.WriteLine("Minute: " + goal.Minute + " by " + goal.Player.Name + ";");
            }
            Console.WriteLine("\nWinner: <[ " + (Winner != null ? Winner.Coach.Name + "'s Team ]>" : "DRAW ]>"));
        }
    }
}
