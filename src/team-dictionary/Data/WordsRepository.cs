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
            var list = new List<Word>();

            list.Add(new Word("поставщик", "supplier"));
            list.Add(new Word("клиент", "customer"));
            list.Add(new Word("контрагент", "contragent"));
            list.Add(new Word("проводка", "provodka"));
            list.Add(new Word("списание", "decommission"));
            list.Add(new Word("сличительная ведомость", "collation statement"));
            list.Add(new Word("счет", "account"));
            list.Add(new Word("детализация", "details"));
            list.Add(new Word("документ", "document"));
            list.Add(new Word("платеж", "payment"));
            list.Add(new Word("сверка", "sverka"));
            list.Add(new Word("требование", "trebovanie"));
            list.Add(new Word("возврат", "return"));
            list.Add(new Word("расписание", "schedule"));
            list.Add(new Word("склад", "warehouse"));
            list.Add(new Word("жалоба", "complaint"));
            list.Add(new Word("вес", "weight"));
            list.Add(new Word("объем", "volume"));
            list.Add(new Word("страна", "country"));
            list.Add(new Word("отчет", "report"));
            list.Add(new Word("план", "plan"));
            list.Add(new Word("транспортная компания", "transport company"));
            list.Add(new Word("безопасность", "security"));
            list.Add(new Word("контрафакт", "contrafact"));
            list.Add(new Word("контрафакт", "counterfeit"));
            list.Add(new Word("инвойс", "invoice"));
            list.Add(new Word("таможня", "customs"));
            list.Add(new Word("процент", "percent"));
            list.Add(new Word("приказ", "order"));
            list.Add(new Word("распоряжение", "directive"));
            list.Add(new Word("инвентаризация", "inventory"));
            list.Add(new Word("утилизация", "utilization"));

            return list;

        }
    }
}
