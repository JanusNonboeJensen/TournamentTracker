using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// the place number
        /// for exampel number 1 would be the winner
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// the name of the placed player
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// represents the prize amount
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// represent the percantage of the cash prize
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
