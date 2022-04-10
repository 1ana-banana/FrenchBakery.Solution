<h1 align = "center">
  <b> Pierre's Parisian Bakery of Sweet and Savory Treats </b>
</h1>

<p align = "center">
  Website with users able to crate account, assign user roles, create ,edit and delete treats. 
</p>

<p align = "center">
  By Anastasia Han
</p>

--------------------

## Description

Website with users able to crate account, assign user roles, create ,edit and delete treats. 

--------------------

## Technologies Used

This project uses the following technologies:

- .NET Core
- ASP .NET MVC
- ASP .NET Core Razor Pages
- MySQL
- MySQL Workbench
- Entity Framework Core

-------------------

## Known Bugs

-------------------

## Setup & Requirements

### Necessary Specifications

#### To run this project locally you will need:

- **ASP .NET Core :** You can check if you have .NET Core by running `dotnet --version` in the command line. If you do not have .NET Core please find more information and download [here](https://dotnet.microsoft.com/download/dotnet-core)
- **MySQL :**  You can download MySQL [here](https://dev.mysql.com/downloads/file/?id=484914) and MySQL Workbench [here](https://dev.mysql.com/downloads/file/?id=484391)
- **Prefered Code Editor**


### Clone or Download

#### To Download:

Go to my GitHub repository here, [https://github.com/1ana-banana/ParisBakery.Solution](https://github.com/1ana-banana/ParisBakery.Solution), and click on the green 'Code' button to clone the repository, Open with GitHub Desktop OR Download the ZIP file

#### To clone (my prefered method):

1. Push the green 'Clone' button and copy the URL.
2. Open Terminal or GitBash and input the command: `git clone https://github.com/1ana-banana/ParisBakery.Solution`
3. To view the code, open the copied directory with Visual Studio Code or your preferred text editor by inputing the command `code .` in your terminal.

### Database Setup Options

#### AppSettings:

- After you have the project on your computer you will need to create a file in the root directory of the project called "appsettings.json". 
- Add the following snippet of code to the appsettings.json file:

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=anastasia_han_paris_bakery;uid=root;pwd=YOUR-PASSWORD-HERE;"
    }
}

#### Setting up User Roles and granting "Admin" permissions

1. From the splash page navigate to "Register" and fill out the form.
2. Click "Log in" and fill out the form.
3. Click "Manager User Roles" and then click "Create Role" and name the new role *"Admin"*.
4. Next to add your account to the "Admin" role, click "Edit" and then click "Add or Remove Users".
5. Check the checkbox next to your user email and then click "Update"
6. To have to the role update your permission Logout and then Log back into your account. You should now see "Manage User Roles" and "ADMIN" in the navbar. 

*To have full access to the web application you will need to add the User Role "Admin" to your account.

--------------------------

## Support and contact details

If you run into any problems or have any questions please contact me via [email](mailto:anastasia.han@yahoo.com).

---------------------------

## 📘 License

MIT License

Copyright (c) 2022 Anastasia Han 
