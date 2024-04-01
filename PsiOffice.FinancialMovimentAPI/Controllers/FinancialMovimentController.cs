using Microsoft.AspNetCore.Mvc;
using PsiOffice.FinancialMovimentAPI.Repository.Interfaces;
using PsiOffice.FinancialMovimentAPI.Data.ValueObjects;

namespace PsiOffice.FinancialMovimentAPI.Controllers
{
    [Route("api/v1/FinancialMoviment")]
    [ApiController]
    public class FinancialMovimentController : ControllerBase
    {
        private IFinancialMovimentRepository _financialMovimentRepository;

        public FinancialMovimentController(IFinancialMovimentRepository repository)
        {
            _financialMovimentRepository = repository ?? throw new ArgumentException(nameof(repository));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FinancialMovimentVO>> FindById(long id)
        {
            var financial_moviment = await _financialMovimentRepository.FindById(id);
            if (financial_moviment == null)
            {
                return NotFound();
            }
            return Ok(financial_moviment);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FinancialMovimentVO>>> FindAll()
        {
            var financial_moviment = await _financialMovimentRepository.FindAll();
            return Ok(financial_moviment);
        }

        [HttpPost]
        public async Task<ActionResult<FinancialMovimentVO>> Create([FromBody] FinancialMovimentVO financial_moviment)
        {
            if (financial_moviment == null) { return BadRequest(); }

            financial_moviment = await _financialMovimentRepository.Create(financial_moviment);

            return Ok(financial_moviment);
        }

        [HttpPut]
        public async Task<ActionResult<FinancialMovimentVO>> Update([FromBody] FinancialMovimentVO financial_moviment)
        {
            if (financial_moviment == null) { return BadRequest(); }

            await _financialMovimentRepository.Update(financial_moviment);

            return Ok(financial_moviment);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var excluido = await _financialMovimentRepository.Delete(id);
            if (!excluido) return BadRequest();
            return Ok(excluido);
        }
    }
}
