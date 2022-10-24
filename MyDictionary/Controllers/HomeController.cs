using Microsoft.AspNetCore.Mvc;
using MyDictionary.Models;
using MyDictionary.Services.DictionaryApiService;
using System.Diagnostics;

namespace MyDictionary.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult WordResults(string word)
        {
         var dictionaryApi = new DictionaryApi();
         var wordModels = dictionaryApi.GetWordInfo(word);

            return View(wordModels);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}