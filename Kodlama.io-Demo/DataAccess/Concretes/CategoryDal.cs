using Kodlama.ioDemo.DataAccess.Abstracts;
using Kodlama.ioDemo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.ioDemo.DataAccess.Concretes;

public class CategoryDal : ICategoryDal
{
     List<Category> categories;

    public CategoryDal()
    {
        categories = new List<Category>();
        categories.Add(new Category(1, "Programlama"));
    }
    public void Add(Category category)
    {
        categories.Add(category);
    }

    public void Delete(int id)
    {
        categories.Remove(GetById(id));
    }

    public List<Category> GetAll()
    {
        return categories;
    }

    public Category GetById(int id)
    {
        foreach (var category in categories)
        {
            if (category.Id == id)
            {
                return category;
            }
        }
        return null;
    }

    public void Update(Category category)
    {
        var updateCategory = GetById(category.Id);
        updateCategory.Name = category.Name;
    }
}
