using ModelLayer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DAO
{
	public class FooterDao
	{
		MovieTicketDbContext db = null;
		public FooterDao()
		{
			db = new MovieTicketDbContext();
		}
		public Footer GetFooter()
		{
			return db.Footers.SingleOrDefault(x => x.Status == true);
		}

	}
}
