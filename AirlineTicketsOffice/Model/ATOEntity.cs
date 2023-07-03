using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTicketsOffice.Model
{
	public class ATOEntity
	{
		private static AirlinesTicketsOfficeEntities _context;

		public static AirlinesTicketsOfficeEntities GetContext()
		{
			if (_context == null)
				_context = new AirlinesTicketsOfficeEntities();

			return _context;
		}
	}
}
