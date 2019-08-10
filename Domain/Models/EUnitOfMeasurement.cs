using System.ComponentModel;

/*
Let’s define the last part of our domain models, the EUnitOfMeasurement enum.
By convention, enums doesn't need to start with an “E” in front of their names,
but in some libraries and frameworks you'll find this prefix as 
a way to distinguish enums from interfaces and classes.
 */

 /*
 The code is really straightforward. Here we defined only a handful of possibilities for units of measurement, 
 however, in a real supermarket system, you may have many other units of measurement, 
 and maybe a separate model for that.

Notice the Description attribute applied over every enumeration possibility. 
An attribute is a way to define metadata over classes, interfaces, properties and other components of the C# language. 
In this case, we’ll use it to simplify the responses of the products API endpoint,
 but you don’t have to care about it for now. We’ll come back here later.

Our basic models are ready to be used. Now we can start writing the API endpoint that is going to manage all categories.
  */

namespace Employee_API.Dmain.Models
{
    public enum EUnitOfMeasurement : byte
    {
        [Description("UN")]
        Unity = 1,

        [Description("MG")]
        Miligram = 2,

        [Description("G")]
        Gram = 3,

        [Description("KG")]
        Kilogram = 4,

        [Description("L")]
        Liter = 5
    }
}