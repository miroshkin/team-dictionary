using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace team_dictionary.Data
{
    public class ArticlesRepository
    {
        private List<Article> _list;

        public ArticlesRepository(string json)
        {
            //Get dictionary from dictionary
            _list = JsonConvert.DeserializeObject<List<Article>>(json);
            
            //Add reverse translation
            List<Article> listCopy = _list.GetRange(0, _list.Count);
            listCopy.ForEach(c => _list.Add(new Article(c.Translation, c.Word)));
        }

        public List<Article> GetArticles()
        {
            //Return result sorted ascending
            return _list.OrderBy(x => x.Word).ToList();
        }
    }
}
