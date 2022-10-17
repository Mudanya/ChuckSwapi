# ChuckSwapi
### This project entails both front end and backend that abstracts away two downstream APIs; the Chuck Norris API and the Star Wars API.
### The Front end is done using Angular and the backend done using C# .Net Core 6.
A sample hosted project can be accessed at this site 
[ChuckSwapi roject]("http://www.chuckswapi-mudanya.somee.com/").

Experimenting with the development version of the angular app located in subdirectory **/chuck-swapi-spa**.

The project was developed with **Angular version 13x**

To restore modules use
```angular
    npm install
```

To serve the application use
```angular
    ng s -o
```

### For the backend located in subdirectory **/ChuckSwapi**

The DBMS used is MS SQL.

To run the backend in development.
```C#
cd /ChuckSwapi
dotnet build
dotnet tool install --global dotnet-ef
dotnet ef database update
dotnet run
```