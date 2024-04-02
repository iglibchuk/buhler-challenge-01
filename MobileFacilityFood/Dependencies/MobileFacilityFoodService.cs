using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace MobileFacilityFood.Dependencies;

internal class MobileFacilityFoodService(
    HttpClient httpClient,
    IOptionsSnapshot<MobileFacilityFoodServiceConfiguration> configuration,
    ILogger<MobileFacilityFoodService> logger)
{
    private readonly MobileFacilityFoodServiceConfiguration _configuration = configuration.Get(MobileFacilityFoodServiceConfiguration.Section);

    public async Task<IEnumerable<MobileFacilityFoodItem>> GetAllAsync()
    {
        var response = await httpClient.GetAsync(_configuration.Endpoint);
        if (!response.IsSuccessStatusCode)
        {
            logger.LogError("Mobile Facility Food Service Dataset Endpoint is unavailable");
            return [];
        }

        return JsonConvert.DeserializeObject<MobileFacilityFoodItem[]>(await response.Content.ReadAsStringAsync()) ?? [];
    }
}