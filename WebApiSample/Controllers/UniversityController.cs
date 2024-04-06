using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiSample.Models.DTO;
using WebApiSample.Models.ORM;

namespace WebApiSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversityController : ControllerBase
    {
        AcademyIstanbulContext context;
        public UniversityController()
        {
            context = new AcademyIstanbulContext();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<GetAllUniversitiesResponseDto> model = context.Universities.Select(x => new GetAllUniversitiesResponseDto()
            {
                ID = x.ID,
                Name = x.Name,
                City = x.City
            }).ToList();

            return Ok(model);
        }

        [HttpPost]
        public IActionResult AddUniversity(CreateUniversityRequestDto model)
        {
            University university = new University();
            university.Name = model.Name;
            university.City = model.City;

            context.Universities.Add(university);
            context.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUniversity(int id, UpdateUniversityRequestDto model)
        {
            University university = context.Universities.FirstOrDefault(x => x.ID == id);

            if (university == null)
            {
                return NotFound();
            }

            university.Name = model.Name;
            university.City = model.City;

            context.SaveChanges();
            return Ok();
        }
    }
}
