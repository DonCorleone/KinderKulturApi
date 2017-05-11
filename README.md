# Welcome to Kinderkultur Web API

This API implements 

1. GET methods:  
_GET /api/Person_  
_GET /api/Person/{id}_  

2. POST methods:  
_POST /api/Person_

    {
        "name"			: "aName",
        "vorname"		: "aPrename",
        "eMail"			: "aMail@adress.com"
    }


http://localhost:5000/api/Person/

inspired by:

https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-vsc  
https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet  
https://docs.microsoft.com/en-us/ef/core/get-started/netcore/new-db-sqlite

    dotnet ef migrations add InitialCreate  
    dotnet ef database update  


https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql/blob/master/README.md#getting-started  
https://mariadb.com/kb/en/mariadb/starting-and-stopping-mariadb-automatically/  

local development:  
cd /Users/dev/Documents/kinderkultur/_webApi/kinderkultur

    dotnet restore  
    dotnet build  
    dotnet run  

http://localhost:5000/api/Person/  

https://de.wikipedia.org/wiki/Markdown  