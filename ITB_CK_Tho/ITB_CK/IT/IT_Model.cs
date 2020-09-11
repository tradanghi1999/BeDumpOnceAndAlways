using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using DatabaseHandle.Model;
using static PointScreen.Model;

namespace IT
{
    public class IT_Model
    {
        public class ResultDetail
        {
            public string ID { get; set; }
            //public string TeamId { get; set; }
            //public string QuestionId { get; set; }

            //public string TeamName { get; set; }
            public Team Team { get; set; }
            public int RoundNum { get; set; }
            public int QuestionNum { get;set;}
            public Question Question { get; set; }
            public int Point { get; set; }
            public int Score { get; set; }
            //public int Score { get; set; }
            public bool IsCorrect { get; set; }
        }

        public class Host
        {
            public string Id { get; set; }
            public string ProgramName { get; set; }
            public string HostName { get; set; }
            public bool IsConnected { get; set; }
        }
    }
}
