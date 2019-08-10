using System.Collections.Generic;
using System.Threading.Tasks;
using Employee_API.Domain.Models;

/*
The initial code is basically identical to the code of the service interface.
 */

 /*
 Having defined the interface, we can come back to the service class 
 and finish implementing the listing method, using an instance 
 of ICategoryRepository to return the data.
  */

namespace Employee_API.Domain.Repositories
{
    public interface ICategoryRepository
    {
         Task<IEnumerable<Category>> ListAsync();
    }
}