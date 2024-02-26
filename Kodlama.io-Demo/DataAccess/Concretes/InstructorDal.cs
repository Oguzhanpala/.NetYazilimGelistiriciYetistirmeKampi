using Kodlama.ioDemo.DataAccess.Abstracts;
using Kodlama.ioDemo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.ioDemo.DataAccess.Concretes;

public class InstructorDal : IInstructorDal
{
    List<Instructor> instructors;

    public InstructorDal()
    {
        instructors = new List<Instructor>();
        instructors.Add(new Instructor(1, "Engin Demiroğ"));
        instructors.Add(new Instructor(2, "Halit Enes Kalaycı"));
    }
    public void Add(Instructor instructor)
    {
        instructors.Add(instructor);
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Instructor> GetAll()
    {
        return instructors;
    }

    public Instructor GetById(int id)
    {
        foreach (var instructor in instructors)
        {
            if (instructor.Id == id)
            {
                return instructor;
            }
        }
        return null;
    }

    public void Update(Instructor instructor)
    {
        var updateInstructor = GetById(instructor.Id);
        updateInstructor.Name = instructor.Name;
    }
}
