using ModelLayer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DAO
{
	public class MenuDao
	{
		MovieTicketDbContext db = null;
		public MenuDao()
		{
			db = new MovieTicketDbContext();
		}

		public List<Menu> ListByGroupId(int groupId)
		{
			return db.Menus.Where(x => x.TypeID == groupId && x.Status == true).OrderBy(x => x.DisplayOrder).ToList();
		}

	}
}
