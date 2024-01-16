using BlazorServer.CarService.Shared.Responses;
using BlazorServer.CarService.Shared.ViewModels;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorServer.CarService.ApiServices.ServiceFolder
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly HttpClient httpClient;

        public ServiceRepository(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Response> AddService(AddServiceViewModel model)
        {
            var result = await httpClient.PostAsJsonAsync("api/service", model);
            var response = await result.Content.ReadFromJsonAsync<Response>();
            return response!;
        }

        public async Task<List<GetServiceViewModel>> GetServices()
        {
            var result = await httpClient.GetAsync("api/service");
            var response = await result.Content.ReadFromJsonAsync<List<GetServiceViewModel>>();
            return response!;
        }
    }
}