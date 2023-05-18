using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamePlayer
{
    public class Player
    {
        public PlayerType Type { get; set; }
        public string Name { get; set; }

        public Player(PlayerType type, string name)
        {
            Type = type;
            Name = name;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Player);
        }

        public bool Equals(Player p)
        {
            if (p != null)
                return (this.Name == p.Name) ^ (this.Type == p.Type);

            else return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Type, Name);
        }
    }
}