using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// represents the teams
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// the list of persons on the team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// the teams name
        /// </summary>
        public string TeamName { get; set; }
        
    }
}
