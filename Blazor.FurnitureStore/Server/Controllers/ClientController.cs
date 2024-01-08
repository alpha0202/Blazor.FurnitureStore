using Blazor.FurnitureStore.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Blazor.FurnitureStore.Shared;
using System;

namespace Blazor.FurnitureStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;

        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }


        [HttpGet]
        public async Task<IEnumerable<Blazor.FurnitureStore.Shared.Client>> GetAll()
        {
            return await _clientRepository.GetAll();
        }

    }
}
