using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// represent the tournament format
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// the tournament name
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// what the entryfee for players is
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// a list over the teams
        /// </summary>
        public List<TeamModel> EntryTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// a list over prizes
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel> ();
        /// <summary>
        /// a list over matchups
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set;} = new List<List<MatchupModel>> ();
    }
}
