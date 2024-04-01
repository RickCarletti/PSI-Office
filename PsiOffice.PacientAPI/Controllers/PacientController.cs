using Microsoft.AspNetCore.Mvc;
using PsiOffice.PacientAPI.Repository.Interfaces;
using PsiOffice.PacientAPI.Data.ValueObjects;

namespace PsiOffice.PacientAPI.Controllers
{
    [Route("api/v1/Pacient")]
    [ApiController]
    public class PacientController : ControllerBase
    {
        private IPacientRepository _pacientRepository;

        public PacientController(IPacientRepository repository)
        {
            _pacientRepository = repository ?? throw new ArgumentException(nameof(repository));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PacientVO>> FindById(long id)
        {
            var pacient = await _pacientRepository.FindById(id);
            if (pacient == null)
            {
                return NotFound();
            }
            return Ok(pacient);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PacientVO>>> FindAll()
        {
            var pacients = await _pacientRepository.FindAll();
            return Ok(pacients);
        }

        [HttpPost]
        public async Task<ActionResult<PacientVO>> Create([FromBody] PacientVO pacient)
        {
            if (pacient == null) { return BadRequest(); }

            pacient = await _pacientRepository.Create(pacient);

            return Ok(pacient);
        }

        [HttpPut]
        public async Task<ActionResult<PacientVO>> Update([FromBody] PacientVO pacient)
        {
            if (pacient == null) { return BadRequest(); }

            await _pacientRepository.Update(pacient);

            return Ok(pacient);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var excluido = await _pacientRepository.Delete(id);
            if (!excluido) return BadRequest();
            return Ok(excluido);
        }
    }
}
