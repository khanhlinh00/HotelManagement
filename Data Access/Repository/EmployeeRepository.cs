using BusinessObject;


namespace Data_Access.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public EmployeeObject Login(string username, string password) => EmployeeDAO.Instance.Login(username, password);
        
    }
}
