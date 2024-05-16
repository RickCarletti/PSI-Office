using PsiOffice.PacientAPI.Data.ValueObjects;

namespace PsiOffice.PacientAPI.Repository.Interfaces
{
    public interface IPacientRepository
    {
        Task<IEnumerable<PacientVO>> FindAll();
        Task<PacientVO> FindById(long id);
        Task<PacientVO> Create(PacientVO vo);
        Task<PacientVO> Update(PacientVO vo);
        Task<bool> Delete(long id);
    }
}
