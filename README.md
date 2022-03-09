# DATA_ACCESS
I have created my examples of data access topics in this repository. I have examples and projects on topics such as entity framework , data first , code first , Orm , database creation.

## ORM (Object Relational Mapping)

<img src="https://user-images.githubusercontent.com/96787308/157539568-20ee2449-ebb0-464e-a47f-4082fb781a3e.png" width="500" height="300">

It is a tool that acts as a bridge between a relational database and object-oriented programming (OOP). This bridge is a structure where we use our object models to manage our information in the relational database. In short, it is a framework developed by Microsoft that connects our objects to the database and exchanges data for us.

## ENTIY FRAMEWORK
<img src="https://www.seattlevfp.org/wp-content/uploads/2020/11/entityframeworklogo-white-bg.jpg" width="500" height="300">      <img src="https://www.tutorialspoint.com/entity_framework/images/data_workflow.jpg" width="500" height="300">

By using LINQ (Language Integrated Query) queries with the Entity framework, we have a powerful query on objects. The services provided by the Entity framework are mainly change tracking, identity resolution, and query translation.The main purpose of the Entity framework is to enable the application developer to focus on the application side without being too busy with data operations. As a very simple example, we developers are entirely responsible for opening and closing a connection in classic ADO.NET applications. However, when you use the entity framework, you do not interfere with such operations. You prepare your query and send it to the database via the entity framework.

## PROJECT DEVELOPMENT METHODS

Entity Framework uses 3 different project development methods for this.

Model First = This method allows to design the database on this model by adding an empty model file (.edmx) on Visual Studio. The script file given in the compilation step creates the database.

Database First = In this direction, our necessary classes are created by Entity Framework by connecting the previously created database to the project as a model.

In this folder, I showed my examples of database first. [GitHub Pages](https://github.com/oguzhanKomcu/DATA_ACCESS/tree/master/DB_First).

Code First =  This method is a method that we perform by starting to create our classes in the visual studio environment. Our database is derived from these classes. Here, Mapping operations can be done by the developer thanks to Attributes while creating classes. By the way, the Mapping process is the event where we define our constraints in our tables. In addition to attributes, we can perform these operations in different ways. For example, tools such as Fluent Api or Fluent Validation are popularly used for Mapping operations.

## DATABASE FIRST SELECT OPERATIONS

Using the Entity Framework library, we can filter the data by making queries on a table in our database. Almost all the queries you can do on T-SQL can be done with Entity Framework. 

Here I have shown the basic select operations. [GitHub Pages](https://github.com/oguzhanKomcu/DATA_ACCESS/blob/master/DB_First/Linq_To_Queries.cs).

## DATABASE FIRST AGGREGATE FUNCTION OPERATIONS

You can also use the integrated functions of T-SQL queries and reporting with the Entity Framework library.

Here I showed our basic aggregate functions. [GitHub Pages](https://github.com/oguzhanKomcu/DATA_ACCESS/blob/master/DB_First/Linq_Aggregate_Function_Examples.cs).

## CREATING A DATABASE WITH CODE FIRST

In the Code First structure, the "class" structures in the programming language correspond to the "table" structures in the database, and the "property" structures correspond to the "column" structures in the database.In addition, thanks to Attributes, Validations can be applied to database structures and certain conditions or restrictions can be placed on columns.Most importantly, it allows you to feel the auto control of the model in your project and use it as you wish with full control.

You can see my example on the subject here. [GitHub Pages](https://github.com/oguzhanKomcu/DATA_ACCESS/tree/master/Code_First).

## CREATING A DATABASE WITH CODE FIRST

I have created a vir database that you can use here.

You can check it out here. [GitHub Pages](https://github.com/oguzhanKomcu/DATA_ACCESS/tree/master/Code_First_Example).

##  N-TİER ARCHİTECTURE
It is a structure that makes our Layered Architecture projects more organized, increases the readability of the code, increases teamwork, and makes error management easier. In fact, with this structure, we have made project writing a standard. As this structure consists of 3 main layers, it can be called a Multi-Layer Architecture structure today. But it actually rests on 3 main layers. These layers are;

-- Data Layer 
-- Business Layer 
-- Presentation Layer 

Here I created my entities corresponding to my database.[GitHub Pages](https://github.com/oguzhanKomcu/DATA_ACCESS/tree/master/BankaDatabase_Project.Models/Entities).

Here I created my infrastructure layer.[GitHub Pages](https://github.com/oguzhanKomcu/DATA_ACCESS/tree/master/BankDatabase_Project.Infrastructure).

I created my UI here.[GitHub Pages](https://github.com/oguzhanKomcu/DATA_ACCESS/blob/master/BankaDatabase_Project.UserInterface(UI)/AccountCrud.cs).

## DAPPER

<img src="https://repository-images.githubusercontent.com/1613345/9d4ed380-a8e8-11eb-9f21-c8c87b0f4275" width="500" height="300">

Dapper is a micro ORM tool developed by Stackoverflow that supports many databases. Since orm tools do a lot of things themselves, this causes them to run a bit slow. It is not preferred especially in ports with heavy traffic. Dapper may be preferred in such cases. It is a single "dll". So what is an interface for mapping? It also does not need any configuration files. In short, it is simple and fast. Released as open source on Github and continues to be developed.

## AVANTAGE AND DİSAVANTAGE
### AVANTAGE
 
 --The most important feature of Dapper is its very good performance. Most of the time, it is preferred because of this advantage.
 
 --You can easily execute your queries and bind the returned result to an object easily.
 
### DİSAVANTAGE

 --The most important disadvantage is that since the queries are written inline, they are quite prone to mistakes. This should be paid attention to. Worse, these errors occur in run-time, not in build-time.
 
 --In Dapper, we do most of the things. The developer has to do the database, our queries, our assets on the program side, and the status of the objects. This greatly increases the development and maintenance costs during the development stages of large projects.
 
## HOW DAPPER WORKS?

I tried to use 2 methods in this repository. I worked with my procedures in Sql in one repository, and in my other repository by writing my queries directly on the program.

### Stored Procedure 

 -- First I created the database in SQL.
 
 -- Afterwards, I made my procedures suitable for the methods I will use in my program. You can look from here. [GitHub Pages](https://github.com/oguzhanKomcu/DATA_ACCESS/blob/master/dapperCrud.sql)
 
 --In my program I also created my layers and assets, my repositories that I will use with my procedures. The important thing here is to give my procedures and the parameters that I will use in it correctly. Otherwise, we will get a lot of errors. You can look from here. [GitHub Pages](https://github.com/oguzhanKomcu/DATA_ACCESS/blob/master/Dapper_BankDb_Project.Intfrastructure/Repositories/Concrete/CustomerRepository.cs)
 
 -- I created the connection with the database with "connection". You can look from here. [GitHub Pages](https://github.com/oguzhanKomcu/DATA_ACCESS/blob/master/Dapper_BankDb_Project.Intfrastructure/Repositories/Abstract/KernelRepository.cs)
 
 --  I created my latest user interface and did my desired actions. You can look from here. [GitHub Pages](https://github.com/oguzhanKomcu/DATA_ACCESS/blob/master/Dapper_BankDb_Project.UserInterface/CustomerCrud.cs)
 
### WORKING BY WRITE A QUERY

Here, I wrote my queries that will run the operation I want directly in Sql. It is really necessary to be very careful while writing the queries here. An error can waste a lot of time. As for the parameters, and the matching values of the parameters in the query must be correct. But for me, Exceptions are pretty self explanatory in Dapper. It's really helpful to find fault easily.

You can look from here. [GitHub Pages](https://github.com/oguzhanKomcu/DATA_ACCESS/blob/master/Dapper_BankDb_Project.Intfrastructure/Repositories/Concrete/AccountRepository.cs)

Here, I have shown my actions in the user interface.

You can look from here. [GitHub Pages](https://github.com/oguzhanKomcu/DATA_ACCESS/blob/master/Dapper_BankDb_Project.UserInterface/AccountCrud.cs)
