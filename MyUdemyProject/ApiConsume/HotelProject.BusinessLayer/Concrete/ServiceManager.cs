using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
	public class ServiceManager : IServiceService
	{
		private readonly IServiceService serviceService;
		public void TDelete(Service t)
		{
			serviceService.TDelete(t);
		}

		public Service TGetByID(int id)
		{
			return serviceService.TGetByID(id);
		}

		public List<Service> TGetList()
		{
			return serviceService.TGetList();
		}

		public void TInsert(Service t)
		{
			serviceService.TInsert(t);
		}

		public void TUpdate(Service t)
		{
			serviceService.TUpdate(t);
		}
	}
}
