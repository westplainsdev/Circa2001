using System.Configuration;

namespace Generic.DataAccess
{
    public class ConnectionHelper
    {
        public static string SqlConnectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
    }
}
