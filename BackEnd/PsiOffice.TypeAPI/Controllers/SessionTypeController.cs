using PsiOffice.TypeAPI.Data.ValueObjects;
using Microsoft.AspNetCore.Mvc;
using PsiOffice.TypeAPI.Repository.Interfaces;

namespace PsiOffice.TypeAPI.Controllers
{
    [Route("api/v1/SessionType")]
    [ApiController]
    public class SessionTypeController : ControllerBase
    {
        private ISessionTypeRepository _sessionRepository;

        public SessionTypeController(ISessionTypeRepository repository)
        {
            _sessionRepository = repository ?? throw new ArgumentException(nameof(repository));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SessionTypeVO>> FindById(long id)
        {
            var session_type = await _sessionRepository.FindById(id);
            if (session_type == null)
            {
                return NotFound();
            }
            return Ok(session_type);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SessionTypeVO>>> FindAll()
        {
            var session_types = await _sessionRepository.FindAll();
            return Ok(session_types);
        }

        [HttpPost]
        public async Task<ActionResult<SessionTypeVO>> Create([FromBody] SessionTypeVO session_type)
        {
            if (session_type == null) { return BadRequest(); }

            session_type = await _sessionRepository.Create(session_type);

            return Ok(session_type);
        }

        [HttpPut]
        public async Task<ActionResult<SessionTypeVO>> Update([FromBody] SessionTypeVO session_type)
        {
            if (session_type == null) { return BadRequest(); }

            await _sessionRepository.Update(session_type);

            return Ok(session_type);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var excluido = await _sessionRepository.Delete(id);
            if (!excluido) return BadRequest();
            return Ok(excluido);
        }
    }
}
