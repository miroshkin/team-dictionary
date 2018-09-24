using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace team_dictionary.Data
{
    public class WordsRepository
    {
        public List<Word> GetWords()
        {
            var entries = new List<Word>();
            entries.Add(new Word("поставщик", "supplier"));
            entries.Add(new Word("клиент", "customer"));
            entries.Add(new Word("контагент", "contragent"));

            return entries;
        }
    }
}
