using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFootball
{
    public class FootballPlayer : Person
    {
        public int Number { get; private set; }
        public double Height { get; private set; }

        public FootballPlayer(string name, int number, int age, double height) : base(name, age)
        {
            Number = number;
            Height = height;
        }
    }
}
