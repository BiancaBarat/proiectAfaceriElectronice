using ProiectMaster.Models.DTOs.VM;
using ProiectMaster.Models.Entites;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace ProiectMaster.Services
{
    public class OrderDataAccess
    {
        public OrderDataAccess(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        private readonly IConfiguration configuration;

        public void SaveOrder(Order order, ProductVM[] products)
        {
            string connectionString = this.configuration.GetConnectionString("AppDbConn");
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO Orders
                                                    (CustomerName, CustomerPhoneNumber, CustomerEmail, CustomerAddress, OrderDate)
                                                VALUES 
                                                    (@CustomerName, @CustomerPhoneNumber, @CustomerEmail, @CustomerAddress, @OrderDate)
                                        SELECT SCOPE_IDENTITY()";
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@CustomerName", SqlDbType = System.Data.SqlDbType.NVarChar, Value = order.CustomerName });
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@CustomerPhoneNumber", SqlDbType = System.Data.SqlDbType.NVarChar, Value = order.CustomerPhoneNumber });
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@CustomerEmail", SqlDbType = System.Data.SqlDbType.NVarChar, Value = order.CustomerEmail });
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@CustomerAddress", SqlDbType = System.Data.SqlDbType.NVarChar, Value = order.CustomerAddress });
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@OrderDate", SqlDbType = System.Data.SqlDbType.DateTime, Value = order.OrderDate });

                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        int orderId;
                        if (int.TryParse(Convert.ToString(result), out orderId))
                        {
                            using (var cmd2 = con.CreateCommand())
                            {
                                cmd2.CommandText = @"INSERT INTO OrdersProducts
                                                        (OrderId, ProductId)
                                                    VALUES 
                                                        (@OrderId, @ProductId)";
                                cmd2.Parameters.Add(new SqlParameter { ParameterName = "@OrderId", SqlDbType = System.Data.SqlDbType.NVarChar, Value = orderId });
                                var productParameter = new SqlParameter { ParameterName = "@ProductId", SqlDbType = System.Data.SqlDbType.NVarChar };
                                cmd2.Parameters.Add(productParameter);

                                foreach (var product in products)
                                {
                                    productParameter.Value = product.Id;
                                    cmd2.ExecuteNonQuery();
                                }
                            }
                        }

                    }
                }
            }
        }
    }
}