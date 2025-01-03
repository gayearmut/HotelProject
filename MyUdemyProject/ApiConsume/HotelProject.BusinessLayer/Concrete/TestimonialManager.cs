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
		private readonly ITestimonialService testimonialService;
		public void TDelete(Testimonial t)
		{
			testimonialService.TDelete(t);
		}

		public Testimonial TGetByID(int id)
		{
			return testimonialService.TGetByID(id);
		}

		public List<Testimonial> TGetList()
		{
			return testimonialService.TGetList();
		}

		public void TInsert(Testimonial t)
		{
			testimonialService.TInsert(t);
		}

		public void TUpdate(Testimonial t)
		{
			testimonialService.TUpdate(t);
		}
	}
}
