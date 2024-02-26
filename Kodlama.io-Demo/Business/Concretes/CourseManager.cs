using Kodlama.ioDemo.Business.Abstracts;
using Kodlama.ioDemo.DataAccess.Abstracts;
using Kodlama.ioDemo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.ioDemo.Business.Concretes;

public class CourseManager:ICourseService
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
       return _courseDal.GetAll();
    }

    public Course GetById(int id)
    {
        return _courseDal.GetById(id);
    }

    public void Add(Course course)
    {
        _courseDal.Add(course);
        Console.WriteLine(course.Name + " eklendi");
    }

    public void Update(Course course)
    {
        _courseDal.Update(course);
    }

    public void Delete(int id)
    {
        _courseDal.Delete(id);
    }

}
