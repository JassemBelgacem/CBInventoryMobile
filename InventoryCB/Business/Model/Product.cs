using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace InventoryCB.Model
{
    public class Product
    {   
        /// <summary>
        /// Product reference
        /// </summary>
        public String reference { get; set;}

        /// <summary>
        /// Product name
        /// </summary>
        public String name { get; set; }
        
        /// <summary>
        /// Product picture URL
        /// </summary>
        public String picture { get; set; }
        
        /// <summary>
        /// Product expiry Date
        /// </summary>
        public DateTime expiryDate { get; set; }

        #region Ctor

        public Product (String reference,String name, String picture, DateTime expiryDate) {
            this.reference = reference;
            this.name = name;
            this.picture = picture;
            this.expiryDate = expiryDate;

        #endregion
        }

    }
}
