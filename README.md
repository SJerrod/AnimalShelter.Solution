# _Animal Shelter_

<p align="center">
    <a href="https://github.com/SJerrod">
        <img style="border-radius: 100%; height: 250px; width: auto" src="https://avatars1.githubusercontent.com/u/65928050?s=460&u=eae77ab164dde31ddbe95627ad67c5d7072ca033&v=4">
    </a>
</p>

<p align="center">
  <small>Last Updated: January 22th, 2021</small>
</p>

#### _Building an Api and using Search function_ 

# 🧑‍💻 Contributers

| Name | GitHub Profile |
|------|----------------|
|[Jerrod Styrk](https://www.linkedin.com/in/styrk-jerrodm/)|[SJerrod](https://github.com/SJerrod)|

# 📖 Description

This application will allow you to enter Either a Dog or cat into a database, you can also alter current records i.e Edit/ Create/ Delete new or old dogs or cats.

# 💾 Installation Requirements

Software Requirements
* An internet browser of your choice; I prefer Chrome
* A code editor; I prefer VSCode
* .NET Core
* MySQL
* MySQL Workbench

# 🖥️ Opening the Project on your Local System

Open by Downloading or Cloning
- [Click to view Github repository](https://github.com/SJerrod/AnimalShelter.Solution.git) Or simply paste the following url into your prefered browser https://github.com/SJerrod/AnimalShelter.Solution.git
- To Clone repository simply click the green Code button and copy the url.
- Using a prefered terminal use the command `git clone paste-url-here` in which ever directory you wish.
- Open the newly cloned repo with your text editor.
- In the terminal run command `cd AnimalShelterApi`
- In the terminal run command `dotnet run` This will start the API
- In the terminal run command `cd ..`
- In the terminal run command `AnimalShelterClient`
- In the terminal run command `dotnet restore`
- In the terminal run command `dotnet build`
- In the terminal run command `dotnet run` This will start the application.

AppSettings
* This project requires an AppSettings file. If one does not exsist Create your `appsettings.json` file in the main `AnimalShelterApi` directory.
* Format your `appsettings.json` file as follows including your unique password that was created at MySqlWorkbench installation:
```
{
  "ConnectionStrings":{
      "DefaultConnection": "Server=localhost;Port=3306;database=travel;uid=root;pwd=<YourPassword>;"
  }
}
```

* Update the Server, Port, and User ID as needed.

Import Database using Entity Framework Core
* Type `dotnet ef database update` into the terminal to create your database tables.

# 🛰️ API Documentation
Explore the API endpoints in Postman or a browser.

#### Example Query
```
https://localhost:5004/api/dogs/?breed=terrior&gender=male
```

To use default, _don't include_ `breed` or `gender`.

..........................................................................................

### Endpoints
Base URL: `https://localhost:5004`

#### HTTP Request Structure
```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```

#### Example Query
```
https://localhost:5004/api/dogs/6
```

#### Sample JSON Response
```
{
    "Id": 6,
    "DogName": "Terry",
    "DogGender": "Male",
    "DogAge": 4,
    "DogBreed": "Terrior",
    "DogTemperment": "Terrible"
}
```

..........................................................................................

### Dogs
Access information on Dogs currently housed at the shelter.

#### HTTP Request
```
GET /api/dogs
POST /api/dogs
GET /api/dogs/{id}
PUT /api/dogs/{id}
DELETE /api/dogs/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| gender | string | none | false | Return matches in gender.
| age | int | none | false | Return matches in age. |
| breed | string | none | false | Return matches in breed |

#### Example Query
```
https://localhost:5004/api/dogs/?breed=boxer&gender=female
```

#### Sample JSON Response
```
{
    "Id": 3,
    "DogName": "Moxer",
    "DogGender": "Female",
    "DogAge": 2,
    "DogBreed": "Boxer",
    "DogTemperment": "Rockstar"
}
```

..........................................................................................

### Cats
Access information on Cats currently housed at the shelter.

#### HTTP Request
```
GET /api/cats
POST /api/cats
GET /api/cats/{id}
PUT /api/cats/{id}
DELETE /api/cats/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| gender | string | none | false | Return matches in gender.
| age | int | none | false | Return matches in age. |
| breed | string | none | false | Return matches in breed |

#### Example Query
```
https://localhost:5004/api/cats/?breed=mainecoon&age=6
```

#### Sample JSON Response
```
{
    "Id": 34,
    "CatName": "Boon",
    "CatGender": "Male",
    "CatAge": 6,
    "CatBreed": "Mainecoon",
    "CatTemperment": "Lampoon"
}
```
### Referenced Material for Swagger/Swashbuckle

* [Microsoft Docs: Swagger Overview](https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-5.0)
* [Microsoft Docs: Get Started with Swashbuckle](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-5.0&tabs=visual-studio)
* [GitHub Swashbuckle.AspNetCore README.md](https://github.com/domaindrivendev/Swashbuckle.AspNetCore/blob/master/README.md)

### Using SwaggerUI / Note

Launch the project from the `AnimalShelterApi` project directory by typing `dotnet run` into the terminal. Input `http://localhost:5000/swagger` into postman to view Swashbuckle SwaggerUI. As Ive seen Swagger is a great way to generate 


# 🦠 Bugs / Issues

* None currently to note

* While Swagger seems to be getting some results in postman it doesnt appear to show up in the browser.

# ☎️ Support / Contact Details

* Please feel free to reach out to <jstyrk@citadel.edu>

# ⚙️ Technologies Used

<details>
  <summary>Expand Tech/tools</summary>

* [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [Bootstrap Components](https://getbootstrap.com/docs/3.3/components/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [Entity Framework Core 2.2.0](https://docs.microsoft.com/en-us/ef/core/)
* [MySQL 8.0.20 for Linux](https://dev.mysql.com/)
* [Postman](postman.com)
* [Swagger - NSwag 13.3.0](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-nswag?view=aspnetcore-3.1&tabs=visual-studio)

</details>

# ⚖️ License & Copyright

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2020 **_Jerrod Styrk_**