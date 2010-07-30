using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace License
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
        /// First name of user
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of user
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// User's Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Product license created for
        /// </summary>
        public ProductName Product { get; set; }

        public LicenseClass(DateTime created, DateTime goodTill, bool demo, string firstName, string lastName, string email, ProductName product)
        {
            CreatedOn = created;
            GoodTill = goodTill;
            Demo = demo;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Product = product;
        }

        LicenseClass()
        {
        }

    }

    public enum ProductName
    {
        CLIENT_TRACKER
    }
}
