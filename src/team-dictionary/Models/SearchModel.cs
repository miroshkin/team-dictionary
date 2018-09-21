using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace team_dictionary.Models
{
    public class SearchModel
{
    [Required]
    public string SearchString { get; set; }

    [Required]
    public Dictionary<string, string> Dictionary { get; set; }
    }
}
