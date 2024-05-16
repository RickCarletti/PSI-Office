using AutoMapper;
using PsiOffice.FinancialMovimentAPI.Data.ValueObjects;
using PsiOffice.FinancialMovimentAPI.Model;

namespace PsiOffice.FinancialMovimentAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<FinancialMoviment, FinancialMovimentVO>();
                config.CreateMap<FinancialMovimentVO, FinancialMoviment>();
            });

            return mappingConfig;
        }
    }
}