using AutoMapper;
using PsiOffice.SessionAPI.Data.ValueObjects;
using PsiOffice.SessionAPI.Model;

namespace PsiOffice.SessionAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Session, SessionVO>();
                config.CreateMap<SessionVO, Session>();
            });

            return mappingConfig;
        }
    }
}