# ParkApi

API created to view the national parks int the Pacific NorthWest. 

## Authors

Hailey Gaylor, Haileygaylor@gmail.com

## Use
No API key necessary. Application follows CRUD functionaliy allowing a create, read, update and delete functionality in the controller. Data is being seeding though the context page to the database to then return the information to the user.

## Set-Up

- Navigate to the to the desktop in your terminal and run $git clone https://github.com/Hgaylor0220/ParkApi.Solution.git
- Navigate your way into the folder ParkApi and Run the command $dotnet restore.
- Run the command $ dotnet ef migrations add NewDB. This will make file message of your new database.
- run the command $dotnet ef database update. This will add your new updated Database to run the API Call
- run the command $dotnet run watch To start the application 
- Open Postman and add http://localhost:5000/api/Park to view all parks. Follow controller instructions for more search options


## Specs

| Scenario | When given that | Result |
|-|-|-|
| User can search a park by coordinates | longitude, latitude percisce| return the national park of those coordinates |
| User can search a park by name | lava  | returns search that contains that name|
| user can search by restrictions | Forest pass |  shows all parks with forest pass acceptance |
| user can search for park by attraction| waterfalls| returns all parks with waterfalls |

## Known bugs
Db is not respoding to run build.

## Technologies

C#, EntityFramework, .NET, MySQL Workbench, VS Code, .cshtml, ASP.NET, PostMan, API, NSwag documentation;

## License

Open source, 2019 (MIT)