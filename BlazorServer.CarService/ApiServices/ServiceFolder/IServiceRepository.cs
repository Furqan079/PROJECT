using BlazorServer.CarService.Shared.Responses;
using BlazorServer.CarService.Shared.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorServer.CarService.ApiServices.ServiceFolder
{
    public interface IServiceRepository
    {
        Task<Response> AddService(AddServiceViewModel model);
        Task<List<GetServiceViewModel>> GetServices();
    }
}