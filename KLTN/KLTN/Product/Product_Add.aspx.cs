using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinessLogic;
using BussinessObject;
namespace KLTN
{
    public partial class Product : System.Web.UI.Page
    {
        public ProductBL objProductBL = new ProductBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Messagebox(string xMessage)
        {
            Response.Write("<script>alert('" + xMessage + "')</script>");
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            ProductBO newProduct = new ProductBO();
            newProduct.ID = Convert.ToInt32(txtID.Text);
            newProduct.Name = txtName.Text;
            newProduct.ExpiryDate = Convert.ToDateTime(txtExpiryDate.Text);
            newProduct.CompanyName = txtCompany.Text;
            newProduct.Year = Convert.ToInt32( txtYear.Text);
            newProduct.Category = txtCategory.Text;

            int status = objProductBL.AddNewProduct(newProduct);

            if(status > 0)
            {
                Messagebox("Success");
            }
            else
            {
                Messagebox("Fail");

            }
        }
    }
}