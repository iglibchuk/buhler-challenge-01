using Microsoft.AspNetCore.Mvc;
using MobileFacilityFood.Services;

namespace MobileFacilityFood.Controllers;

public class MobileFacilityFoodController(IMobileFacilityFoodSearchService mobileFacilityFoodSearchService) : BaseApiController
{
#if DEBUG
    [HttpGet]
    [ProducesResponseType<MobileFacilityFoodSearchResult>(StatusCodes.Status200OK)]
    public async Task<IActionResult> Search()
    {
        var serviceResult = await mobileFacilityFoodSearchService.SearchAsync(37.4, -122.4, null, 5);
        return Ok(new MobileFacilityFoodSearchResult(serviceResult));
    }
#endif

    [HttpPost]
    [ProducesResponseType<MobileFacilityFoodSearchResult>(StatusCodes.Status200OK)]
    public async Task<IActionResult> Search([FromBody] MobileFacilityFoodSearchRequest request)
    {
        var serviceResult = await mobileFacilityFoodSearchService.SearchAsync(request.Latitude, request.Longitude, request.PreferredFood, request.Limit);
        return Ok(new MobileFacilityFoodSearchResult(serviceResult));
    }
}