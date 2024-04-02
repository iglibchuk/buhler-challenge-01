using MobileFacilityFood.Dependencies;
using MobileFacilityFood.Extensions;

namespace MobileFacilityFood.Services;

internal class MobileFacilityFoodSearchService(IMobileFacilityFoodService facilityFoodService) : IMobileFacilityFoodSearchService
{

    public async Task<IEnumerable<MobileFacilityFoodSearchResultItem>> SearchAsync(double latitude, double longitude, string? preferredFood, int limit)
    {
        if (limit is < 1 or > 1000)
        {
            limit = 10;
        }

        var allMobileFacilityFood = await facilityFoodService.GetAvailableAsync();

        preferredFood = preferredFood?.ToLowerInvariant();
        if (preferredFood.IsNotNullOrWhiteSpace())
        {
            allMobileFacilityFood = allMobileFacilityFood.Where(x => x.FoodItems?.Contains(preferredFood) ?? false);
        }

        return allMobileFacilityFood
            .Select(x => new MobileFacilityFoodSearchResultItem(x, latitude, longitude))
            .OrderBy(x => x.Distance)
            .Take(limit);
    }
}