using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerUsingIEnumerable
{
    public class Player
    {
        private int runs;
        private string name;
        public Player(int runs, string name)
        {
            this.runs = runs;
            this.name = name;
        }

        public override string ToString()
        {
            return $"{runs} --> {name}";
        }

    }
    public class Team : IEnumerable
    {
        Player[] players;
        public Team()
        {
            players = new Player[6];
            players[0] = new Player(12000, "Sachin");
            players[1] = new Player(11000, "Dhoni");
            players[2] = new Player(10000, "Virat");
            players[3] = new Player(9000, "Rohit");
            players[4] = new Player(9500, "Hardik");
            players[5] = new Player(8000, "Jadeja");
        }

        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }
    }
}
