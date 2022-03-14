using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public class ServiceDAO
	{

		// Initialize car list 
		private static List<ServiceObject> ServiceObjectList = new List<ServiceObject>() {
new ServiceObject{ ServiceID = 1 , ServiceName = " Khuong " , ServicePrice = 100 } ,
new ServiceObject{ ServiceID = 2 , ServiceName = " khuonggg " , ServicePrice = 200 }
};
		//----- 
		//Using Singleton Pattern 
		private static ServiceDAO instance = null;
		private static readonly object instanceLock = new object();
		private ServiceDAO() { }
		public static ServiceDAO Instance
		{
			get
			{
				lock (instanceLock)
				{
					if (instance == null)
					{
						instance = new ServiceDAO();
					}
					return instance;
				}
			}
		}
		public List<ServiceObject> GetServiceList => ServiceObjectList;
		// -------- 
		public ServiceObject GetServiceByID(int ServiceID)
		{
			// using LINQ to Object 
			ServiceObject service = ServiceObjectList.SingleOrDefault(pro => pro.ServiceID == ServiceID);
			return service;
		}

		public void AddNew(ServiceObject service)
		{
			ServiceObject pro = GetServiceByID(service.ServiceID);
			if (pro == null)
			{
				ServiceObjectList.Add((ServiceObject)service);
			}
			else
			{
				throw new Exception(" Car is already exists . ");
			}
		}

		public void Update(ServiceObject service)
		{
			ServiceObject c = GetServiceByID(service.ServiceID);
			if (c != null)
			{
				var index = ServiceObjectList.IndexOf(c);
				ServiceObjectList[index] = service;
			}
			else
			{
				throw new Exception(" Car does not already exists . ");
			}
		}


		public void Remove(int ServiceID)
		{
			ServiceObject p = GetServiceByID(ServiceID);
			if (p != null)
			{
				ServiceObjectList.Remove(p);
			}
			else
			{
				throw new Exception(" Car does not already exists . ");
			}
		}// end Remove 
	}// end class
}
