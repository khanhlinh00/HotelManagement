using BusinessObject;
using System.Collections.Generic;

namespace Data_Access.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public EmployeeObject Login(string username, string password) => EmployeeDAO.Instance.Login(username, password);
        IEnumerable<EmployeeObject> IEmployeeRepository.GetEmployees() => EmployeeDAO.Instance.GetEmloyeeList();


    }
}
