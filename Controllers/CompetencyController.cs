using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parcial202419200088.Data;
using Parcial202419200088.Interfaces;

namespace Parcial202419200088.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetencyController : ControllerBase
    {

        private readonly ICompetencyRepository _CompetencyRepository;

        public CompetencyController(ICompetencyRepository CompetencyRepository)
        {
            _CompetencyRepository = CompetencyRepository;
        }

        [HttpGet()]
        public async Task<IActionResult> GetCompetency()
        {
            var Competency = await _CompetencyRepository.GetCompetency();
            return Ok(Competency);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Competency Competency)
        {
            int CompetencyId = await _CompetencyRepository.Insert(Competency);
            return Ok(CompetencyId);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _CompetencyRepository.Delete(id);
            if (!result) return NotFound();
            return Ok(result);
        }



    }

    public class Competency
    {
    }
}
