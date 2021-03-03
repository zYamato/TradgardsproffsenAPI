using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Models.UserModel;
using TradgardsproffsenAPI.Services;

namespace TradgardsproffsenAPI.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ILeadsRepo _leadRepo;
        private readonly IMapper _mapper;

        public AccountController(ILeadsRepo leadRepo, IMapper mapper)
        {
            _leadRepo = leadRepo;
            _mapper = mapper;
        }

        [Route("register")]
        [HttpPost()]
        public IActionResult Register(CreateUserDto createUser)
        {
            if (createUser != null)
            {
                if (!ModelState.IsValid) return BadRequest($"{createUser.Username} could not be added");

                var userEntity = _mapper.Map<User>(createUser);
                _leadRepo.AddUser(userEntity);
                _leadRepo.Save();

                return Ok($"{createUser.Username} has been added");
            }

            return BadRequest("CreateUser Error");
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login(LoginUserDto user)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var token = _leadRepo.AuthenticateUser(user.Username, user.Password);

            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token),
                expires = token.ValidTo,
                info = "login only used for auth just for now, will be changed later."
            });
        }
    }
}
