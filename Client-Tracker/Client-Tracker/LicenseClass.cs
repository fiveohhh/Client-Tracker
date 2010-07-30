using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client_Tracker
{
    /// <summary>
    /// Contains data for licensing info
    /// </summary>
    public class LicenseClass
    {
        /// <summary>
        /// date time the license was created on
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// date time the license will be good till
        /// </summary>
        public DateTime GoodTill { get; set; }

        /// <summary>
        /// Is this restricted to demo features
        /// </summary>
        public bool Demo { get; set; }

        /// <summary>
        /// Name of user
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// User's Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Product license created for
        /// </summary>
        public ProductName Product { get; set; }

    }

    public enum ProductName
    {
        CLIENT_TRACKER
    }
}
