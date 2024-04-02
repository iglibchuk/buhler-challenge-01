namespace MobileFacilityFood.Services;

public class DistanceCalculationService : IDistanceCalculationService
{
    const double R = 6371000; // Radius of the earth in meters
    public double Calculate(double point1Latitude, double point1Longitude, double point2Latitude, double point2Longitude)
    {
        var dLat = DegreeTo2Radian(point2Latitude - point1Latitude);  // deg2rad below
        var dLon = DegreeTo2Radian(point2Longitude - point1Longitude);

        var a =
                Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                Math.Cos(DegreeTo2Radian(point1Latitude)) * Math.Cos(DegreeTo2Radian(point2Latitude)) *
                Math.Sin(dLon / 2) * Math.Sin(dLon / 2)
            ;
        var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
        var d = R * c; // Distance in km
        return d;
    }

    private double DegreeTo2Radian(double deg)
    {
        return deg * (Math.PI / 180);
    }
}