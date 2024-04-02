using MobileFacilityFood.Dependencies;

namespace MobileFacilityFood.Services;

public class MobileFacilityFoodSearchResultItem(
    MobileFacilityFoodItem mobileFacilityFoodItem,
    double distance)
{
    public double Distance { get; set; } = distance;

    public MobileFacilityFoodItem MobileFacilityFoodItem { get; set; } = mobileFacilityFoodItem;
}