using Employee_API.Domain.Models;

namespace Employee_API.Dmain.Models
{

    /*
    The product also has properties for the Id and name. 
    The is also a property QuantityInPackage, that tells how many units of the product we have in one pack 
    (remember the biscuits example of the application scope) and a UnitOfMeasurement property. This one is represented by an enum type, 
    that represents an enumeration of possible units of measurement. 
    The last two properties, CategoryId and Category will be used by the ORM to map the relationship between products and categories. 
    It indicates that a product has one, and only one, category.
     */
    
    public class Product
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public short QualityInPackage {get; set;}
        public EUnitOfMeasurement UnitOfMeasurement {get; set;}
        public int CategoryId {get; set;}
        public Category Category {get; set;}
    }
}