using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project.Domain;
using Project.DAL;

namespace Project.BLL
{
    public class EmployeeManager
    {
        public Employee GetEmployeeById(int id)
        {
            var repo = new EmployeeDAC();
            var emp = repo.GetById(id);
            return emp;
        }
    }
}
