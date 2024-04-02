using MobileFacilityFood.Dependencies;

namespace MobileFacilityFood.Services;

public class MobileFacilityFoodSearchResultItem(
    MobileFacilityFoodItem mobileFacilityFoodItem,
    double latitude,
    double longitude)
{
    public double Distance { get; set; } = Math.Sqrt(
        (latitude - mobileFacilityFoodItem.Latitude) * (latitude - mobileFacilityFoodItem.Latitude) +
        (longitude - mobileFacilityFoodItem.Longitude) * (longitude - mobileFacilityFoodItem.Longitude)
    );

    public MobileFacilityFoodItem MobileFacilityFoodItem { get; set; } = mobileFacilityFoodItem;
}