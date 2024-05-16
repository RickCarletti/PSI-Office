using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PsiOffice.TypeAPI.Data.ValueObjects;
using PsiOffice.TypeAPI.Model;
using PsiOffice.TypeAPI.Model.Context;
using PsiOffice.TypeAPI.Repository.Interfaces;

namespace PsiOffice.TypeAPI.Repository
{
    public class TreatmentTypeRepository : ITreatmentTypeRepository
    {
        private readonly MySQLContext _context;
        private readonly IMapper _mapper;

        public TreatmentTypeRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<TreatmentTypeVO> Create(TreatmentTypeVO vo)
        {
            TreatmentType treatment_type = _mapper.Map<TreatmentType>(vo);
            _context.Add(treatment_type);
            await _context.SaveChangesAsync();
            return _mapper.Map<TreatmentTypeVO>(treatment_type);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                TreatmentType treatment_type = await _context.TreatmentTypes.Where(p => p.Id == id).FirstOrDefaultAsync();
                if (treatment_type == null) { return false; }
                _context.Remove(treatment_type);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<TreatmentTypeVO>> FindAll()
        {
            List<TreatmentType> treatment_types = await _context.TreatmentTypes.ToListAsync();
            return _mapper.Map<List<TreatmentTypeVO>>(treatment_types);
        }

        public async Task<TreatmentTypeVO> FindById(long id)
        {
            TreatmentType treatment_type = await _context.TreatmentTypes.Where(p => p.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<TreatmentTypeVO>(treatment_type);
        }

        public async Task<TreatmentTypeVO> Update(TreatmentTypeVO vo)
        {
            TreatmentType treatment_type = _mapper.Map<TreatmentType>(vo);
            _context.Update(treatment_type);
            await _context.SaveChangesAsync();
            return _mapper.Map<TreatmentTypeVO>(treatment_type);
        }
    }
}
