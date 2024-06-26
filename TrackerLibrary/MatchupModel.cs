﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// represents one match in a tournament
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// the sets of teams that where involved in this match 
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// The winner of the match
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// which round this match was part of
        /// </summary>
        public int MatchupRound { get; set; }

    }
}
