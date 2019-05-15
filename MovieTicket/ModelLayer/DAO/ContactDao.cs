using ModelLayer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DAO
{

	public class ContactDao
	{
		MovieTicketDbContext db = null;
		public ContactDao()
		{
			db = new MovieTicketDbContext();
		}

		public Contact GetActiveContact()
		{

			return db.Contacts.Single(x => x.Status == true);
		}

		public int InsertFeedBack(Feedback fb)
		{
			db.Feedbacks.Add(fb);
			db.SaveChanges();
			return fb.ID;
		}
	}

}
