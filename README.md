# CatWorx.BadgeMaker

## Description

This app was built for users that need to make badges for their employees. Badges will be generated after the user enters a first and last name, Id number, and photo URL for their employee. This is possible by using the System.Drawing namespace provided by the .NET framework to build the badge and render all of the employee information from the CSV file. Currently badges are being made with "employee" data from the [Random User Generator API](https://randomuser.me/documentation) which is being used to generate ten random employees.


### Usage

To run this app you will need run the following command in the CLI:

```md
dotnet run
```

This will generate 10 employee badges that look like the following:

In order to input custom employees via CLI change line 15 in Program.cs to GetEmployees() instead of GetFromApi().

