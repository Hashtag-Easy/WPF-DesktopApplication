using System;
using System.Linq;

namespace HashSharedPackages.Extensions
{
	public static class EnumExtensions
	{
		public static TAttribute? GetAttribute<TAttribute>(this Enum e) where TAttribute : Attribute
		{
			var enumType = e.GetType();
			var enumName = Enum.GetName(enumType, e);

			if (enumName is null)
				return null;

			return enumType.GetField(enumName)?.GetCustomAttributes(false).OfType<TAttribute>().SingleOrDefault();
		}
	}
}
