using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PsiOffice.SessionAPI.Data.ValueObjects;
using PsiOffice.SessionAPI.Model;
using PsiOffice.SessionAPI.Model.Context;
using PsiOffice.SessionAPI.Repository.Interfaces;

namespace PsiOffice.SessionAPI.Repository
{
    public class SessionRepository : ISessionRepository
    {
        private readonly MySQLContext _context;
        private readonly IMapper _mapper;

        public SessionRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<SessionVO> Create(SessionVO vo)
        {
            Session session = _mapper.Map<Session>(vo);
            _context.Add(session);
            await _context.SaveChangesAsync();
            return _mapper.Map<SessionVO>(session);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                Session session = await _context.Sessions.Where(p => p.Id == id).FirstOrDefaultAsync();
                if (session == null) { return false; }
                _context.Remove(session);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<SessionVO>> FindAll()
        {
            List<Session> sessions = await _context.Sessions.ToListAsync();
            return _mapper.Map<List<SessionVO>>(sessions);
        }

        public async Task<SessionVO> FindById(long id)
        {
            Session session = await _context.Sessions.Where(p => p.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<SessionVO>(session);
        }

        public async Task<SessionVO> Update(SessionVO vo)
        {
            Session session = _mapper.Map<Session>(vo);
            _context.Update(session);
            await _context.SaveChangesAsync();
            return _mapper.Map<SessionVO>(session);
        }
    }
}
