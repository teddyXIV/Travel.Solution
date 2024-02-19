# TravelAPI

#### By _Teddy Peterschmidt_ and _Chris Ross Davila_   😊

#### This is our pracitce c# and .NET project which builds an API with two versions that allows users to GET,POST, PUT and Delete reviews about various travel destinations around the world.

## Technologies Used

* Git
* C#
* dotnet script(.NET 6.0 CLI)
* .NET
* Swagger
* RestSharp
* Entity Framework Core
* JSON Web Token Authentication
* MySQL Workbench
* VS code

## Description

* A user should be able to GET and POST travels, search travels by country , city, rating, in different page by optionally setting the parameters.
* A user should be able to look up random destinations just for fun.
* A user should be able to use V1 and V2 version of TravelApi.
* In API version v1, only authorized user is able to PUT and DELETE reviews; In API version v2, all users are able to PUT and DELETE reviews.

### Set Up and Run Project

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "TravelApi".
3. Within the production directory "TravelApi", create two new files: `appsettings.json` and `appsettings.Development.json`.
4. Within `appsettings.json`, put in the following code. Make sure to replacing the `uid` and `pwd` values in the MySQL database connection string with your own username and password for MySQL.

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DATA-BASE];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD];"
  }
}
```

5. Within `appsettings.Development.json`, add the following code:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Trace",
      "Microsoft.AspNetCore": "Information",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
}
```

6. Create the database using the migrations in the TravelApi project. Open your shell (e.g., Terminal or GitBash) to the production directory "TravelApi", and run `dotnet ef database update`. 
7. Within the production directory "TravelApi", run `dotnet watch run --launch-profile "TravelApi-Production"` in the command line to start the project in production mode with a watcher. 
8. To optionally further build out this project in development mode, start the project with `dotnet watch run` in the production directory "TravelApi".
9. Use your program of choice to make API calls. In your API calls, use the domain _http://localhost:5000_. Keep reading to learn about all of the available endpoints.

## Testing the API Endpoints

You are welcome to test this API via [Postman](https://www.postman.com/), access the [Swagger UI](https://localhost:5001/swagger/index.html), or [the ASP.NET Core MVC frontend "TravelAPI Client"](https://github.com/travel) create to work with this API. 

If you want to use the TravelAPI Client, an ASP.NET Core MVC application, follow the setup instructions in the README of [this repo](https://github.com/travel). 

### Available Endpoints

```
GET http://localhost:5000/api/{version}/review/
POST http://localhost:5000/api/{version}/reviews/
GET http://localhost:5000/api/{version}/reviews/{id}
PUT http://localhost:5000/api/{version}/reviews/{id}
DELETE http://localhost:5000/api/{version}/reviews/{id}
GET http://localhost:5000/api/{version}/reviews/rando1

```

Note: `{version}` is a version number and it should be replaced with a "v2" or "v1"; `{id}` is a variable and it should be replaced with the id number of the travel you want to GET and POST.

#### Optional Query String Parameters for GET Request

GET requests to `http://localhost:5000/api/reviews/` can optionally include query strings to filter or search animals.

| Parameter   | Type        |  Required    | Description |
| ----------- | ----------- | -----------  | ----------- |
| country     | String      | not required | Returns travel destinations with a matching country value |
| city        | String      | not required | Returns travel destinations with a matching city value |
| filterRating  | Number      | not required | Returns travel destinations that have a rating value that is greater than or equal to the specified filterRating value |
| page  | Number      | not required | Returns travel destinations that in the page |

The following query will return all travel destinations with a country value of "China":

```
GET http://localhost:5000/api/reviews?country=china
```

The following query will return all travel destinations with the city "Beijing":

```
GET http://localhost:5000/api/reviews?city=beijing
```

The following query will return all travel destinations with a raing of 3 or higher:

```
GET http://localhost:5000/api/reviews?rating=3
```

The following query will return all travel destinations in page 2:

```
GET http://localhost:5000/api/reviews?page=2
```

You can include multiple query strings by separating them with an `&`:

```
GET http://localhost:5000/api/reviews?country=china&filterRating=3
```

#### Additional Requirements for POST Request

When making a POST request to `http://localhost:5000/api/reviews/`, you need to include a **body**. Here's an example body in JSON:

```json
{
  "Country": "China",
  "city": "Beijing",
  "rating": 5,
  "review": "Good",
  "userid": 1
}
```

#### Additional Requirements for PUT Request

When making a PUT request to `http://localhost:5000/api/reviews/{id}`, you need to include a **body** that includes the travel's `travelId` property. Here's an example body in JSON:

```json
{
  "ReviewId": 1,
  "Country": "China",
  "city": "Beijing",
  "rating": 5,
  "review": "Good",
  "userid": 1
}
```

And here's the PUT request we would send the previous body to:

```
http://localhost:5000/api/{version}/reviews/1
```

Notice that the value of `travelId` needs to match the id number in the URL. In this example, they are both 10.

## Known Bugs

No bugs 

## License
[MIT](license.txt)
Copyright (c) 2024 Teddy Peterschmidt and Chris Ross Davila