using AutoMapper;
using PsiOffice.PacientAPI.Data.ValueObjects;
using PsiOffice.PacientAPI.Model;

namespace PsiOffice.PacientAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Pacient, PacientVO>();
                config.CreateMap<PacientVO, Pacient>();
            });

            return mappingConfig;
        }
    }
}