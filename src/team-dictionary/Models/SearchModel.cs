using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using team_dictionary.Data;

namespace team_dictionary.Models
{
    public class SearchModel
    {
        [Required]
        public string SearchString { get; set; }
        public IEnumerable<Word> SearchResult { get; internal set; }
    }
}
