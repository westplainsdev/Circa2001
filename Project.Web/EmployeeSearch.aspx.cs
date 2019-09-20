using System;
using System.Text;
using Project.Domain;
using Project.BLL;
using static System.String;

namespace Project.Web
{
    public partial class EmployeeSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void uxSubmit_Onclick(object sender, EventArgs e)
        {
            DisplayEmployee();
        }

        protected void uxReset_Onclick(object sender, EventArgs e)
        {
            ResetPage();
        }

        private void ResetPage()
        {
            uxEmployeeNumber.Text = Empty;
            uxEmployeePanel.Visible = false;
            uxMessage.Text = Empty;
        }

        private void DisplayEmployee()
        {
            int employeeId = 0;

            if (!IsNullOrEmpty(uxEmployeeNumber.Text))
            {
                employeeId = Convert.ToInt32(uxEmployeeNumber.Text);
            }

            if (employeeId != 0)
            {
                var manager = new EmployeeManager();
                var emp = manager.GetEmployeeById(employeeId);
                if (emp.EmployeeID == 0)
                {
                    EmployeeNotFound();
                }
                else
                { 
                   BuildDisplay(emp);
                }
            }
            else
            {
                uxMessage.Text = "<p>A value must be entered before a query can be made</p>";
            }
        }

        private void EmployeeNotFound()
        {
            uxEmployeePanel.Visible = false;
            uxEmployeeDisplay.Text = Empty;
            uxEmployeeNumber.Text = Empty;
            uxMessage.Text = "<p>An employee with that ID was not found.</p>";
        }

        private void BuildDisplay(Employee emp)
        {
            var builder = new StringBuilder();
            builder.Append("<ul class='display'>");
            builder.Append($"<li>{emp.Title} - {emp.FirstName} {emp.LastName}</li>");
            builder.Append($"<li>{emp.Address} {emp.City}, {emp.Region} {emp.PostalCode} {emp.Country}</li>");
            builder.Append(
                $"<li>Extension: {emp.Extension} EmployeeID: {emp.EmployeeID} Hire Date: {emp.HireDate.ToShortDateString()}</li>");
            builder.Append("</ul>");
            builder.Append($"<p>{emp.Notes}</p>");
            uxEmployeeDisplay.Text = builder.ToString();
            uxEmployeePanel.Visible = true;
            uxEmployeeNumber.Text = Empty;
        }
    }
}
