using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one team in a matchup
    /// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        /// reprsent one team  in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// represents the score for this particular team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// represents the matchup this team came from 
        /// as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="initialScore"></param>
    
    }

}
