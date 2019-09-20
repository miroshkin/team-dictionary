using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace team_dictionary.Data
{
    public class Translation
    {
        public int TranslationId { get; set; }

        public bool BestTranslation { get; set; }

        [Required]
        public string Text { get; set; }

        [ForeignKey("ArticleId")]
        public int ArticleId { get; set; }
    }
}