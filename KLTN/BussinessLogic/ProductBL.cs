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
       public int AddNewProduct(ProductBO objProductBL)
        {
            try
            {
                ProductDA objProductDA = new ProductDA();
                return objProductDA.AddProductDetail(objProductBL);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
