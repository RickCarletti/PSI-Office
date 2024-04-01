using PsiOffice.FinancialMovimentAPI.Data.ValueObjects;

namespace PsiOffice.FinancialMovimentAPI.Repository.Interfaces
{
    public interface IFinancialMovimentRepository
    {
        Task<IEnumerable<FinancialMovimentVO>> FindAll();
        Task<FinancialMovimentVO> FindById(long id);
        Task<FinancialMovimentVO> Create(FinancialMovimentVO vo);
        Task<FinancialMovimentVO> Update(FinancialMovimentVO vo);
        Task<bool> Delete(long id);
    }
}
