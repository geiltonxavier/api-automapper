using API_AutoMapperExample.DTO;
using API_AutoMapperExample.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API_AutoMapperExample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserController(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        [HttpGet]        
        public ActionResult<List<UserDTO>> Get()
        {
            var users = _userRepository.GetUsers();

            return _mapper.Map<List<UserDTO>>(users);
        }
    }
}
