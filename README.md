# Project 5
## Getting Started
- [Fork this repo](https://github.com/sorrymint/CIS169Project5Starter)
- Clone down to local computer
## Running the project
- Run the program and in the web browser manually change the URL to `localhost:9999/courses`
- Test out CRUD

## Where to look for help
- [Create a Razor Pages web app with ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/?view=aspnetcore-7.0)
- [Create a web UI with ASP.NET Core](https://learn.microsoft.com/en-us/training/modules/create-razor-pages-aspnet-core/)
## Tasks to complete
1. [Add a Seeding Script](#seeding)
2. [Update the Model](#update-the-model)
3. [Fix links](#fix-links) 
4. [Add EndTime](#-add-endtime-to-project)


### Seeding
- For a example look back at our pizza project or [this](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/sql?view=aspnetcore-7.0&tabs=visual-studio#seed-the-database)
- Add at least 5 courses
- Make sure to test the script by deleting all the courses
- You can delete the courses by using DB tool or using Web UI

### Update the Model
- Add Display names to any field with two words 
  - Ex `CourseName` should become `Course Name` in the views
- To change the display name use a [[Display] attribute](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayattribute?view=net-7.0). 

### Fix links
- Update the Nav bar so you can navigate to the CRUD of courses.
IMAGE OF LINK GOES HERE

### Add EndTime to project
- Add `EndTime` property to the `Course.cs` model
- Added `EndTime` to all the views Creat, Delete, Details 
  - In the `index` make sure you display the `EndTime`
- Do a migration to update the database
- Update seeding script to include new field

#### Commands for migration 
- To be done in NuGet or using [Plugin](https://plugins.jetbrains.com/plugin/18147-entity-framework-core-ui)
```csharp 
Add-Migration EndTime
Update-Database
```







 