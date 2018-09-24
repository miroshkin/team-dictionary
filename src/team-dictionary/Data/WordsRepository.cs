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
            entries.Add(new Word("контрагент", "contragent"));
            entries.Add(new Word("проводка", "provodka"));
            entries.Add(new Word("списание", "decommission"));
            entries.Add(new Word("сличительная ведомость", "collation statement"));
            entries.Add(new Word("счет", "account"));
            entries.Add(new Word("детализация", "details"));
            entries.Add(new Word("документ", "document"));
            entries.Add(new Word("платеж", "payment"));
            entries.Add(new Word("сверка", "sverka"));
            entries.Add(new Word("требование", "trebovanie"));
            entries.Add(new Word("возврат", "return"));
            entries.Add(new Word("расписание", "schedule"));
            entries.Add(new Word("склад", "warehouse"));
            entries.Add(new Word("жалоба", "complaint"));
            entries.Add(new Word("вес", "weight"));
            entries.Add(new Word("объем", "volume"));
            entries.Add(new Word("страна", "country"));
            entries.Add(new Word("отчет", "report"));
            entries.Add(new Word("план", "plan"));
            entries.Add(new Word("транспортная компания", "transport company"));
            entries.Add(new Word("безопасность", "security"));
            entries.Add(new Word("контрафакт", "contrafact"));
            entries.Add(new Word("контрафакт", "counterfeit"));
            entries.Add(new Word("инвойс", "invoice"));
            entries.Add(new Word("таможня", "customs"));
            entries.Add(new Word("договор", "контракты"));




            return entries;

        }
    }
}
