using System.Collections.Generic;
using System.Threading.Tasks;
using Employee_API.Models;
using Employee_API.Services;
using Microsoft.AspNetCore.Mvc;

/*
By convention, all classes in this folder that end with the suffix “Controller” 
will become controllers of our application. 
It means they are going to handle requests and responses. 
You have to inherit this class from the Controller class, 
defined in the namespace Microsoft.AspNetCore.Mvc.

A namespace consists of a group of related classes, 
interfaces, enums, and structs. You can think of it as something 
similar to modules of the Javascript language, or packages from Java.

The new controller should respond through the route /api/categories. 
We achieve this by adding the Route attribute above the class name, 
specifying a placeholder that indicates that the route should 
use the class name without the controller suffix, by convention.
 */


/*
Let’s start handling GET requests. First of all, 
when someone requests data from /api/categories via GET verb,
 the API needs to return all categories. We can create a category service for 
 this purpose.

Conceptually, a service is basically a class or interface that defines methods 
ndle some business logic. It is a common practice 
in many different programming languages to create services to handle 
business logic, such as authentication and authorization, payments, 
complex data flows, caching and tasks that require some interaction 
between other services or models.

Using services, we can isolate the request and response handling from the 
real logic needed to complete tasks.

The service we’re going to create initially will define a single behavior, 
or method: a listing method. We expect that this method returns all existing 
categories in the database.

For simplicity, we won’t deal with data pagination or filtering in this case.
 I’ll write an article in the future showing how to easily handle these 
 features.

To define an expected behavior for something in C# 
(and in other object-oriented languages, such as Java, for example), 
we define an interface. An interface tells how something should work,
 but does not implement the real logic for the behavior. 
 The logic is implemented in classes that implement the interface.
  If this concept isn’t clear for you, don’t worry. 
  You’ll understand it in a while.
 */

namespace Employee_API.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var categories = await _categoryService.ListAsync();
            return categories;
        }
    }
}

/*
I have defined a constructor function for our controller 
(a constructor is called when a new instance of a class is created), 
and it receives an instance of ICategoryService. 
It means the instance can be anything that implements the service interface. 
I store this instance in a private, read-only field _categoryService.
 We’ll use this field to access the methods of our category service 
 implementation.

By the way, the underscore prefix is another common convention to denote a 
field. This convention, in special, is not recommended by the official 
naming convention guideline of .NET, but it is a very common practice as 
a way to avoid having to use the “this” keyword to distinguish class 
fields from local variables. I personally think it’s much cleaner to read, 
and a lot of frameworks and libraries use this convention.

Below the constructor, I defined the method that is going to handle 
requests for /api/categories. The HttpGet attribute tells the ASP.NET Core 
pipeline to use it to handle GET requests (this attribute can be omitted,
 but it’s better to write it for easier legibility).

The method uses our category service instance to list all categories and 
then returns the categories to the client. The framework pipeline handles 
the serialization of data to a JSON object. The IEnumerable<Category>type 
tells the framework that we want to return an enumeration of categories,
 and the Task type, preceded by the async keyword, tells the pipeline 
 that this method should be executed asynchronously. Finally,
  when we define an async method, we have to use the await keyword for 
  tasks that can take a while.

Ok, we defined the initial structure of our API. Now, 
it is necessary to really implement the categories service.
 */