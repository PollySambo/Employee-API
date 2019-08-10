# Employee-API
A simple employee api containing their details. ill be using REST services and dotnet

dotnet new webapi

Step 1 — Creating the API
First of all, we have to create the folders structure for the web service, and then we have to use the .NET CLI tools to scaffold a basic web API. Open the terminal or command prompt (it depends on the operating system you are using) and type the following commands, in sequence:

Structure Overview

An ASP.NET Core application consists of a group of middlewares (small pieces of the application attached to the application pipeline, that handle requests and responses) configured in the Startup class. If you’ve already worked with frameworks like Express.js before, this concept isn’t new to you.

When the application starts, the Main method, from the Program class, is called. It creates a default web host using the startup configuration, exposing the application via HTTP through a specific port (by default, port 5000 for HTTP and 5001 for HTTPS).


Step 2 — Creating the Domain Models
I’m going to apply some design concepts that will keep the application simple and easy to maintain.

Writing code that can be understood and maintained by yourself is not this difficult, but you have to keep in mind that you’ll work as part of a team. If you don’t take care on how you write your code, the result will be a monster that will give you and your teammates constant headaches. It sounds extreme, right? But believe me, that’s the truth.

Let’s start by writing the domain layer. This layer will have our models classes, the classes that will represent our products and categories, as well as repositories and services interfaces. I’ll explain these last two concepts in a while.

Inside the Supermarket.API directory, create a new folder called Domain. Within the new domain folder, create another one called Models. The first model we have to add to this folder is the Category. Initially, it will be a simple Plain Old CLR Object (POCO) class. It means the class will have only properties to describe its basic information.

