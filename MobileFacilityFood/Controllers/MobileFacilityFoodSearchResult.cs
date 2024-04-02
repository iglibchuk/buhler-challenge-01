using MobileFacilityFood.Services;

namespace MobileFacilityFood.Controllers;

public class MobileFacilityFoodSearchResult(IEnumerable<MobileFacilityFoodSearchResultItem> result)
{
    public IEnumerable<MobileFacilityFoodSearchResultItem> Result { get; } = result;
}