using System.Collections.Generic;
using System.Threading.Tasks;
using Employee_API.Domain.Repositories;
using Employee_API.Models;

/*
Here we’ll put all services implementations. 
 */

/*
It’s simply the basic code for the interface implementation, 
but we still don’t handle any logic. Let’s think in how the listing 
method should work.

We need to access the database and return all categories, 
then we need to return this data to the client.

A service class is not a class that should handle data access. 
There is a pattern called Repository Pattern that is used to manage data 
from databases.

When using the Repository Pattern, we define repository classes, 
that basically encapsulate all logic to handle data access.  
These repositories expose methods to list, create, 
edit and delete objects of a given model, the same way you can manipulate 
collections. Internally, these methods talk to the 
database to perform CRUD operations, isolating the database access
 from the rest of the application.

Our service needs to talk to a category repository, 
to get the list of objects.

Conceptually, a service can “talk” to one or more repositories or other 
services to perform operations.

It may seem redundant to create a new definition for handling the data 
access logic, but you will see in a while that isolating this logic 
from the service class is really advantageous.

Let’s create a repository that will be responsible for intermediating 
the database communication as a way to persist categories.
 */

namespace Employee_API.Services
{
    public class CategoryService : ICategoryService
    {
       private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }
        public async Task<IEnumerable<Category>> ListAsync()
        { 
            return await _categoryRepository.ListAsync();
        }
    }
}