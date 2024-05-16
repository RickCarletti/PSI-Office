using AutoMapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PsiOffice.TypeAPI.Data.ValueObjects;
using PsiOffice.TypeAPI.Model;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace PsiOffice.TypeAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<SessionType, SessionTypeVO>();
                config.CreateMap<SessionTypeVO, SessionType>();

                config.CreateMap<TreatmentType, TreatmentTypeVO>();
                config.CreateMap<TreatmentTypeVO, TreatmentType>();
            });

            return mappingConfig;
        }
    }
}