using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
	public interface IGenericDal<T> where T : class
	{
		//crud işlemlerine ait metodarı tanımlayacağız

		void Insert(T t);
		void Delete(T t);
		void Update(T t);
		List<T> GetList();
		T GetByID(int id);
	}
}
