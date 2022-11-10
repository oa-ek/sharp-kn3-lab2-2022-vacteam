
using Vacancy.Core;

namespace Vacancy.Repository.Dto.EmployerDto
{
    public class EmployerDto
    {
        public int EmployerId { get; set; }
        public string? EmployerName { get; set; }

        public virtual ICollection<Vacancie>? Vacancie { get; set; }
    }
}
