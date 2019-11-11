using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib
{
    class MatchupEntryModel
    {
        /// <summary>
        /// represents one team in the matchup.
        /// </summary>
        public TeamModel teamCompeting { get; set; }
        public double score { get; set; }
        public MatchupModel parentMatchup { get; set; }
    }
}
