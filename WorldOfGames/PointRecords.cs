using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfGames
{
    [Serializable]
    public class PointRecords
    {
        public List<PlayerWithPoints> players = new List<PlayerWithPoints>();

        public PointRecords()
        {
            players = new List<PlayerWithPoints>();
        }

        public void addPlayer(PlayerWithPoints player)
        {
            players.Add(player);
            players.Sort();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Rank\tPlayer\tPoints\n\n");
            for (int i = 0; i < Math.Min(players.Count, 10); i++)
            {
                sb.Append(string.Format("{0}\t{1}", (i + 1),  players[i]) + "\n");
            }
            return sb.ToString();
        }

        private PointRecords(SerializationInfo info, StreamingContext context)
        {
            players = (List<PlayerWithPoints>)info.GetValue("players", typeof(List<Player>));
        }

        public void GetObjectData(SerializationInfo inf, StreamingContext con)
        {
            inf.AddValue("players", players);
        }
    }
}
