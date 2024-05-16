using Microsoft.AspNetCore.Mvc;
using PsiOffice.SessionAPI.Repository.Interfaces;
using PsiOffice.SessionAPI.Data.ValueObjects;

namespace PsiOffice.SessionAPI.Controllers
{
    [Route("api/v1/Session")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private ISessionRepository _sessionRepository;

        public SessionController(ISessionRepository repository)
        {
            _sessionRepository = repository ?? throw new ArgumentException(nameof(repository));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SessionVO>> FindById(long id)
        {
            var session = await _sessionRepository.FindById(id);
            if (session == null)
            {
                return NotFound();
            }
            return Ok(session);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SessionVO>>> FindAll()
        {
            var sessions = await _sessionRepository.FindAll();
            return Ok(sessions);
        }

        [HttpPost]
        public async Task<ActionResult<SessionVO>> Create([FromBody] SessionVO session)
        {
            if (session == null) { return BadRequest(); }

            session = await _sessionRepository.Create(session);

            return Ok(session);
        }

        [HttpPut]
        public async Task<ActionResult<SessionVO>> Update([FromBody] SessionVO session)
        {
            if (session == null) { return BadRequest(); }

            await _sessionRepository.Update(session);

            return Ok(session);
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
