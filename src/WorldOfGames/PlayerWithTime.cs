using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfGames
{
    [Serializable]
    public class PlayerWithTime :  ISerializable, IComparable
    {
        public string Name { get; set; }
        public int Time { get; set; }

        public PlayerWithTime(string name, int time)
        {
            Name = name;
            Time = time;
        }

        public int CompareTo(object obj)
        {
            PlayerWithTime pwt = obj as PlayerWithTime;
            if (pwt.Time != Time)
            {
                return Time - pwt.Time;
            }
            return Name.CompareTo(pwt.Name);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Name, Time);
        }

        //serializacija

        private PlayerWithTime(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("Name");
            Time = info.GetInt32("Time");
        }

        public void GetObjectData(SerializationInfo inf, StreamingContext con)
        {
            inf.AddValue("Name", Name);
            inf.AddValue("Time", Time);
        }
    }
}
