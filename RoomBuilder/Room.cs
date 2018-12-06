using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBuilder
{
    public class Room
    {
        public string name;
        public string text;
        public List<object> connections;
        public List<object> items;
        public List<object> enemies;
        public List<object> secrets;
    }
}
