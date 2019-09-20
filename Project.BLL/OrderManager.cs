using System.Collections.Generic;
using Project.Domain;
using Project.DAL;

namespace Project.BLL
{
    public class OrderManager
    {
        public List<Order> GetOrdersByCustomerID(string customerID)
        {
            var repo = new OrderDAC();
            var tempList = repo.GetAllOrdersByCustomer(customerID);
            return tempList;
        }
    }
}
