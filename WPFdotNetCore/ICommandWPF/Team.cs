using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICommandWPF
{
    public class Team
    {
        public string TeamID { get; set; }
        public string TeamName { get; set; }
        public int Point { get; set; }
        public Team(string id, string name, int point)
        {
            TeamID = id;
            TeamName = name;
            Point = point;
        }
        public override string ToString()
        {
            return "Team "+TeamID+", Name "+TeamName+", Point " + Point;
        }
    }
}
