using PsiOffice.SessionAPI.Data.ValueObjects;

namespace PsiOffice.SessionAPI.Repository.Interfaces
{
    public interface ISessionRepository
    {
        Task<IEnumerable<SessionVO>> FindAll();
        Task<SessionVO> FindById(long id);
        Task<SessionVO> Create(SessionVO vo);
        Task<SessionVO> Update(SessionVO vo);
        Task<bool> Delete(long id);
    }
}
