using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradgardsproffsenAPI.Models.UserModel;
using TradgardsproffsenAPI.Services;

namespace TradgardsproffsenAPI.Controllers
{
    public class UserController : ControllerBase
    {

        private readonly ILeadsRepo _leadRepo;
        private readonly IMapper _mapper;

        public UserController(ILeadsRepo leadRepo, IMapper mapper)
        {
            _leadRepo = leadRepo;
            _mapper = mapper;
        }

        [HttpGet()]
        public ActionResult<IEnumerable<UserDto>> GetUser()
        {
            var userFromRepo = _leadRepo.GetUsers();
            return Ok(_mapper.Map<IEnumerable<UserDto>>(userFromRepo));
        }

        [HttpGet("{username}", Name="GetUser")]
        public IActionResult GetUser(string username)
        {
            var userFromRepo = _leadRepo.GetUser(username);
            return Ok(_mapper.Map<UserDto>(userFromRepo));
        }
    }
}
