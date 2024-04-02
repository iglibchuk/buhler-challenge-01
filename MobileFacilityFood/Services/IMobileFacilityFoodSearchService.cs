namespace MobileFacilityFood.Services;

public interface IMobileFacilityFoodSearchService
{
    Task<IEnumerable<MobileFacilityFoodSearchResultItem>> SearchAsync(double latitude, double longitude, string? preferredFood, int limit);
}