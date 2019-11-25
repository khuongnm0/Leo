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
            newProduct.ID = txtID.Text;
            newProduct.Name = txtName.Text;
            newProduct.ExpiryDate = DateTime.Parse(txtExpiryDate.Text);
            newProduct.CompanyName = txtCompany.Text;
            newProduct.Year = Int32.Parse( txtYear.Text);

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