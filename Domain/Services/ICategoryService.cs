using System.Collections.Generic;
using System.Threading.Tasks;
using Employee_API.Models;

/*
The implementations of the ListAsync method must 
asynchronously return an enumeration of categories.

The Task class, encapsulating the return, indicates asynchrony. 
We need to think in an asynchronous method due to the fact that we have
 to wait for the database to complete some operation to return the data, 
 and this process can take a while. Notice also the “async” suffix. 
 It’s a convention that indicates that our method should be executed 
 asynchronously.

We have a lot of conventions, right? I personally like it,
 because it keeps applications easy to read, 
 even if you’re new to a company that uses .NET technology.
 */


/*
“ - Ok, we defined this interface, 
but it does nothing. How can it be useful?”

If you come from a language such as Javascript or another non-strongly 
typed language, this concept may seem strange.

Interfaces allow us to abstract the desired behavior from the real 
implementation. Using a mechanism known as dependency injection,
 we can implement these interfaces and isolate them from other components.

Basically, when you use dependency injection, you define some behaviors 
using an interface. Then, you create a class that implements the interface. 
Finally, you bind the references from the interface to the class you created.

“ - It sounds really confusing. Can’t we simply create a class that does 
these things for us?”

Let’s continue implementing our API and you will understand why to use
 this approach.
 */

namespace Employee_API.Dmain.Services
{
    public interface ICategoryService
    {
         Task<IEnumerable<Category>> ListAsync();
    }
}