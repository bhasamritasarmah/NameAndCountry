using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using NameAndCountry.Models;
using NameAndCountry.Services;
using System.Diagnostics;

namespace NameAndCountry.Controllers
{
	public class HomeController : Controller
	{
		private readonly NameAndCountryService _nameAndCountryService;

		public HomeController(NameAndCountryService nameAndCountryService) =>
			_nameAndCountryService = nameAndCountryService;

		public IActionResult Index(Country newCountry)
		{
			string personName = newCountry.PersonName;
			string countryName = newCountry.CountryName;
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}