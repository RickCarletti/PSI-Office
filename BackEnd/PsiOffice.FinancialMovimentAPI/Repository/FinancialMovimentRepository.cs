using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PsiOffice.FinancialMovimentAPI.Data.ValueObjects;
using PsiOffice.FinancialMovimentAPI.Model;
using PsiOffice.FinancialMovimentAPI.Model.Context;
using PsiOffice.FinancialMovimentAPI.Repository.Interfaces;

namespace PsiOffice.FinancialMovimentAPI.Repository
{
    public class FinancialMovimentRepository : IFinancialMovimentRepository
    {
        private readonly MySQLContext _context;
        private readonly IMapper _mapper;

        public FinancialMovimentRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<FinancialMovimentVO> Create(FinancialMovimentVO vo)
        {
            FinancialMoviment financialMoviment = _mapper.Map<FinancialMoviment>(vo);
            _context.Add(financialMoviment);
            await _context.SaveChangesAsync();
            return _mapper.Map<FinancialMovimentVO>(financialMoviment);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                FinancialMoviment financialMoviment = await _context.Pacients.Where(p => p.Id == id).FirstOrDefaultAsync();
                if (financialMoviment == null) { return false; }
                _context.Remove(financialMoviment);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<FinancialMovimentVO>> FindAll()
        {
            List<FinancialMoviment> financialMoviments = await _context.Pacients.ToListAsync();
            return _mapper.Map<List<FinancialMovimentVO>>(financialMoviments);
        }

        public async Task<FinancialMovimentVO> FindById(long id)
        {
            FinancialMoviment financialMoviment = await _context.Pacients.Where(p => p.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<FinancialMovimentVO>(financialMoviment);
        }

        public async Task<FinancialMovimentVO> Update(FinancialMovimentVO vo)
        {
            FinancialMoviment financialMoviment = _mapper.Map<FinancialMoviment>(vo);
            _context.Update(financialMoviment);
            await _context.SaveChangesAsync();
            return _mapper.Map<FinancialMovimentVO>(financialMoviment);
        }
    }
}
