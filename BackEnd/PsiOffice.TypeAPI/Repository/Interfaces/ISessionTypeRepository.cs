using PsiOffice.TypeAPI.Data.ValueObjects;

namespace PsiOffice.TypeAPI.Repository.Interfaces
{
    public interface ISessionTypeRepository
    {
        Task<IEnumerable<SessionTypeVO>> FindAll();
        Task<SessionTypeVO> FindById(long id);
        Task<SessionTypeVO> Create(SessionTypeVO vo);
        Task<SessionTypeVO> Update(SessionTypeVO vo);
        Task<bool> Delete(long id);
    }
}
