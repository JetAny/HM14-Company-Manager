using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Manager
{
    internal class Company
    {
        List<Manager> companyManadgers = new List<Manager>(12);
        public Company(Employee employee)
        {
            
        }
       
        public void AddManager(Manager manager)
        {
            companyManadgers.Add(manager);
        }
        public void RemoveEmployee(int index)
        {
            companyManadger.RemoveAt(index);
        }
    }
}
