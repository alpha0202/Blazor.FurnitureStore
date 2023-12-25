using Blazor.FurnitureStore.Shared;
using System.ComponentModel.Design;
using System.Net.Http.Json;

namespace Blazor.FurnitureStore.Client.Services
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _httpClient;

        public OrderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task SaveOrder(Order order)
        {
            if (order.Id == 0)
                //insert
                await _httpClient.PostAsJsonAsync<Order>($"api/order/", order);
            //else 
               //update
        }
    }
}
