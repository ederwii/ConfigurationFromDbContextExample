# ConfigurationFromDbContextExample

## How to clone and run
1. Clone this repository
2. Navigate to the directory and run via CLI `dotnet run`
3. You can also run it using visual studio
4. Hit /ping controller which will respond with a configuration value from the database

## Where to start
In `Program.cs` line 6, you'll find the registration of the configuration using ef core

```c#
builder.Configuration.AddEFConfiguration(
    opt => opt.UseInMemoryDatabase("InMemoryDb"));
```

## Dev notes
This example is making use of InMemory database. You can easly change this by configuring a SQL Server/PostgreSQL/MySQL provider.