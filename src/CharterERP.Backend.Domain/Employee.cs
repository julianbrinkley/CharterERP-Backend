using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharterERP.Backend.Domain.Entities
{
    public class Employee : User
    {
        //Dealerships will likely have an existing employee ID for employees
        public int EmployeeID { get; set; }
    }
}
