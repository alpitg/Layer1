﻿using Layer1.ENTITIES;
using Layer1.SERVICES.Abstract;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Layer1.WEB.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LoginController : ApiController
    {
        
        private readonly IStudentService _iStudentService;

        public LoginController(IStudentService iStudentService)
        {
            _iStudentService = iStudentService;
        }


        // GET: api/Login/
        [HttpPost]
        [Route("api/Login/")]
        public IHttpActionResult Login(CStudent loginDetails)
        {

            var alluser = _iStudentService.GetAllStudentsWithoutParam();
            var user = alluser.FirstOrDefault(a=>a.Name==loginDetails.Name);




            if (loginDetails == null)
                return Unauthorized();

            var tokenHandler = new JwtSecurityTokenHandler();

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(1),
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            // return basic user info (without password) and token to store client side
            return Ok(tokenString);


        }



    }
}
