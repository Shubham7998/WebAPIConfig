using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Task<T> CreateAsync(T entity)
        {

        }
    }

   
}
