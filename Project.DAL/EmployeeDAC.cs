using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Generic.DataAccess;
using Project.Domain;

namespace Project.DAL
{
    public class EmployeeDAC
    {
          // this is 	ExecuteReader example 
        public Employee GetById(int id)
        {
            var arrParam = new SqlParameter[1];
            arrParam[0] = new SqlParameter("@id", id);

            const string sqlText = "Select * from Employees where EmployeeID=@id";
            var emp = new Employee();
            try
            {
                var dr = SqlHelper.ExecuteReader(CommandType.Text, sqlText, arrParam);

                if (dr.Read())
                {
                    emp = BuildEmployee(dr);

                }

                dr.Close();
            }
            catch (Exception e)
            {
                if (e.Message != "Thread was being aborted.")
                {
                    //this.lblException.Text = e.Message;
                    //ApplicationLog.WriteError(e);
                }
            }
            return emp;

        }

        private static Employee BuildEmployee(IDataRecord dr)
        {
            var emp = new Employee
            {
                EmployeeID = Convert.ToInt32(dr["EmployeeID"]),
                LastName = dr["LastName"].ToString(),
                FirstName = dr["FirstName"].ToString(),
                Title = dr["Title"].ToString(),
                TitleOfCourtesy = dr["TitleOfCourtesy"].ToString(),
                BirthDate = Convert.ToDateTime(dr["BirthDate"]),
                HireDate = Convert.ToDateTime(dr["HireDate"]),
                Address = dr["Address"].ToString(),
                City = dr["City"].ToString(),
                Region = dr["Region"].ToString(),
                PostalCode = dr["PostalCode"].ToString(),
                Country = dr["Country"].ToString(),
                HomePhone = dr["HomePhone"].ToString(),
                Extension = dr["Extension"].ToString(),
                Notes = dr["Notes"].ToString(),
                ReportsTo = dr["ReportsTo"] as int? ?? default(int)
            };
            return emp;
        }
    }

    }

