using GuitarStore.Portal.Application.AppNewGuitar.Interface;
using GuitarStore.Portal.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GuitarStore.Portal.Api.Controllers
{
    [Route("guitarstore/api/[controller]")]
    [ApiController]
    public class GuitarController : ControllerBase
    {
        private readonly IGuitarAppService _newGuitarAppService;

        public GuitarController(IGuitarAppService newGuitarAppService)
        {
            _newGuitarAppService = newGuitarAppService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Guitar), StatusCodes.Status200OK)]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> PostAsync([FromBody] Guitar newGuitar)
        {
            var newGuitarCreated = await _newGuitarAppService
                                            .InsertAsync(newGuitar)
                                            .ConfigureAwait(false);

            return (IActionResult)newGuitarCreated;
        }
    }
}
