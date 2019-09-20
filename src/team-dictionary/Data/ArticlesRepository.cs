using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace team_dictionary.Data
{
    public class ArticlesRepository
    {
        private TeamDictionaryContext _context;

        private List<Article> _list;

        public ArticlesRepository()
        {
            _context = new TeamDictionaryContext(new DbContextOptions<TeamDictionaryContext>());
        }

        public List<Article> GetArticles()
        {
            var articles = _context.Articles.ToList();
            foreach (var article in articles)
            {
                article.Translations = _context.Translations.Where(t => t.ArticleId == article.ArticleId).ToList();
                article.SqlQueries = _context.SqlQueries.Where(t => t.ArticleId == article.ArticleId).ToList();
            }

            return articles;
        }
    }
}
