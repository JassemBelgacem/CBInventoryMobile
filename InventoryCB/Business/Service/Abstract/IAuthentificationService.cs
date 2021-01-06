using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InventoryCB.models;

namespace InventoryCB.Business.Service.Abstract
{
    public interface IAuthentificationService
    {
        /// <summary>
        /// Find a user in the dataBase
        /// </summary>
        /// <param name="login">userName</param>
        /// <param name="password">the Password</param>
        /// <returns>User si l'utlisateur existe sinon null</returns>
          User findUser(String login, String password);
    }
}
