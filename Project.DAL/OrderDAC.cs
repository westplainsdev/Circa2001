using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Generic.DataAccess;
using Project.Domain;

namespace Project.DAL
{
    public class OrderDAC
    {
        private readonly string loadOrdersText = "select o.*, s.companyname from orders o inner join shippers s on s.ShipperID = o.ShipVia where o.customerID = @customerID";

        public List<Order> GetAllOrdersByCustomer(string customerID)
        {
            var arrParam = new SqlParameter[1];
            arrParam[0] = new SqlParameter("@customerID", customerID);

            var tempList = new List<Order>();
            try
            {
                var reader = SqlHelper.ExecuteReader(CommandType.Text, loadOrdersText, arrParam);

                while (reader.Read())
                {
                    tempList.Add(BuildOrderInformation(reader));

                }

                reader.Close();
            }
            catch (Exception e)
            {
                if (e.Message != "Thread was being aborted.")
                {
                    //this.lblException.Text = e.Message;
                    //ApplicationLog.WriteError(e);
                }
            }
            return tempList;

        }

        private static Order BuildOrderInformation(IDataRecord reader)
        {
            var currentOrder = new Order
            {
                OrderID = Helpers.ConvertDBNull.To<int>(reader["OrderID"], 0),
                CustomerID = Helpers.ConvertDBNull.To<string>(reader["CustomerID"], string.Empty),
                EmployeeID = Helpers.ConvertDBNull.To<int>(reader["EmployeeID"], 0),
                OrderDate = Helpers.ConvertDBNull.To<DateTime>(reader["OrderDate"], DateTime.Now),
                RequiredDate = Helpers.ConvertDBNull.To<DateTime>(reader["RequiredDate"], DateTime.Now),
                ShippedDate = Helpers.ConvertDBNull.To<DateTime>(reader["ShippedDate"], DateTime.Now),
                ShipVia = Helpers.ConvertDBNull.To<int>(reader["ShipVia"], 0),
                Freight = Helpers.ConvertDBNull.To<double>(reader["Freight"], 0.00),
                ShipName = Helpers.ConvertDBNull.To<string>(reader["ShipName"], string.Empty),
                ShipAddress = Helpers.ConvertDBNull.To<string>(reader["ShipAddress"], string.Empty),
                ShipCity = Helpers.ConvertDBNull.To<string>(reader["ShipCity"], string.Empty),
                ShipRegion = Helpers.ConvertDBNull.To<string>(reader["ShipRegion"], string.Empty),
                ShipPostalCode = Helpers.ConvertDBNull.To<string>(reader["ShipPostalCode"], string.Empty),
                ShipCountry = Helpers.ConvertDBNull.To<string>(reader["ShipCountry"], string.Empty),
                ShippersName = Helpers.ConvertDBNull.To<string>(reader["companyname"], string.Empty)
            };
            return currentOrder;
        }
    }
}
