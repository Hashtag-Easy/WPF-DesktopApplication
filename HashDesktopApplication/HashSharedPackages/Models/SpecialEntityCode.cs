using HashSharedPackages.Attributes;

namespace HashSharedPackages.Models
{
	public enum SpecialEntityCode
	{
		[Value("&#9;")]
		Tab,

		[Value("&#10;")]
		NewLine,

		[Value("&#160;")]
		NonBreakableSpace,
	}
}
