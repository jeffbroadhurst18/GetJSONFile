using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetJSON
{
    public class Rootobject
    {
        public Leaguetable leagueTable { get; set; }
    }

    public class Leaguetable
    {
        public string competition { get; set; }
        public string description { get; set; }
        public Team[] team { get; set; }
    }

    public class Team
    {
        public string position { get; set; }
        public string name { get; set; }
        public string played { get; set; }
        public string won { get; set; }
        public string drawn { get; set; }
        public string lost { get; set; }
        public string _for { get; set; }
        public string against { get; set; }
        public string goalDifference { get; set; }
        public string points { get; set; }
    }
}
