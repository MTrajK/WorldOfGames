using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfGames
{
    [Serializable]
    public class Records
    {
        /*public List<PlayerWithPoints> players = new List<PlayerWithPoints>();

        public Records()
        {
            List<Player> players = new List<Player>();
        }

        public void addPlayer(PlayerWithPoints player)
        {
            players.Add(player);
            players.Sort();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Math.Min(players.Count, 10); i++)
            {
                sb.Append(i + 1);
                sb.Append(" " + players[i] + "\n");
            }
            return sb.ToString();
        }

        private Records(SerializationInfo info, StreamingContext context)
        {
            players = (List<Player>)info.GetValue("players", typeof(List<Player>));
        }

        public void GetObjectData(SerializationInfo inf, StreamingContext con)
        {
            inf.AddValue("players", players);
        }*/
    }
}
