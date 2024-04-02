namespace MobileFacilityFood.Services;

public class DistanceCalculationService : IDistanceCalculationService
{
    public double Calculate(double point1Latitude, double point1Longitude, double point2Latitude, double point2Longitude)
    {
        // the area is limited by San Francisco
        // for quick calculation and clean code the distance could be calculated approximately 
        // we count latitude and longitude as X and Y of a Cartesian coordinate system
        var deltaLatitude = point1Latitude - point2Latitude;
        var deltaLongitude = point1Longitude - point2Longitude;
        return Math.Sqrt(deltaLatitude * deltaLatitude + deltaLongitude * deltaLongitude);
    }
}