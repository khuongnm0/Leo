using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using BussinessObject;

namespace BussinessLogic
{
    public class ProductBL
    {
        ProductDA objProductDA = new ProductDA();
        public int AddNewProduct(ProductBO objProductBL)
        {
            try
            {
                
                return objProductDA.AddProduct(objProductBL);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ProductBO> ListAllProducts()
        {
            try
            {
                return objProductDA.LoadAllProduct();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
