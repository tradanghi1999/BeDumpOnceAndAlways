using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointScreen
{
    public class Model
    {
        public class Team : ITeam,ITeamAdapter
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public int Score { get; set; }
            public string Round1State { get; set; }
            public string Round2State { get; set; }
            public string Round3State { get; set; }
            public DateTime LastModified { get; set; }
        }

        public interface ITeam
        {

        }
        public interface ITeamAdapter
        {

        }
    }
}
