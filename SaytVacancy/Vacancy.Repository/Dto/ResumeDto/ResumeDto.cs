using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacancy.Repository.Dto.ResumeDto
{
    public class ResumeDto
    {
        public int ResumeId { get; set; }
        public string? EducationName { get; set; }
        public string? SkillName { get; set; }
        public string? ExperienceName { get; set; }
        public string? UserId { get; set; }
    }
}
