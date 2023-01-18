using Microsoft.AspNetCore.Mvc;
using NameAndCountry.Models;
using NameAndCountry.Services;
using System.Diagnostics;


namespace NameAndCountry.Controllers
{
	public class NameAndCountryController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public NameAndCountryController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public IActionResult Privacy()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(Country newCountry)
		{
			string personName = newCountry.PersonName;
			string countryName = newCountry.CountryName;
			return View();
		}

		
	}
}
