namespace MobileFacilityFood.Services;

internal interface IDistanceCalculationService
{
    double Calculate(double point1Latitude, double point1Longitude, double point2Latitude, double point2Longitude);
}