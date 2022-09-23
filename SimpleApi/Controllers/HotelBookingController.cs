using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleApi.Models;
using SimpleApi.Data;

namespace SimpleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelBookingController : ControllerBase
    {
        private readonly ApiContext _context;
        public HotelBookingController(ApiContext context)
        {
            _context = context;
        }

        //create and edit bookings
        [HttpPost]
        public IActionResult createEdit(HotelBooking booking)
        {
            if(booking.Id == 0)
            {
                _context.Bookings.Add(booking);
            }else
            {
                var bookingInDb = _context.Bookings.Find(booking.Id);

                if(bookingInDb == null)
                    return new JsonResult(NotFound());

                bookingInDb = booking;
            }

            _context.SaveChanges();
            return Ok(booking);
        }

        [HttpGet]
        public JsonResult GetBooking(int id)
        {
            var result = _context.Bookings.Find(id);

            if (result == null)
            {
                return new JsonResult(NotFound());
            }
            return new JsonResult(Ok(result));
        }
    }
}
