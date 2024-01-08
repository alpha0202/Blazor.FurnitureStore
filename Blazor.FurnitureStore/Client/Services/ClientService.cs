
namespace Blazor.FurnitureStore.Client.Services
{
    public class ClientService : IClientService
    {
        private readonly HttpClient _httpClient;

        public ClientService(HttpClient httpClient )
        {
            _httpClient = httpClient;
        }
        public Task<IEnumerable<FurnitureStore.Shared.Client>> GetClient()
        {
            throw new NotImplementedException();
        }
    }
}
