using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFootball
{
    public class Team
    {
        public Coach Coach { get; private set; }
        private List<FootballPlayer> players;
        public List<FootballPlayer> Players
        {
            get 
            { 
                List<FootballPlayer> temp = new List<FootballPlayer>();
                foreach (FootballPlayer player in players)
                {
                    temp.Add(player);
                }
                return temp;
            }
            private set
            {
                if (value.Count < 11 || value.Count > 22)
                {
                    throw new Exception("Players are not between 11 and 22!");
                }
                players = value;
            }
        }

        public Team(Coach coach, List<FootballPlayer> players)
        {
            Coach = coach;
            Players = players;
        }

        public double CalculateAverageAge()
        {
            int totalAge = 0;
            foreach (FootballPlayer player in Players)
            {
                totalAge += player.Age;
            }
            return (double)totalAge / Players.Count;
        }
    }
}
