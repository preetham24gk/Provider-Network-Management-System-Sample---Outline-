using Microsoft.AspNetCore.Mvc;
using Provider_Network_Management_System__Sample___Outline_.Domain.Entities;
using Provider_Network_Management_System__Sample___Outline_.Services;

namespace Provider_Network_Management_System__Sample___Outline_.WebAPI.Controllers
{
    [ApiController]
    [Route("api/providers")]
    public class ProviderController : Controller
    {
        private readonly ProviderService _providerService;

        public ProviderController(ProviderService providerService)
        {
            _providerService = providerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProviders()
        {
            var providers = await _providerService.GetAllProvidersAsync();
            return Ok(providers);
        }

        [HttpPost]
        public async Task<IActionResult> AddProvider([FromBody] Provider provider)
        {
            await _providerService.AddProviderAsync(provider);
            return CreatedAtAction(nameof(GetAllProviders), new { id = provider.ProviderId }, provider);
        }
    }
}
