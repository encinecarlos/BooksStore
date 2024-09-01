var builder = DistributedApplication.CreateBuilder(args);

var mongodb = builder.AddMongoDB("database", 27017);
var database = mongodb.AddDatabase("bookstore"); 

builder.AddProject<Projects.BookStore_Api>("bookstore-api")
    .WithReference(database);

builder.Build().Run();
