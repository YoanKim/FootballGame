using HomeworkFootball;
using System.Globalization;

namespace CleanProject
{
    public class Program
    {
        public static void Main()
        {
            // Team 1 (a)
            Goalkeeper player1a = new Goalkeeper("Bart", 1, 21, 185);
            Defender player2a = new Defender("Clark", 2, 30, 184);
            Defender player3a = new Defender("Clarker", 3, 29, 181);
            Defender player4a = new Defender("Clarkest", 4, 28, 182);
            Defender player5a = new Defender("Clarky", 5, 27, 183);
            Midfielder player6a = new Midfielder("Denis", 6, 25, 169);
            Midfielder player7a = new Midfielder("Denisan", 7, 31, 166);
            Midfielder player8a = new Midfielder("Denisto", 8, 34, 167);
            Midfielder player9a = new Midfielder("Denisian", 9, 33, 168);
            Striker player10a = new Striker("Eugene", 10, 24, 192);
            Striker player11a = new Striker("Eugenest", 11, 23, 191);
            List<FootballPlayer> playersa = new List<FootballPlayer> { player1a, player2a, player3a, player4a, player5a, player6a, player7a, player8a, player9a, player10a, player11a };

            // Team 2 (b)
            Goalkeeper player1b = new Goalkeeper("Francis", 13, 20, 193);
            Defender player2b = new Defender("Gustavo", 14, 31, 177);
            Defender player3b = new Defender("Gustavoien", 15, 31, 176);
            Defender player4b = new Defender("Gustavoest", 16, 27, 175);
            Defender player5b = new Defender("Gustavon", 17, 25, 174);
            Midfielder player6b = new Midfielder("Hank", 18, 35, 183);
            Midfielder player7b = new Midfielder("Hanker", 19, 34, 182);
            Midfielder player8b = new Midfielder("Hankie", 20, 32, 181);
            Midfielder player9b = new Midfielder("Hanky", 21, 31, 180);
            Striker player10b = new Striker("Ibrahim", 22, 33, 186);
            Striker player11b = new Striker("Ibrahimovich", 23, 25, 185);
            List<FootballPlayer> playersb = new List<FootballPlayer> { player1b, player2b, player3b, player4b, player5b, player6b, player7b, player8b, player9b, player10b, player11b };

            Coach coacha = new Coach("Andrey", 31);
            Coach coachb = new Coach("John", 26);

            Referee referee = new Referee("Keith", 44);

            List<Referee> assistantReferees = new List<Referee> {
                new Referee("Laura", 36),
                new Referee("Martin", 42)
            };   

            Team teama = new Team(coacha, playersa);
            Team teamb = new Team(coachb, playersb);

            double avgAge;
            avgAge = teama.CalculateAverageAge();
            Console.WriteLine("Average age of TeamA: " + Math.Round(avgAge, 2));
            avgAge = teamb.CalculateAverageAge();
            Console.WriteLine("Average age of TeamB: " + Math.Round(avgAge, 2));

            Game game = new Game(teama, teamb, referee, assistantReferees);

            game.AddGoal(15, player3a);
            game.AddGoal(26, player4b);
            game.AddGoal(43, player6a);
            game.AddGoal(68, player7b);
            game.AddGoal(77, player10b);
            game.AddGoal(89, player11a);
            game.AddGoal(91, player9b);

            game.PrintResult();
        }
    }
}