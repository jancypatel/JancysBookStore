2023-03-09

1433
Started Assignment 2 inclass on the lab computer.
Set up the ASP.NET MVC with core 3.1 (out-of-support)
HTTP enabled, Individual account authentication
Reviewed the Areas folder, Controller, Model, View

1434 - n Startup.cs online 33
removed options for default  identity:
options => options.SignIn.RequireConfirmedAccount = true

1435
Tested App...Ran it good...Tested Links

Action Items:
- Modify the navigation
- Update the copyright... from 'static' to 'dynamic'

1438
Modified the default welcome message tested.
review the route pattern in Startup.cs

1443
Confirmed the repo is build. Now I want to test it. 

1445
Create README.md file in GitHub and pull it in Visual Studio.

1447
Edited bootstrape_bk.css for backup purpose..
selected theme from bootswatch 
added botstrap.min.css to CSS folder

1450
Added code to the bootstrap/css/bootstrap.min.css...
then try to run the app..

2010
change the nav class from navbar-light to navbar-dark and bg-white to bg-primary in _Layout.cshtml in views folder.

2013
Remove text-dark from line 23 in _Layout.cshtml.
Then added aditional properties to the footer class.
Remove text-dark in _LoginPartial.cshtml file and then run the app. 

2015
Added additional stylesheets and scripts from the css_js.txt file in _Layout.cshtml file. 



2023-03-10
1510
Added dropdown to the navbar..
Change the dropdown name to Content Management.

1521
Added 3 new .Net core class library projects to the application.
1- JancysBooks.DataAccess
2- JancysBooks.Models
3- JancysBooks.Utility
Then copied the Data folder and pasted into the JancysBooks.DataAccess project and also deleted from the original source.

2023-03-29
2000
Installed Microsoft.Entity Framework Core .Relational and Core.SQL Server Packeges

2004
Deleted the Migrations folder

2025
Installed Entity FrameWork Core NuGet packages in DataAcesss

2030
Modified the namespace to reflect the project

2035
Deleted the default Class1.cs file from all projects

2045
Build the Project and found the three errors

2050
Moved Models folder to JancysBook.Models And deleted the original.

2205
Added project reference in .DataAccess and .Models project.
Rename Models to ViewModels and changed the namespace to Models.ViewModels

2210
Trying to run the application to review errors. 
Chnaged the reference in Error.cshtml and tested the application and all the errors are solved.

2224
Added a SD.cs class to the .Utilities project.
Changed the class to public static.

2226
Added a projet reference to the main project and also to the .DataAccess project.

2227
Added a area named Customer into Areas.
Also chnaged the routes in Startup.cs file. 

2233
Moved HomeController.cs to Customer>Controllers and also moved Home folder to Views folder. 
Deleted the Data and Models folder. 

2235
Run the application but it only shows Jancys Book Store only. 

2238
Copied _ViewStart.cshtml and _ViewImports.cshtml file to Customer area. 

2240
Modified the path in _ViewStart.cshtml file and run the application. It runs without getting an error. 

2242
Added area named Admin into Areas. 
Copied the View files and deleted the Data, Models and Controller. 

2323-03-30
Part 2
1815
buid the project and got 4 succeeded.
Changed the name in appsetting.json file.

1835
Added the wrong default Project and got error.

1840
Changed to the correct default project.
Use Nuget package manager console to add migration.
file name:20230330223942_AddDefaultidentityMigration.cs

1850
After that in the PM console updated the database by using update-database.
Reviewed the updated in SQL Server object Explorer then run the application and it worked without error.

1900
Added new class file Category.cs into .Models
Change the project to .DataAcesss and written command again in PM console and it work

1910
Updated the ApplicationDbContext.cs file

1915
Run again the migration command add-migration Addcategory and got error
after that solved the duplication error and also written the migration command of update-database
and got category table in SQL SOE

1920
Created and modified the IRepository

1923
Copied and pasted the Repository.cs file from Assignment 2.

1927
changed the CategoryRepository.cs also modified it.

1929
implemented the interface to update in CategoryRepository.cs
after that build the app and it was error free.
then commited the code and push to github


1940
Created SP_Call.cs file with the Repository folder.
Implement the SP_Call.cs file with the necessary commands.

1950
Added a IUnitOfWork.cs in the IRepository folder and updatade the code.

2000
Added a UnitOfWork.cs in the Repository folder and updatade the code.










