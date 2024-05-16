using PsiOffice.TreatmentAPI.Data.ValueObjects;

namespace PsiOffice.TreatmentAPI.Repository.Interfaces
{
    public interface ITreatmentRepository
    {
        Task<IEnumerable<TreatmentVO>> FindAll();
        Task<TreatmentVO> FindById(long id);
        Task<TreatmentVO> Create(TreatmentVO vo);
        Task<TreatmentVO> Update(TreatmentVO vo);
        Task<bool> Delete(long id);
    }
}
