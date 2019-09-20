using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace team_dictionary.Data
{
    public class Article
    {
        public int ArticleId { get; set; }

        public string Word { get; set; }
        
        public ICollection<Translation> Translations { get; set; }

        public ICollection<SqlQuery> SqlQueries { get; set; }

        public Article(string word, string translation)
        {
            Word = word;
        }

        public Article()
        {
        }
    }
}
