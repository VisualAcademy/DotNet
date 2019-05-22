using Dul.Data;
using System;
using System.Collections.Generic;

namespace InMemoryDatabase
{
    public class CategoryRepositorySqlServer : ICategoryRepository
    {
        public Category Add(Category model)
        {
            throw new NotImplementedException();
        }

        public Category Browse(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Category model)
        {
            throw new NotImplementedException();
        }

        public int Has()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> Ordering(OrderOption orderOption)
        {
            throw new NotImplementedException();
        }

        public List<Category> Paging(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public List<Category> Read()
        {
            throw new NotImplementedException();
        }

        public List<Category> Search(string query)
        {
            throw new NotImplementedException();
        }
    }
}
