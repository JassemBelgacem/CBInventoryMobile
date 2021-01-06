using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace InventoryCB.models
{
    public class User
    {
        /// <summary>
        /// user name
        /// </summary>
        public string login { set; get; }
        
        /// <summary>
        /// User password
        /// </summary>
        public string password { set; get; }

        #region Ctor
        
        public User() {}

        public User(String login, string password) 
        {
            this.login = login;
            this.password = password;
        }

        #endregion
        
    }
}
