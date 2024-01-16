using BlazorServer.CarService.Shared.Responses;
using BlazorServer.CarService.Shared.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorServer.CarService.ApiServices.BookingFolder;

public interface IBookingRepository
{
    Task<Response> AddBooking(AddBookingViewModel model);
    Task<List<GetBookingViewModel>> GetBookings();
}