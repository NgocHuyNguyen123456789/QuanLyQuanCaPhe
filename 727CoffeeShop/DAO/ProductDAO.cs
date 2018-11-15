using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class ProductDAO : DataProvider
    {
        public List<ProductDTO> GetProduct()
        {
            string sql = "SELECT * FROM Product";
            string id, name;
            string purchasePrice, sellingPrice;
            List<ProductDTO> list = new List<ProductDTO>();
            Connect();
            try
            {
                SqlDataReader dr = myExecuteDataReader(sql);
                while(dr.Read())
                {
                    id = dr[0].ToString();
                    name = dr[1].ToString();
                    purchasePrice = dr[2].ToString();
                    sellingPrice = dr[3].ToString();

                    ProductDTO product = new ProductDTO(id, name, purchasePrice, sellingPrice);
                    list.Add(product);
                }
                dr.Close();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }

    }
}
