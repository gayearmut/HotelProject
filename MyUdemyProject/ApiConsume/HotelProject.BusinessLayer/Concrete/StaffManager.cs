using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
	public class StaffManager : IStaffSrevice
	{
		private readonly IStaffSrevice staffSrevice;

		public StaffManager(IStaffSrevice staffSrevice)
		{
			this.staffSrevice = staffSrevice;
		}

		public void TDelete(Staff t)
		{
			staffSrevice.TDelete(t);
		}

		public Staff TGetByID(int id)
		{
			return staffSrevice.TGetByID(id);
		}

		public List<Staff> TGetList()
		{
			return staffSrevice.TGetList();
		}

		public void TInsert(Staff t)
		{
			staffSrevice.TInsert(t);
		}

		public void TUpdate(Staff t)
		{
			staffSrevice.TUpdate(t);
		}
	}
}
