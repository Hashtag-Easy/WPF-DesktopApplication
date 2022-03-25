using System;

namespace HashSharedPackages.Attributes
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
