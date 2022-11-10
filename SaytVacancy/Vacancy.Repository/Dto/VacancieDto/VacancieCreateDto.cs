using System.ComponentModel.DataAnnotations;

namespace Vacancy.Repository.Dto.VacancieDto
{
    public class VacancieCreateDto
    {
        [Required(ErrorMessage = "Введіть назву")]
        [StringLength(32, ErrorMessage = "Must be between 1 and 32 characters", MinimumLength = 1)]
        public string? BodyName { get; set; }
    }
}
