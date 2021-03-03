using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using TradgardsproffsenAPI.Services;

namespace TradgardsproffsenAPI.Controllers
{
#pragma warning disable CS1591
    [Route("token")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly ILeadsRepo _realEstateRepo;

        public TokenController(ILeadsRepo realEstateRepo)
        {
            this._realEstateRepo = realEstateRepo;
        }

        [HttpPost]
        public IActionResult Authenticate(string username, string password)
        {
            var token = _realEstateRepo.AuthenticateUser(username, password);           
            if (token == null) return Unauthorized();

            return Ok(new
            {
                access_token = new JwtSecurityTokenHandler().WriteToken(token),
                token_type = token.Header.Typ,
                userName = username,
                expiration = token.ValidTo,
                issued = token.ValidFrom
            });
        }
    }
}
