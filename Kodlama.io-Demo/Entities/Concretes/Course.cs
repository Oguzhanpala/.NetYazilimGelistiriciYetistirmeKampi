using Kodlama.ioDemo.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.ioDemo.Entities.Concretes;

public class Course:IEntity
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Course(int id, int categoryId, string name, double price)
    {
        Id = id;
        CategoryId = categoryId;
        Name = name;
        Price = price;
    }
    public Course()
    {
        
    }
}
