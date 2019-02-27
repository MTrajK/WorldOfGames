using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfGames
{
    [Serializable]
    public abstract class Player : IComparable, ISerializable
    {
        public string Name { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        public abstract int CompareTo(object obj);

        //serializacija

        protected Player(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("Name");
        }

        public void GetObjectData(SerializationInfo inf, StreamingContext con)
        {
            inf.AddValue("Name", Name);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
