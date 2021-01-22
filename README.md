# _Animal Shelter_

<p align="center">
    <a href="https://github.com/SJerrod">
        <img style="border-radius: 100%; height: 50px; width: auto" src="https://avatars1.githubusercontent.com/u/65928050?s=460&u=eae77ab164dde31ddbe95627ad67c5d7072ca033&v=4">
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

# ℹ️ Description

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


# 🪲 Bugs / Issues

* None currently to note

# ☎️ Support / Contact Details

* Please feel free to reach out to <jstyrk@citadel.edu>

# ⚙️ Technologies Used

<details>
  <summary>Expand Tech/tools</summary>

* [Bootstrap Components](https://getbootstrap.com/docs/3.3/components/)
* C#
* Razor
* Entity Framework Core
* MySql
* MySql Workbench

</details>

# ©️ License & Copyright

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2020 **_Jerrod Styrk_**