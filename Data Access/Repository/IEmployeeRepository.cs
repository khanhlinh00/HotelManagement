using BusinessObject;
using System.Collections.Generic;

namespace Data_Access.Repository
{
    public interface IEmployeeRepository
    {
        EmployeeObject Login(string username, string password);
        IEnumerable<EmployeeObject> GetEmployees();
    }
}
