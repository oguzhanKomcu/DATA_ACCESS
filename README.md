# DATA_ACCESS
I have created my examples of data access topics in this repository. I have examples and projects on topics such as entity framework , data first , code first , Orm , database creation.

## ORM (Object Relational Mapping)
It is a tool that acts as a bridge between a relational database and object-oriented programming (OOP). This bridge is a structure where we use our object models to manage our information in the relational database. In short, it is a framework developed by Microsoft that connects our objects to the database and exchanges data for us.

## ENTIY FRAMEWORK
By using LINQ (Language Integrated Query) queries with the Entity framework, we have a powerful query on objects. The services provided by the Entity framework are mainly change tracking, identity resolution, and query translation.The main purpose of the Entity framework is to enable the application developer to focus on the application side without being too busy with data operations. As a very simple example, we developers are entirely responsible for opening and closing a connection in classic ADO.NET applications. However, when you use the entity framework, you do not interfere with such operations. You prepare your query and send it to the database via the entity framework.

## PROJECT DEVELOPMENT METHODS

Entity Framework uses 3 different project development methods for this.

Model First = This method allows to design the database on this model by adding an empty model file (.edmx) on Visual Studio. The script file given in the compilation step creates the database.

Database First = In this direction, our necessary classes are created by Entity Framework by connecting the previously created database to the project as a model.

In this folder, I showed my examples of database first. [GitHub Pages](https://github.com/oguzhanKomcu/DATA_ACCESS/tree/master/DB_First).

Code First =  This method is a method that we perform by starting to create our classes in the visual studio environment. Our database is derived from these classes. Here, Mapping operations can be done by the developer thanks to Attributes while creating classes. By the way, the Mapping process is the event where we define our constraints in our tables. In addition to attributes, we can perform these operations in different ways. For example, tools such as Fluent Api or Fluent Validation are popularly used for Mapping operations.

## SELECT OPERATİONS WİTH ENTİTY FRAMEWORK
Using the Entity Framework library, we can filter the data by making queries on a table in our database. Almost all the queries you can do on T-SQL can be done with Entity Framework. 

Here I have shown the basic select operations. [GitHub Pages](https://github.com/oguzhanKomcu/DATA_ACCESS/blob/master/DB_First/Linq_To_Queries.cs).

## USING AGGREGATE FUNCTİON WİTH ENTİTY FRAMEWORK
You can also use the integrated functions of T-SQL queries and reporting with the Entity Framework library.

Here I showed our basic aggregate functions. [GitHub Pages](https://github.com/oguzhanKomcu/DATA_ACCESS/blob/master/DB_First/Linq_Aggregate_Function_Examples.cs).


