using Kodlama.ioDemo.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.ioDemo.Entities.Concretes;

public class Instructor:IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Instructor(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public Instructor()
    {
        
    }
}
