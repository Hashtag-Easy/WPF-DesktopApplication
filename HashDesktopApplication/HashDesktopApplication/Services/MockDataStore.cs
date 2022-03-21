using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashDesktopApplication.Models;

namespace HashDesktopApplication.Services
{
	public class MockDataStore
	{
		private string Token { get; set; }
		private List<User> MockedUsers { get; set; }

		public MockDataStore()
		{
			Token = "eMmxU89g42VfLra0yrsUsXXkxJlOCB41";
			MockedUsers = new List<User>()
			{
				new User()
				{
					Id = 0,
					FirstName = "Kacper",
					LastName = "Żabiński",
					Email = "kacperzab0@wp.pl",
					Balance = 999999,
					Sex = Sex.Male,
					Address = new Address()
					{
						Country = "Poland",
						City = "Kęty",
						ZipCode = "32-650",
						Street = "os. 700-Lecia",
						HouseNumber = "8/35",
					},
					PhoneNumber = new PhoneNumber()
					{
						AreaCode = "48",
						Numer = "608406379",
					},
					BillingCard = new BillingCard()
					{
						Numer = "1234123412341234",
						ExpireDate = "04/22",
						Ccv = "445",
					},
					AccountType = AccountType.Developer,
				},
				new User()
				{
					Id = 1,
					FirstName = "TestName",
					LastName = "TestLastName",
					Email = "test@gmail.pl",
					Balance = 999999,
					Sex = Sex.Male,
					Address = new Address()
					{
						Country = "Poland",
						City = "Warszawa",
						ZipCode = "25-222",
						Street = "os. 1000-Lecia",
						HouseNumber = "2/22",
					},
					PhoneNumber = new PhoneNumber()
					{
						AreaCode = "48",
						Numer = "406445999",
					},
					BillingCard = new BillingCard()
					{
						Numer = "4321432143214321",
						ExpireDate = "09/23",
						Ccv = "333",
					},
					AccountType = AccountType.Developer,
				},
				new User()
				{
					Id = 2,
					FirstName = "Olvia",
					LastName = "Lang",
					Email = "olvia.lang@gmail.com",
					Balance = 0,
					Sex = Sex.Famale,
					Address = new Address()
					{
						Country = "England",
						City = "London",
						ZipCode = "32-333",
						Street = "Forestry",
						HouseNumber = "2",
					},
					PhoneNumber = new PhoneNumber()
					{
						AreaCode = "48",
						Numer = "608406379",
					},
					BillingCard = new BillingCard()
					{
						Numer = "1234123412341234",
						ExpireDate = "04/22",
						Ccv = "445",
					},
					AccountType = AccountType.User,
				},
				new User()
				{
					Id = 3,
					FirstName = "Aria",
					LastName = "Destiny",
					Email = "aria.destiny@onet.com",
					Balance = 3000,
					Sex = Sex.Male,
					Address = new Address()
					{
						Country = "USA",
						City = "Las Vegas",
						ZipCode = "55-233",
						Street = "Windy",
						HouseNumber = "193b",
					},
					PhoneNumber = new PhoneNumber()
					{
						AreaCode = "22",
						Numer = "678345789",
					},
					BillingCard = new BillingCard()
					{
						Numer = "7089123445768790",
						ExpireDate = "04/22",
						Ccv = "445",
					},
					AccountType = AccountType.User,
				},
				new User()
				{
					Id = 4,
					FirstName = "Adrew",
					LastName = "Larsson",
					Email = "adrew.larsson@gmail.com",
					Balance = 1500,
					Sex = Sex.Male,
					Address = new Address()
					{
						Country = "Germany",
						City = "Kolonia",
						ZipCode = "22-134",
						Street = "Duntherstang",
						HouseNumber = "55a",
					},
					PhoneNumber = new PhoneNumber()
					{
						AreaCode = "49",
						Numer = "305342233",
					},
					BillingCard = new BillingCard()
					{
						Numer = "7809678956873645",
						ExpireDate = "12/34",
						Ccv = "232",
					},
					AccountType = AccountType.User,
				},
			};
		}

		public string? Authorize(LoginParams loginParams)
		{
			var mockedUsersCopy = MockedUsers;
			int? userId = mockedUsersCopy
				.Where(u => u.Email == loginParams.UserName && loginParams.Password == "Admin")
				.Select(u => u.Id)
				.First();

			if (userId.HasValue)
				return $"Token={userId.Value}";
			else
				return null;
		}

		public User? GetUserData(string authorizationToken)
		{
			if (authorizationToken != Token)
				return null;

			var tokenId = authorizationToken.Split('=').Last();
			var mockedUsersCopy = MockedUsers;
			return mockedUsersCopy.Where(e => e.Id.HasValue && e.Id.Value == Convert.ToInt32(tokenId)).First();
		}
	}
}
