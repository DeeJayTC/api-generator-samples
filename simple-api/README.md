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
Your API Spec is available under https://localhost:xxxx/swagger

# Infos:
The sample is using an SQL Database, the API is generated from a remote JSON Schema. 

Just change AppSettings.json:

```json
    "Database": {
      "DatabaseType": "SQL",
      "Connection": "YourSQLServerConnectionString"
    },
```


