

Create Procedure InsertCustomer(@FirstName nchar(50)
           ,@LastName nchar(50)
           ,@Id_Card_No nvarchar(11)
           ,@Mobile_No nvarchar(11)
           ,@Home_Address nvarchar(max)
           ,@Business_Address nvarchar(max)
           ,@City nvarchar(max)
           ,@Email nvarchar(max))
as
begin
INSERT INTO [dbo].[Customers]
           ([FirstName]
           ,[LastName]
           ,[Id_Card_No]
           ,[Mobile_No]
           ,[Home_Address]
           ,[Business_Address]
           ,[City]
           ,[Email])
     VALUES (@FirstName,@LastName,@Id_Card_No,@Mobile_No,@Home_Address,@Business_Address,@City,@Email)
          
end







create proc GetAllCustomers
 as begin 
     select  * from Customers end


create proc DeleteCustomer(@Id int)
 as begin 
     
	 delete from Customers where Id = @Id
	 
	 
	 end







create proc GetByIdCard(@Idcardno nvarchar(11))
 as begin 
     select  * from Customers where Id_Card_No = @Idcardno end






create proc UpdateCustomer (@FirstName nchar(50)
           ,@LastName nchar(50)
           ,@Id_Card_No nvarchar(11)
           ,@Mobile_No nvarchar(11)
           ,@Home_Address nvarchar(max)
           ,@Business_Address nvarchar(max)
           ,@City nvarchar(max)
           ,@Email nvarchar(max))
 as begin 

     Update Customers set FirstName = @FirstName,
	                      LastName = @LastName,
						   Id_Card_No = @Id_Card_No ,
						  Mobile_No = @Mobile_No,
						  Home_Address = @Home_Address,
						  Business_Address = @Business_Address,
						  City = @City,
						  Email = @Email
	                   where Id_Card_No = @Id_Card_No
	 
	 
	 
	 end

