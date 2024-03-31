using PsiOffice.TypeAPI.Data.ValueObjects;

namespace PsiOffice.TypeAPI.Repository.Interfaces
{
    public interface ITreatmentTypeRepository
    {
        Task<IEnumerable<TreatmentTypeVO>> FindAll();
        Task<TreatmentTypeVO> FindById(long id);
        Task<TreatmentTypeVO> Create(TreatmentTypeVO vo);
        Task<TreatmentTypeVO> Update(TreatmentTypeVO vo);
        Task<bool> Delete(long id);
    }
}
