# Summer2022-CPW211-EntityFrameworkQueries

## Getting Started
- Visual Studio 2022
- .NET 6
- [AP database](create_ap.sql) installed


You may need to change the DB connection string located in the APContext class.
By default it points to mssqllocaldb. If your AP script is not installed on mssqllocaldb, update the string.
```csharp
optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AP");
```
