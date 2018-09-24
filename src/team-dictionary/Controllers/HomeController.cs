using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using team_dictionary.Data;
using team_dictionary.Models;

namespace team_dictionary.Controllers
{
    public class HomeController : Controller
    {
        private WordsRepository _wordsRepository = null;

        public HomeController()
        {
            _wordsRepository = new WordsRepository();
        }

        public IActionResult Index()
        {
            SearchModel sm = new SearchModel();
            return View();
        }

        [HttpPost]
        public IActionResult Index(SearchModel model)
        {
            var searchString = model.SearchString;

            if (String.IsNullOrEmpty(model.SearchString))
            {
                model.SearchResult = new Word[0];
            }
            else
            {
                model.SearchResult = _wordsRepository.GetWords()
                    .Where(c => c.Name.Contains(searchString) | c.Translation.Contains(searchString));
            }

            return View(model);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
