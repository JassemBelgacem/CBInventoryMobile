using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using InventoryCB.Business.Service.Abstract;
using InventoryCB.models;
using System.Data.SqlServerCe;

namespace InventoryCB.Business.Service.Concret
{
    class AuthentificationService : IAuthentificationService
    {

        #region IAuthentificationService Members

        /// <summary>
        /// Find a user in the dataBase
        /// </summary>
        /// <param name="login">userName</param>
        /// <param name="password">the Password</param>
        /// <returns>User si l'utlisateur existe sinon null</returns>
        User IAuthentificationService.findUser(string login, string password)
        {
            SqlCeConnection conn = null;
            User user = null;

            try
            {

                string sqlconnection = ("Data Source ="
                       + (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\InventoryDB.sdf;"));


                using (conn = new SqlCeConnection(sqlconnection))
                {
                    conn.Open();

                    string sql = "select * from Users where Login ='" + login + "' And Password = '" + password + "' ";
                    SqlCeCommand cmdGetAll = new SqlCeCommand(sql, conn);
                    SqlCeDataReader reader = cmdGetAll.ExecuteReader();

                    while (reader.Read())
                    {
                        user = new User(reader[1].ToString(), reader[2].ToString());


                    }
                }
            }
            finally
            {
                conn.Close();
            }

            return user;
        }

        #endregion
    }
}
