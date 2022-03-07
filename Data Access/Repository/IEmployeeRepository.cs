using BusinessObject;

namespace Data_Access.Repository
{
    public interface IEmployeeRepository
    {
        EmployeeObject Login(string username, string password);
    }
}
