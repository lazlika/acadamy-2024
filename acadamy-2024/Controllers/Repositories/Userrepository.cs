using acadamy_2024.Controllers.Data;
using acadamy_2024.Controllers.Models;

namespace acadamy_2024.Controllers.Repositories
{
    public class Userrepository
    {
        private readonly Applicationdbcontext _context;
        public Userrepository()
        {
            _context = new Applicationdbcontext();
        }
        public List<User> Getolder18() => _context.Users.Where(u =>( u.Age >18)).ToList();
        public List<User> GetAll() => _context.Users.ToList();

        public User? GetById(int id) => _context.Users.FirstOrDefault(user => user.Id == id);
        

        public void Create(User data)
        {
            _context.Users.Add(data);
            _context.SaveChanges();
        }
        public User? Update(int id, User data)
        {
            var user = _context.Users.FirstOrDefault(user => user.Id == id);
            if (user != null)
            {
                user.Firstname = data.Firstname;
                user.Lastname = data.Lastname;
                return user;
                _context.SaveChanges();
            }
            return null;

        }
        public bool Delete(int id)
        {

            var user = _context.Users.FirstOrDefault(user => user.Id == id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
                return true;
                
            }
            return false;
        }
    }
}
