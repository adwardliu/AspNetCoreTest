using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class UserRepository : IRepository<User>
    {
        private List<User> list = new List<User>();
        public UserRepository()
        {
            for (int i = 0; i < 30; i++)
            {
                var user = new User() { Id = i, Name = "name" + i, Sex = i % 2 == 0 ? "Male" : "Female" };
                list.Add(user);
            }
        }

        public void Delete(int id)
        {
            var user = list.First(u=>u.Id == id);
            if(user!=null)
            list.Remove(user);
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllList()
        {
            return list;
        }

        public List<User> GetAllList(Expression<Func<User, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllListAsync(Expression<Func<User, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public User Insert(User entity)
        {
          list.Add(entity);
          return entity;
        }

        public Task<User> InsertAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public User Update(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateAsync(User entity)
        {
            throw new NotImplementedException();
        }

        User IRepository<User>.Get(int id)
        {
            return list.First(item => item.Id == id);
        }
    }
}