using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
	public class SubscribeManager : ISubscribeService
	{
		private readonly ISubscribeService subscribeService;
		public void TDelete(Subscribe t)
		{
			subscribeService.TDelete(t);
		}

		public Subscribe TGetByID(int id)
		{
			return subscribeService.TGetByID(id);
		}

		public List<Subscribe> TGetList()
		{
			return subscribeService.TGetList();
		}

		public void TInsert(Subscribe t)
		{
			subscribeService.TInsert(t);
		}

		public void TUpdate(Subscribe t)
		{
			subscribeService.TUpdate(t);
		}
	}
}
