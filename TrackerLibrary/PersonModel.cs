using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// represent one person
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The firstname of the person
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// last name of the person
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// emailaddress of the person
        /// </summary>
        public string EmailAdress { get; set; }
        /// <summary>
        /// phone number of the person
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
