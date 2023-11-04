using AutoMapper;
using DatesApp.Dto;
using DatesApp.Entities;
using DatesApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DatesApp.Controllers
{
    public class UsersController : BaseApiController
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IMapper _mapper;

        public UsersController(IUsersRepository usersRepository, IMapper mapper)
        {
            _usersRepository = usersRepository;
            _mapper = mapper;
        }

        [HttpGet]
        // [Authorize]
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
        {
            return Ok(_mapper.Map<IEnumerable<MemberDto>>(await _usersRepository.GetUsersAsync()));
        }

        [HttpGet("{username}")]
        // [Authorize]
        public async Task<ActionResult<MemberDto>> GetUser(string username)
        {
            return Ok(_mapper.Map<MemberDto>(await _usersRepository.GetUserByUsernameAsync(username)));
        }
    }
}
