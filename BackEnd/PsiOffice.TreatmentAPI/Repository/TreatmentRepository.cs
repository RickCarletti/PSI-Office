using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PsiOffice.TreatmentAPI.Data.ValueObjects;
using PsiOffice.TreatmentAPI.Model;
using PsiOffice.TreatmentAPI.Model.Context;
using PsiOffice.TreatmentAPI.Repository.Interfaces;

namespace PsiOffice.TreatmentAPI.Repository
{
    public class TreatmentRepository : ITreatmentRepository
    {
        private readonly MySQLContext _context;
        private readonly IMapper _mapper;

        public TreatmentRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<TreatmentVO> Create(TreatmentVO vo)
        {
            Treatment treatment = _mapper.Map<Treatment>(vo);
            _context.Add(treatment);
            await _context.SaveChangesAsync();
            return _mapper.Map<TreatmentVO>(treatment);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                Treatment treatment = await _context.Treatments.Where(p => p.Id == id).FirstOrDefaultAsync();
                if (treatment == null) { return false; }
                _context.Remove(treatment);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<TreatmentVO>> FindAll()
        {
            List<Treatment> treatments = await _context.Treatments.ToListAsync();
            return _mapper.Map<List<TreatmentVO>>(treatments);
        }

        public async Task<TreatmentVO> FindById(long id)
        {
            Treatment treatment = await _context.Treatments.Where(p => p.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<TreatmentVO>(treatment);
        }

        public async Task<TreatmentVO> Update(TreatmentVO vo)
        {
            Treatment treatment = _mapper.Map<Treatment>(vo);
            _context.Update(treatment);
            await _context.SaveChangesAsync();
            return _mapper.Map<TreatmentVO>(treatment);
        }
    }
}
