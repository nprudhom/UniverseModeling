using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunar1
{
	class Particule
	{
		#region members
		private enum particuleType
		{
			quark,
			lepton,
			boson
		}

		private string myType;

		public string MyType
		{
 			get 
		{return myType;}
			set { myType = value};
		}
		# endregion
	}
}
