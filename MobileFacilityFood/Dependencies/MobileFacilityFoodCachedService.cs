using Microsoft.Extensions.Caching.Memory;

namespace MobileFacilityFood.Dependencies;

internal class MobileFacilityFoodCachedService(MobileFacilityFoodService service, IMemoryCache memoryCache) : IMobileFacilityFoodService
{
    public async Task<IEnumerable<MobileFacilityFoodItem>> GetAvailableAsync()
    {
        return await memoryCache.GetOrCreateAsync($"{nameof(MobileFacilityFoodService)}", async entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);
            return (await service.GetAllAsync())
                .Where(x=>x.Status == ApplicationStatus.Approved && x.Latitude != 0 && x.Longitude != 0);
        }) ?? Enumerable.Empty<MobileFacilityFoodItem>();
    }
}