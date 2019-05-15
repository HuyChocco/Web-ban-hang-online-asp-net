using ModelLayer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DAO
{
	public class OrderDetailDao
	{
		MovieTicketDbContext db = null;
		public OrderDetailDao()
		{
			db = new MovieTicketDbContext();
		}
		public bool Insert(OrderDetail detail)
		{
			try
			{
				db.OrderDetails.Add(detail);
				db.SaveChanges();
				return true;
			}
			catch
			{
				return false;

			}
		}
	}

}
