using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Layer1.WEB.Controllers
{
    public class LoginController : ApiController
    {


        //public class LoginDetails
        //{
        //    public int Id { get; set; }
        //    public string Username { get; set; }
        //    public string Password { get; set; }
        //}




        //private AuthRepository _repo = new AuthRepository();






        //// GET: api/Login/
        //[HttpPost]
        //[Route("api/Login/")]
        //public IHttpActionResult Login(BStudent loginDetails)
        //{
        //    BStudentContext db = new BStudentContext();
        //    //string a = loginDetails.Username;
        //    //string b = loginDetails.Password;

        //    // IdentityUser result = await _repo.FindUser(a,b);

        //    //return Ok("Api Hit");
        //    //var user = _repo.FindUser(a,b);
        //    //var user = _context.Users.SingleOrDefault(x => x.Username == username);
        //    var user = db.BStudents.SingleOrDefault(x => x.Name == loginDetails.Name);




        //    if (loginDetails == null)
        //        return Unauthorized();

        //    var tokenHandler = new JwtSecurityTokenHandler();

        //    var tokenDescriptor = new SecurityTokenDescriptor
        //    {
        //        Subject = new ClaimsIdentity(new Claim[]
        //        {
        //            new Claim(ClaimTypes.Name, user.Id.ToString())
        //        }),
        //        Expires = DateTime.UtcNow.AddDays(7),
        //    };
        //    var token = tokenHandler.CreateToken(tokenDescriptor);
        //    var tokenString = tokenHandler.WriteToken(token);

        //    // return basic user info (without password) and token to store client side
        //    return Ok(tokenString);


        //}



    }
}
