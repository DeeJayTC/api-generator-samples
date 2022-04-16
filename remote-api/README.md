# This sample contains all the code needed for a fully working API
**Based on TCDev API Generator SDK -> [net-dynamic-api](https://github.com/DeeJayTC/net-dynamic-api)**

# How to:
* Clone the repository 
* open in VSCode or Visual Studio
* Run
```csharp
dotnet restore
dotnet run
```

# Infos:
The sample is using an InMemory Database, the API is generated from a remote JSON Schema. 

If you want to use an SQL Database just change AppSettings.json:

```json
    "Database": {
      "DatabaseType": "InMemory"
    },
```
to
```json
    "Database": {
      "DatabaseType": "SQL"
    },
And update the APiGeneratorDatabase connection string to match your DB
```


