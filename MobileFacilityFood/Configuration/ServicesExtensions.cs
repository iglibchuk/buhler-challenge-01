using MobileFacilityFood.Dependencies;
using MobileFacilityFood.Services;

namespace MobileFacilityFood.Configuration;

public static class ServicesExtensions
{
    public static IServiceCollection AddMobileFacilityFoodServices(this IServiceCollection services)
    {
        services.AddTransient<MobileFacilityFoodService>();
        services.AddTransient<IMobileFacilityFoodService, MobileFacilityFoodCachedService>();
        services.AddTransient<IMobileFacilityFoodSearchService, MobileFacilityFoodSearchService>();
        services.AddTransient<IDistanceCalculationService, DistanceCalculationService>();

        services.AddOptions<MobileFacilityFoodServiceConfiguration>(MobileFacilityFoodServiceConfiguration.Section).Configure<IConfiguration>((options, configuration) =>
        {
            configuration.GetSection(MobileFacilityFoodServiceConfiguration.Section).Bind(options);
        });

        return services;
    }
}