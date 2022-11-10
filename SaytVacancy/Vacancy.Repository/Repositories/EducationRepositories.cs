using Vacancy.Core;
using Vacancy.Repository.Dto.CompanyDto;
using Vacancy.Repository.Dto.EducationDto;
using Vacancy.Repository.Dto.ResumeDto;

namespace Vacancy.Repository.Repositories
{
    public class EducationRepositories
    {

        private readonly VacancyDbContext _ctx;

        public EducationRepositories(VacancyDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Education> AddEducationAsync(Education type)
        {
            _ctx.Educations.Add(type);
            await _ctx.SaveChangesAsync();
            return _ctx.Educations.FirstOrDefault(x => x.EducationName == type.EducationName);
        }

        public List<Education> GetEducations()
        {
            var typeList = _ctx.Educations.ToList();
            return typeList;
        }

        public Education GetEducation(int id)
        {
            return _ctx.Educations.FirstOrDefault(x => x.EducationId == id);
        }

        public Education GetEducationByName(string name)
        {
            return _ctx.Educations.FirstOrDefault(x => x.EducationName == name);
        }

        public async Task DeleteEducationAsync(int id)
        {
            _ctx.Remove(GetEducation(id));
            await _ctx.SaveChangesAsync();
        }

    }
}
