namespace MobileFacilityFood.Dependencies;

public interface IMobileFacilityFoodService
{
    Task<IEnumerable<MobileFacilityFoodItem>> GetAvailableAsync();
}