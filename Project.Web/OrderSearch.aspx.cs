using System;
using System.Collections.Generic;
using Project.Domain;
using Project.BLL;

namespace Project.Web
{
    public partial class OrderSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void uxSearch_Click(object sender, EventArgs e)
        {
            var repo = new OrderManager();
            var customerID = uxCustomerID.Text;
            var customerOrders = repo.GetOrdersByCustomerID(customerID);
            uxCustomerOrders.DataSource = customerOrders;
            uxCustomerOrders.DataBind();
        }
    }
}
