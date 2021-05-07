using MechanicalWorkShopSystem.Domain;
using MechanicalWorkShopSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MechanicalWorkShopSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private readonly IProviderService _providerService;

        public ProviderController(IProviderService providerService)
        {
            _providerService = providerService;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Provider>>> GetAll()
        {
            var result = await _providerService.GetAll();
            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Provider>> GetById(long id)
        {
            return Ok(await _providerService.GetById(id));
        }

        [HttpPost]
        public async Task<ActionResult<Provider>> Post(Provider item)
        {
            return Ok(await _providerService.PostProvider(item));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Provider>> PutCiudadano(int id, Provider item)
        {
            return Ok(await _providerService.PutProvider(item));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Provider>> DeleteById(int id)
        {
            return Ok(await _providerService.DeleteProvider(id));
        }
    }
}
