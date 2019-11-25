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
        public int AddProduct(ProductBO product)
        {
            string query = "INSERT INTO Product values (" + product.ID + ",'" + product.Name + "','" + product.ExpiryDate + "','" + product.CompanyName + "'," + product.Year + ",'" + product.Category + "')";
            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return Result;
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<ProductBO> LoadAllProduct()
        {
            string query = "SELECT * FROM Product";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dataReader;
            List<ProductBO> rs = new List<ProductBO>();

            try
            {
           
                connection.Open();
                dataReader = cmd.ExecuteReader();
               
                while (dataReader.Read())
                {
                    rs.Add(new ProductBO()
                    {
                        ID = dataReader.GetInt32(dataReader.GetOrdinal("ID")),
                        Name = dataReader.GetString(dataReader.GetOrdinal("Name")),
                        ExpiryDate = dataReader.GetDateTime(dataReader.GetOrdinal("ExpiryDate")),
                        CompanyName = dataReader.GetString(dataReader.GetOrdinal("CompanyName")),
                        Year = dataReader.GetInt32(dataReader.GetOrdinal("Year")),
                        Category = dataReader.GetString(dataReader.GetOrdinal("Category")),

                    });
                }

                dataReader.Close();
                cmd.Dispose();

                return rs;


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
