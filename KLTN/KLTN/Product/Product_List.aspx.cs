using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinessObject;
using BussinessLogic;

namespace KLTN.Product
{


    public partial class Product_List : System.Web.UI.Page
    {

        public List<ProductBO> listProducts = new List<ProductBO>();
        public ProductBL objProductBL = new ProductBL();


        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                listProducts = objProductBL.ListAllProducts();
              
            }
            catch (Exception)
            {

                throw;
            }




        }
    }
}