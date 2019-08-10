using System.Collections.Generic;
using Employee_API.Dmain.Models;

namespace Employee_API.Domain.Models
{
    /*
    The class has an Id property, to identify the category, and a Nameproperty.
     We also have a Products property. 
     This last one will be used by Entity Framework Core,
     the ORM most ASP.NET Core applications use to persist data into a database, 
     to map the relationship between categories and products.
     It also makes sense thinking in terms of object-oriented programming,
     since a category has many related products.
     */
    public class Category
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public IList<Product> Products {get; set;} = new List<Product>();
    }
}