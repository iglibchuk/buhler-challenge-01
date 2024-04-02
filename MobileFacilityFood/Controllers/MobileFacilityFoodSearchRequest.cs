using System.ComponentModel.DataAnnotations;

namespace MobileFacilityFood.Controllers;

public class MobileFacilityFoodSearchRequest
{
    [Range(-90, 90)]
    public double Latitude { get; set; }

    [Range(-180, 180)]
    public double Longitude { get; set; }

    [Range(1, 1000)]
    public int Limit { get; set; }
    public string? PreferredFood { get; set; }
}