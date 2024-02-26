using Kodlama.ioDemo.Business.Concretes;
using Kodlama.ioDemo.DataAccess.Abstracts;
using Kodlama.ioDemo.DataAccess.Concretes;
using Kodlama.ioDemo.Entities.Concretes;

Course course = new Course();
course.Name = ".net Geliştirme";
course.Price = 0;
course.Id = 4;
course.CategoryId = 2;

CourseManager courseManager = new CourseManager(new CourseDal());
courseManager.Add(course);
courseManager.Delete(3);

List<Course> courses = courseManager.GetAll();
foreach (var course1 in courses)
{
    Console.WriteLine(course1.Name + "/" + course1.Price);
}
