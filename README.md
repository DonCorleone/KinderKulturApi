# Welcome to Kinderkultur Web API

This API implements 

__GET methods:__  
_GET /api/Person_  
_GET /api/Person/{id}_  

__POST methods:__   
_POST /api/Person_

    {  
        "name" : "aName",  
        "vorname" : "aPrename",  
        "eMail" : "aMail@adress.com"  
    }  


__inspired by:__

https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-vsc  
https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet  
https://docs.microsoft.com/en-us/ef/core/get-started/netcore/new-db-sqlite

    dotnet ef migrations add InitialCreate  
    dotnet ef database update  


https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql/blob/master/README.md#getting-started  
https://mariadb.com/kb/en/mariadb/starting-and-stopping-mariadb-automatically/  

local development:  
    _cd /Users/dev/Documents/kinderkultur/\_webApi/kinderkultur_

    dotnet restore  
    dotnet build  
    dotnet run  

http://localhost:5000/api/Person/  

https://de.wikipedia.org/wiki/Markdown  

Client generation:
https://github.com/aspnet/JavaScriptServices
