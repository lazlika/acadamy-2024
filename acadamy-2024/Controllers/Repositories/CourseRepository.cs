using acadamy_2024.Controllers.Data;
using acadamy_2024.Controllers.Models;

namespace acadamy_2024.Controllers.Repositories
{
    public class Courserepository
    {
        private readonly Applicationdbcontext _con;
        public Courserepository()
        {
            _con = new Applicationdbcontext();
        }
        public List<Course> GetAll() => _con.Courses.ToList();
        public Course? GetById(int id) => _con.Courses.FirstOrDefault(course => course.Id == id);
       

        public void Create(Course data)
        {
            _con.Courses.Add(data);
            _con.SaveChanges();
        }
        public Course? Update(int id, Course data)
        {
            var course = _con.Courses.FirstOrDefault(course => course.Id == id);

                if (course !=null)
                {
                    course.Name = data.Name;
                    course.Description = data.Description;
                    return course;
                _con.SaveChanges();
                }
            return null;
        }

    
        public bool Delete(int id)
        {
            var course = _con.Courses.FirstOrDefault(course => course.Id == id);

            if (course != null)
            {
                _con.Courses.Remove(course);
                _con.SaveChanges();
                return false;
                
            }
            return false;
        }
    }
}
