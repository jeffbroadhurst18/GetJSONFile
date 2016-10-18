using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetJSON
{

    public class Rootobject2
    {
        public Matchescompetition matchesCompetition { get; set; }
    }

    public class Matchescompetition
    {
        public string competition { get; set; }
        public string description { get; set; }
        public Match[] match { get; set; }
    }

    public class Match
    {
        public string id { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string status { get; set; }
        public string homeTeamNo { get; set; }
        public string homeTeamName { get; set; }
        public string homeTeamScore { get; set; }
        public string awayTeamScore { get; set; }
        public string awayTeamNo { get; set; }
        public string awayTeamName { get; set; }
        public string attendance { get; set; }
        public string homeTeamHalfTimeScore { get; set; }
        public string awayTeamHalfTimeScore { get; set; }
    }
}
