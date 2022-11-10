﻿ using System.ComponentModel.DataAnnotations;

namespace Vacancy.Repository.Dto.EducationDto
{     
        public class CreateDto
        {
            [Required(ErrorMessage = "Введіть назву")]
            [StringLength(32, ErrorMessage = "Must be between 1 and 32 characters", MinimumLength = 1)]
            public string? EducationName { get; set; }
        }   
}
