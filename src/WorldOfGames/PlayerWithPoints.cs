using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfGames
{
    [Serializable]
    public class PlayerWithPoints :  ISerializable, IComparable
    {
        public string Name { get; set; }
        public long Points { get; set; }

        public PlayerWithPoints(string name, long points)
        {
            Name = name;
            Points = points;
        }

        public int CompareTo(object obj)
        {
            PlayerWithPoints pwp = obj as PlayerWithPoints;
            if (pwp.Points != Points)
            {
                return (int) (pwp.Points - Points);
            }
            if (pwp == null) return 0;
            return 0; 
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}", Name, Points.ToString());
        }

        //serializacija

        private PlayerWithPoints(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("Name");
            Points = info.GetInt32("Points");
        }

        public void GetObjectData(SerializationInfo inf, StreamingContext con)
        {
            inf.AddValue("Name", Name);
            inf.AddValue("Points", Points);
        }
    }
}
