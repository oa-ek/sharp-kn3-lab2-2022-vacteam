using System.ComponentModel.DataAnnotations;

namespace Vacancy.Core
{
    public class Aboutvacancie
    {
        [Key]
        public int AboutvacancieId { get; set; }
        public string? AboutvacancieName { get; set; }

        public virtual ICollection<Vacancie>? Vacancie { get; set; }
    }
}
