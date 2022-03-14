using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Data_Access;

namespace Data_Access.Repository
{
    public class ServiceRepository : IServiceRepository
    {
        public ServiceObject GetServiceByID(int ServiceID) => ServiceDAO.Instance.GetServiceByID(ServiceID);
        public IEnumerable<ServiceObject> GetServices() => ServiceDAO.Instance.GetServiceList;
        public void InsertService(ServiceObject service) => ServiceDAO.Instance.AddNew(service);
        public void DeleteService(int ServiceID) => ServiceDAO.Instance.Remove(ServiceID);
        public void UpdateService(ServiceObject service) => ServiceDAO.Instance.Update(service);
    }

}
