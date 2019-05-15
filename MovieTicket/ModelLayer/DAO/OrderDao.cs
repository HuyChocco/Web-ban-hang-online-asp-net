using ModelLayer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DAO
{

	public class OrderDao
	{
		MovieTicketDbContext db = null;
		public OrderDao()
		{
			db = new MovieTicketDbContext();
		}
		public long Insert(Order order)
		{
			db.Orders.Add(order);
			db.SaveChanges();
			return order.ID;
		}
	}

}
