using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
	public class TestimonialManager : ITestimonialService
	{
		private readonly ITestimonialService _testimonialService;
		public void TDelete(Testimonial t)
		{
			_testimonialService.TDelete(t);
		}

		public Testimonial TGetByID(int id)
		{
			return _testimonialService.TGetByID(id);
		}

		public List<Testimonial> TGetList()
		{
			return _testimonialService.TGetList();
		}

		public void TInsert(Testimonial t)
		{
			_testimonialService.TInsert(t);
		}

		public void TUpdate(Testimonial t)
		{
			_testimonialService.TUpdate(t);
		}
	}
}
