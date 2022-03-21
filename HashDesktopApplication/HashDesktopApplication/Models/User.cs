
namespace HashDesktopApplication.Models
{
	public class User
	{
		public int? Id { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? Email { get; set; }
		public double? Balance { get; set; }
		public Sex? Sex { get; set; }
		public Address? Address { get; set; }
		public PhoneNumber? PhoneNumber { get; set; }
		public BillingCard? BillingCard { get; set; }
		public AccountType? AccountType { get; set; }
	}

	public class Address
	{
		public string? Country  { get; set; }
		public string? City { get; set; }
		public string? ZipCode { get; set; }
		public string? Street { get; set; }
		public string? HouseNumber { get; set; }
	}

	public class PhoneNumber
	{
		public string? AreaCode { get; set; }
		public string? Numer { get; set; }
	}

	public class BillingCard
	{
		public string? Numer { get; set; }
		public string? ExpireDate { get; set; }
		public string? Ccv { get; set; }
	}

	public enum AccountType
	{
		User = 0,
		Moderator = 1,
		Administrator = 2,
		Developer = 99,
	}

	public enum Sex
	{
		Undisclosed = 0,
		Male = 1,
		Famale = 2
	}
}
