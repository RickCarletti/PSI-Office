using AutoMapper;
using PsiOffice.TreatmentAPI.Data.ValueObjects;
using PsiOffice.TreatmentAPI.Model;

namespace PsiOffice.TreatmentAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Treatment, TreatmentVO>();
                config.CreateMap<TreatmentVO, Treatment>();
            });

            return mappingConfig;
        }
    }
}