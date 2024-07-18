﻿using SkillsMatrix.Models;
using SkillsMatrix.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Services
{
    public class CategoryService
    {
        private readonly IRepository<Category> _repository;

        public CategoryService(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task Add(Category category)
        {
            await _repository.AddAsync(category);
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Category> GetById(int id)
        {
            return await _repository.GetAsync(id);
        }
    }
}
