using DatesApp.Data;
using DatesApp.Entities;

namespace DatesApp.Repositories
{
    public interface IUsersRepository
    {
        Task<User> GetUserByIdAsync(int id);
        Task<User> GetUserByUsernameAsync(string username);
        Task<IEnumerable<User>> GetUsersAsync();
        Task<bool> SaveAllAsync();
        void Update(User user);
    }

    public class UsersRepository : IUsersRepository
    {

        private readonly DataContext _context;

        public UsersRepository(DataContext context)
        {
            _context = context;
        }

        public Task<User> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByUsernameAsync(string username)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
