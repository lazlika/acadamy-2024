using acadamy_2024.Controllers.Models;

namespace acadamy_2024.Controllers.Repositories
{
    public class Userrepository
    {
        private static  List<User> Users = new List<User>() { new User() { Id = 1, Firstname = "John", Lastname = "Lennon" } };
    public List<User> GetAll() { return Users; }

        public User? GetById(int id)
        {
            foreach  (var user in Users)
            {

                if (user.Id == id)
                { return user; }
            }
            return
                null;
        }

        public void Create(User data)
        {
            Users.Add(data);
        }
        public User? Update(int id, User data)
        {
            foreach (var user in Users)
            {

                if (user.Id == id)
                {
                    user.Firstname = data.Firstname;
                    user.Lastname = data.Lastname;
                    return user; }
            }
            return
                null;
        }
        public bool Delete(int id)
        {
            foreach (var user in Users)
            {

                if (user.Id == id)
                {
                    Users.Remove(user);
                    return true; }
            }
            return
                false;
        }
    }
}
