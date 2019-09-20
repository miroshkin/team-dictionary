using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace team_dictionary.Data
{
    public class SqlQuery
    {
        public int SqlQueryId { get; set; }

        public string Name { get; set; }

       [Required]
        public string Text { get; set; }

        [ForeignKey("ArticleId")]
        public int ArticleId { get; set; }
    }
}
