using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InventoryCB.Model;

namespace InventoryCB.Business.Service.Abstract
{
    public interface IProductService
    {

        /// <summary>
        /// Serch a Product in DataBase
        /// </summary>
        /// <param name="reference">Prouct refernce</param>        
        /// <returns>Product if exist else null</returns>
        Product FindProductByReference(string reference);

        /// <summary>
        /// Procedure to add a new product 
        /// </summary>
        /// <param name="product"></param>
        void AddProduct(Product product);

        /// <summary>
        /// Fuction to get inforamtion from WorldOpenFoodFacts
        /// </summary>
        /// <param name="reference">Prouct refernce</param>
        /// <param name="expiryDate">Expiry Date</param>
        /// <returns></returns>
        Product GetProductInfo(string reference, DateTime expiryDate);

        

        /// <summary>
        /// Fuctio that returns the list of produts from database
        /// </summary>
        /// <returns>Lise of product</returns>
        List<Product> GetAllPorducts();

        /// <summary>
        /// Procedure to update the expiry date of a product 
        /// </summary>
        /// <param name="reference">the product's reference</param>
        /// <param name="expiryData">the expiry date</param>
        void UpdateExipryDate(string reference, DateTime expiryData);
    }
}
