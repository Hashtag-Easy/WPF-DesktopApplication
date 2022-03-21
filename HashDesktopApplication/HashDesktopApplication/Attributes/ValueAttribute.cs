using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashDesktopApplication.Attributes
{
	[AttributeUsage(AttributeTargets.Field)]
	public class ValueAttribute : Attribute
	{
		public string Value { get; set; }

		public ValueAttribute(string value)
		{
			Value = value;
		}
	}
}
