using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;
using BussinessObject;


namespace DataAccess
{
    public class ProductDA
    {
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["KTLT"].ToString());
        public int AddProductDetail(ProductBO product)
        {
            try
            {
                /* Because We will put all out values from our (UserRegistration.aspx) To in Bussiness object and then Pass it to Bussiness logic and then to DataAcess  this way the flow carry on*/
                string query = "Insert into Product values ('" + product.ID + "','" + product.Name + "','" + product.ExpiryDate + "','" + product.CompanyName + "','" + product.Year + "','" + product.Category + "')";
                SqlCommand cmd = new SqlCommand(query, connection);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@Id", productBO.ID);
                //cmd.Parameters.AddWithValue("@Name", productBO.Name);
                //cmd.Parameters.AddWithValue("@ExpiryDate", productBO.ExpiryDate);
                //cmd.Parameters.AddWithValue("@CompanyName", productBO.CompanyName);
                //cmd.Parameters.AddWithValue("@Year", productBO.Year);
                //cmd.Parameters.AddWithValue("@Category", productBO.Category);
                connection.Open();
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return Result;
            }
            catch
            {
                throw;
            }
        }
    }
}
