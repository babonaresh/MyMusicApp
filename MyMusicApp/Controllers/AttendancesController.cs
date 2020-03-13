using Microsoft.AspNet.Identity;
using MyMusicApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyMusicApp.Controllers
{

    public class AttendanceDto
    {
        public int GigId { get; set; }
    }
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _context;
        public AttendancesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto dto)
        {
            var userId = User.Identity.GetUserId();
            if (_context.Attendances
                .Any(a=> a.AttendeeId ==userId && a.GigId==dto.GigId) )
                return BadRequest(" Gig is already added to your calender"); 
            var attendance = new Attendance
            {
                GigId = dto.GigId,
                AttendeeId = userId

            };
            _context.Attendances.Add(attendance);
            _context.SaveChanges();

            return Ok();
        }
    }
}
