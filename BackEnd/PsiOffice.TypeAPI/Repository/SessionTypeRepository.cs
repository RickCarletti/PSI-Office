using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PsiOffice.TypeAPI.Data.ValueObjects;
using PsiOffice.TypeAPI.Model;
using PsiOffice.TypeAPI.Model.Context;
using PsiOffice.TypeAPI.Repository.Interfaces;

namespace PsiOffice.TypeAPI.Repository
{
    public class SessionTypeRepository : ISessionTypeRepository
    {
        private readonly MySQLContext _context;
        private readonly IMapper _mapper;

        public SessionTypeRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<SessionTypeVO> Create(SessionTypeVO vo)
        {
            SessionType session_type = _mapper.Map<SessionType>(vo);
            _context.Add(session_type);
            await _context.SaveChangesAsync();
            return _mapper.Map<SessionTypeVO>(session_type);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                SessionType session_type = await _context.SessionTypes.Where(p => p.Id == id).FirstOrDefaultAsync();
                if (session_type == null) { return false; }
                _context.Remove(session_type);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<SessionTypeVO>> FindAll()
        {
            List<SessionType> session_types = await _context.SessionTypes.ToListAsync();
            return _mapper.Map<List<SessionTypeVO>>(session_types);
        }

        public async Task<SessionTypeVO> FindById(long id)
        {
            SessionType session_type = await _context.SessionTypes.Where(p => p.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<SessionTypeVO>(session_type);
        }

        public async Task<SessionTypeVO> Update(SessionTypeVO vo)
        {
            SessionType session_type = _mapper.Map<SessionType>(vo);
            _context.Update(session_type);
            await _context.SaveChangesAsync();
            return _mapper.Map<SessionTypeVO>(session_type);
        }
    }
}
