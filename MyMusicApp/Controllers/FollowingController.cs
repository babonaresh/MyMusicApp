using Microsoft.AspNet.Identity;
using MyMusicApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyMusicApp.Controllers
{

    public class FollowingDto
    {
        public string FolloweeId { get; set; }
    }
    [Authorize]
    public class FollowingController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public FollowingController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Follow(FollowingDto dto)
        {
            var userId = User.Identity.GetUserId();
            if (_context.Followings
                .Any(a => a.FolloweeId == userId && a.FollowerId == dto.FolloweeId))
                return BadRequest(" Already Following as Favourites");
            var following = new Following
            {
                FollowerId = userId,
                FolloweeId=dto.FolloweeId
            };
            
            _context.Followings.Add(following);
            _context.SaveChanges();

            return Ok();
        }
    }

}
