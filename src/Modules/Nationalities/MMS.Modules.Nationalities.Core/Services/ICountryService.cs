using MMS.Modules.Nationalities.Shared.DTO;

namespace MMS.Modules.Nationalities.Core.Services;

public interface ICountryService
{
    Task<CountryDto> GetAsync(Guid countryId);
    Task<IEnumerable<CountryDto>> GetAllAsync();
    Task AddAsync(CountryDto dto);
    Task VerifyAsync(Guid userId);
}