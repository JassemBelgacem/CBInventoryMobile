using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using InventoryCB.Model;
using System.Net;
using System.IO;
using System.Data.SqlServerCe;
using InventoryCB.Business.Service.Abstract;


namespace InventoryCB.Business.Service.Concret
{
   public class ProductService : IProductService
    {
        #region IProductService Members

        /// <summary>
        /// Fuction to get inforamtion from WorldOpenFoodFacts
        /// </summary>
        /// <param name="reference">Prouct refernce</param>
        /// <param name="expiryDate">Expiry Date</param>
        /// <returns></returns>
        public Product GetProductInfo(string reference, DateTime expiryDate)
        {
            string name = string.Empty;
            string picture = string.Empty;
            WebResponse response = null;         
                       
            string Uri = "https://world.openfoodfacts.org/api/v0/product/" + reference + ".json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Uri);
            request.Method = "GET";
            request.ContentType = "application/json";
            try

            { 
                 response = request.GetResponse();
            }
            catch (Exception ex)
            {
               return null;
            }
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                string line = reader.ReadLine();
                

                if (line.IndexOf("\"generic_name_en\":") != 0)
                {
                    int indexName = line.IndexOf("\"generic_name_en\":") + 19;
                    string stringAfterName = line.Substring(indexName, line.Length - indexName - 2);
                    int indexNameValue = stringAfterName.IndexOf(",");
                    name = stringAfterName.Substring(0, indexNameValue - 1);                                       
                }

                if (line.IndexOf("image_small_url") != 0)
                {
                    int indexPicture = line.IndexOf("image_small_url") + 18;
                    string stringAfterPicture = line.Substring(indexPicture, line.Length - indexPicture - 2);

                    int indexPictureValue = stringAfterPicture.IndexOf(",");
                    picture = stringAfterPicture.Substring(0, indexPictureValue - 1);                    
                }
            }
            return new Product(reference, name, picture, expiryDate);

        }

        /// <summary>
        /// Serch a Product in DataBase
        /// </summary>
        /// <param name="reference">Prouct refernce</param>
        /// <param name="expiryDate">Expiry Date</param>
        /// <returns></returns>
        public Product FindProductByReference(string reference)
        {
            SqlCeConnection conn = null;
            Product product = null;

            try
            {
                string sqlconnection = ("Data Source ="
                     + (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\InventoryDB.sdf;"));


                using (conn = new SqlCeConnection(sqlconnection))
                {
                    conn.Open();

                    string sql = "select * from Products where Reference ='" + reference + "'";   
                    SqlCeCommand cmdGetAll = new SqlCeCommand(sql, conn);
                    SqlCeDataReader reader = cmdGetAll.ExecuteReader();
                    while (reader.Read())
                    {
                        product = new Product(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), Convert.ToDateTime(reader[3].ToString()));
                        

                    }
                }
            }
            finally
            {
                conn.Close();
            }

            return product;
        }

        /// <summary>
        /// Procedure that add a new product 
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product)
        {
            SqlCeConnection conn = null;
            string sqlconnection = ("Data Source ="
                   + (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\InventoryDB.sdf;"));
            
            try
            {

                using (conn = new SqlCeConnection(sqlconnection))
                {
                    conn.Open();

                    SqlCeCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO Products ([Reference], [Name], [Picture], [ExpiryDate]) Values('" +
                        product.reference + "','" +
                        product.name + "','" +
                        product.picture + "','" +
                        product.expiryDate + "')";

                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Fuctio that returns the list of produts from database
        /// </summary>
        /// <returns>Lise of product</returns>
        public List<Product> GetAllPorducts()
        {
            List<Product> allProd = new List<Product>();

            SqlCeConnection conn = null;

            try
            {
                string sqlconnection = ("Data Source ="
                     + (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\InventoryDB.sdf;"));


                using (conn = new SqlCeConnection(sqlconnection))
                {
                    conn.Open();

                    string sql = "select * from Products";
                    SqlCeCommand cmdGetAll = new SqlCeCommand(sql, conn);
                    SqlCeDataReader reader = cmdGetAll.ExecuteReader();
                    while (reader.Read())
                    {
                        Product prod = new Product(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), Convert.ToDateTime(reader[3].ToString()));
                        allProd.Add(prod);

                    }
                }
            }
            finally
            {
                conn.Close();
            }

            return allProd;
        }

        /// <summary>
        /// Procedure to update the expiry date of a product 
        /// </summary>
        /// <param name="reference">the product's reference</param>
        /// <param name="expiryData">the expiry date</param>
        public void UpdateExipryDate(string reference, DateTime expiryData)
        {

            SqlCeConnection conn = null;

            try
            {
                string sqlconnection = ("Data Source ="
                   + (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\InventoryDB.sdf;"));

                using (conn = new SqlCeConnection(sqlconnection))
                {
                    conn.Open();

                    SqlCeCommand cmd = conn.CreateCommand();

                    cmd.CommandText= "select * from Products where Reference ='" + reference + "'";                                         

                    SqlCeResultSet rs = cmd.ExecuteResultSet(ResultSetOptions.Updatable |
                        ResultSetOptions.Scrollable);

                    SqlCeUpdatableRecord rec = rs.CreateRecord();
                    if (true == rs.ReadAbsolute(0))
                    {
                        rs.SetDateTime(3, expiryData);
                        rs.Update();
                    }
                }
            }
            finally
            {
                conn.Close();
            }
        
        }
    }
}

        #endregion

