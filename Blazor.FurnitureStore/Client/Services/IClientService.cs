using Blazor.FurnitureStore.Shared;

namespace Blazor.FurnitureStore.Client.Services

{
    public interface IClientService
    {
        Task<IEnumerable<Blazor.FurnitureStore.Shared.Client>> GetClient();
    }
}
