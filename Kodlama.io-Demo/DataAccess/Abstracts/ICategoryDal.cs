﻿using Kodlama.ioDemo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.ioDemo.DataAccess.Abstracts;

public interface ICategoryDal
{
    List<Category> GetAll();
    Category GetById(int id);
    void Add(Category category);
    void Update(Category category);
    void Delete(int id);

}
