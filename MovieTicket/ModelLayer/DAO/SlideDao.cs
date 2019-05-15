using ModelLayer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DAO
{
	public class SlideDao
	{

		MovieTicketDbContext db = null;
		public SlideDao()
		{
			db = new MovieTicketDbContext();
		}

		public List<Slide> ListAll()
		{
			return db.Slides.Where(x => x.Status == true).OrderBy(y => y.DisplayOrder).ToList();
		}

	}
}
