using Microsoft.AspNetCore.Mvc;
using PsiOffice.TreatmentAPI.Repository.Interfaces;
using PsiOffice.TreatmentAPI.Data.ValueObjects;

namespace PsiOffice.TreatmentAPI.Controllers
{
    [Route("api/v1/Treatment")]
    [ApiController]
    public class TreatmentController : ControllerBase
    {
        private ITreatmentRepository _treatmentRepository;

        public TreatmentController(ITreatmentRepository repository)
        {
            _treatmentRepository = repository ?? throw new ArgumentException(nameof(repository));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TreatmentVO>> FindById(long id)
        {
            var treatment = await _treatmentRepository.FindById(id);
            if (treatment == null)
            {
                return NotFound();
            }
            return Ok(treatment);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TreatmentVO>>> FindAll()
        {
            var treatments = await _treatmentRepository.FindAll();
            return Ok(treatments);
        }

        [HttpPost]
        public async Task<ActionResult<TreatmentVO>> Create([FromBody] TreatmentVO treatment)
        {
            if (treatment == null) { return BadRequest(); }

            treatment = await _treatmentRepository.Create(treatment);

            return Ok(treatment);
        }

        [HttpPut]
        public async Task<ActionResult<TreatmentVO>> Update([FromBody] TreatmentVO treatment)
        {
            if (treatment == null) { return BadRequest(); }

            await _treatmentRepository.Update(treatment);

            return Ok(treatment);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var excluido = await _treatmentRepository.Delete(id);
            if (!excluido) return BadRequest();
            return Ok(excluido);
        }
    }
}
