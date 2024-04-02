using MobileFacilityFood.Framework;
using Newtonsoft.Json;

namespace MobileFacilityFood.Dependencies;

public class MobileFacilityFoodItem
{
    public string? Cnn;
    [JsonConverter(typeof(StringToArrayConverter))]
    public string[]? FoodItems { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string ObjectId { get; set; }
    public string Applicant { get; set; }
    public string FacilityType { get; set; }
    public string? LocationDescription { get; set; }
    public string? Address { get; set; }
    public string? BlockLot { get; set; }
    public string? Block { get; set; }
    public string? Lot { get; set; }
    public string? Permit { get; set; }
    public ApplicationStatus Status { get; set; }
    public string Schedule { get; set; }
}