using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physical_Laws
{
	class Force
	{
		#region members
		private Vector vect;
		public Vector Vect
		{
			get { return vect; }
			set
			{
				if (value != null)
					vect = value;
				else { throw new Exception(); }
			}

		}
		# endregion
	}
}