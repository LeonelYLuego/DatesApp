using AutoMapper;
using AutoMapper.QueryableExtensions;
using DatesApp.Data;
using DatesApp.Dto;
using DatesApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatesApp.Repositories
{
    public interface IUsersRepository
    {
        Task<MemberDto> GetMemberAsync(string username);
        Task<IEnumerable<MemberDto>> GetMembersAsync();
        Task<User> GetUserByIdAsync(int id);
        Task<User> GetUserByUsernameAsync(string username);
        Task<IEnumerable<User>> GetUsersAsync();
        Task<bool> SaveAllAsync();
        void Update(User user);
    }

    public class UsersRepository : IUsersRepository
    {

        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UsersRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<MemberDto> GetMemberAsync(string username)
        {
            return (await _context.Users.Where(x => x.Username == username).ProjectTo<MemberDto>(_mapper.ConfigurationProvider).SingleOrDefaultAsync())!;
        }

        public Task<IEnumerable<MemberDto>> GetMembersAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return (await _context.Users.FindAsync(id))!;
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return (await _context.Users.SingleOrDefaultAsync(u => u.Username == username))!;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _context.Users.Include(p => p.Photos).ToListAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
        }
    }
}
