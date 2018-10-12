﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using team_dictionary.Data;
using team_dictionary.Models;

namespace team_dictionary.Controllers
{
    public class HomeController : Controller
    {
        private ArticlesRepository _articlesRepository = null;
        private readonly IHostingEnvironment _hostingEnvironment;
        public HomeController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            string contentRootPath = _hostingEnvironment.ContentRootPath;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var enc1251 = Encoding.GetEncoding(1251);
            var JSON = System.IO.File.ReadAllText(contentRootPath + "/Content/dictionary.json", enc1251);
            _articlesRepository = new ArticlesRepository(JSON);
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
                model.SearchResult = new Article[0];
            }
            else
            {
                model.SearchResult =
                    _articlesRepository.GetArticles()
                        .Where(c =>
                            c.Word.ToUpper().Contains(searchString.ToUpper()));
            }

            return View(model);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
