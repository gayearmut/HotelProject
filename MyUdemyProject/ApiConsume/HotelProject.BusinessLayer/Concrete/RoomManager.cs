using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
	public class RoomManager : IRoomService
	{
		private readonly IRoomService roomService;

		public RoomManager(IRoomService roomService)
		{
			this.roomService = roomService;
		}

		public void TDelete(Room t)
		{
			roomService.TDelete(t);
		}

		public Room TGetByID(int id)
		{
			return roomService.TGetByID(id);
		}

		public List<Room> TGetList()
		{
			return roomService.TGetList();
		}

		public void TInsert(Room t)
		{
			roomService.TInsert(t);
		}

		public void TUpdate(Room t)
		{
			roomService.TUpdate(t);
		}
	}
}
