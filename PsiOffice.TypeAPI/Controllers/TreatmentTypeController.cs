using PsiOffice.TypeAPI.Data.ValueObjects;
using Microsoft.AspNetCore.Mvc;
using PsiOffice.TypeAPI.Repository.Interfaces;

namespace PsiOffice.TypeAPI.Controllers
{
    [Route("api/v1/TreatmentType")]
    [ApiController]
    public class TreatmentTypeController : ControllerBase
    {
        private ITreatmentTypeRepository _treatmentRepository;

        public TreatmentTypeController(ITreatmentTypeRepository repository)
        {
            _treatmentRepository = repository ?? throw new ArgumentException(nameof(repository));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TreatmentTypeVO>> FindById(long id)
        {
            var treatment_type = await _treatmentRepository.FindById(id);
            if (treatment_type == null)
            {
                return NotFound();
            }
            return Ok(treatment_type);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TreatmentTypeVO>>> FindAll()
        {
            var treatment_types = await _treatmentRepository.FindAll();
            return Ok(treatment_types);
        }

        [HttpPost]
        public async Task<ActionResult<TreatmentTypeVO>> Create([FromBody] TreatmentTypeVO treatment_type)
        {
            if (treatment_type == null) { return BadRequest(); }

            treatment_type = await _treatmentRepository.Create(treatment_type);

            return Ok(treatment_type);
        }

        [HttpPut]
        public async Task<ActionResult<TreatmentTypeVO>> Update([FromBody] TreatmentTypeVO treatment_type)
        {
            if (treatment_type == null) { return BadRequest(); }

            await _treatmentRepository.Update(treatment_type);

            return Ok(treatment_type);
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
