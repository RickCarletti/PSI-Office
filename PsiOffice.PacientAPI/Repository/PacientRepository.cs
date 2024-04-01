using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PsiOffice.PacientAPI.Data.ValueObjects;
using PsiOffice.PacientAPI.Model;
using PsiOffice.PacientAPI.Model.Context;
using PsiOffice.PacientAPI.Repository.Interfaces;

namespace PsiOffice.PacientAPI.Repository
{
    public class PacientRepository : IPacientRepository
    {
        private readonly MySQLContext _context;
        private readonly IMapper _mapper;

        public PacientRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<PacientVO> Create(PacientVO vo)
        {
            Pacient pacient = _mapper.Map<Pacient>(vo);
            _context.Add(pacient);
            await _context.SaveChangesAsync();
            return _mapper.Map<PacientVO>(pacient);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                Pacient pacient = await _context.Pacients.Where(p => p.Id == id).FirstOrDefaultAsync();
                if (pacient == null) { return false; }
                _context.Remove(pacient);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<PacientVO>> FindAll()
        {
            List<Pacient> pacients = await _context.Pacients.ToListAsync();
            return _mapper.Map<List<PacientVO>>(pacients);
        }

        public async Task<PacientVO> FindById(long id)
        {
            Pacient pacient = await _context.Pacients.Where(p => p.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<PacientVO>(pacient);
        }

        public async Task<PacientVO> Update(PacientVO vo)
        {
            Pacient pacient = _mapper.Map<Pacient>(vo);
            _context.Update(pacient);
            await _context.SaveChangesAsync();
            return _mapper.Map<PacientVO>(pacient);
        }
    }
}
