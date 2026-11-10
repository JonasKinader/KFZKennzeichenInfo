# KFZKennzeichenInfo

[🇬🇧 English](#english) | [🇩🇪 Deutsch](#deutsch)

## English

A REST API that provides information about German licence plate codes: region, district, federal state and a link to the coat of arms.

Built during my retraining as an IT specialist for application development, 10/2025. A matching desktop client is here: [KennzeichenAPIClient](https://github.com/JonasKinader/KennzeichenAPIClient)

### Features

- Full CRUD API: list, get, create, update and delete entries
- Data stored in SQL Server with Entity Framework Core
- Interactive API documentation with Swagger UI

### Endpoints

| Method | Route | Description |
|---|---|---|
| GET | `/api/KennzeichenInfos` | Get all entries |
| GET | `/api/KennzeichenInfos/{id}` | Get one entry |
| POST | `/api/KennzeichenInfos` | Create an entry |
| PUT | `/api/KennzeichenInfos/{id}` | Update an entry |
| DELETE | `/api/KennzeichenInfos/{id}` | Delete an entry |

### Tech stack

- C# / .NET 9, ASP.NET Core Web API
- Entity Framework Core with SQL Server (LocalDB)
- OpenAPI / Swagger UI

### Getting started

Requirements: .NET 9 SDK and SQL Server LocalDB (included with Visual Studio).

1. Clone the repository and open the folder
2. Create the database
   ```
   dotnet ef database update
   ```
3. Run the API
   ```
   dotnet run
   ```
4. Open Swagger UI in the browser: http://localhost:5294/swagger

### What I learned

- Designing and building a REST API with ASP.NET Core
- Using HTTP methods and status codes correctly
- Connecting a database with EF Core and migrations
- Documenting and testing an API with Swagger

---

## Deutsch

Eine REST-API, die Informationen zu deutschen KFZ-Kennzeichen liefert: Ort, Kreis, Bundesland und ein Link zum Wappen.

Entstanden während meiner Umschulung zum Fachinformatiker für Anwendungsentwicklung (10/2025). Den passenden Desktop-Client gibt es hier: [KennzeichenAPIClient](https://github.com/JonasKinader/KennzeichenAPIClient)

### Funktionen

- Vollständige CRUD-API: Einträge auflisten, abrufen, anlegen, ändern und löschen
- Speicherung in SQL Server mit Entity Framework Core
- Interaktive API-Dokumentation mit Swagger UI

### Endpunkte

| Methode | Route | Beschreibung |
|---|---|---|
| GET | `/api/KennzeichenInfos` | Alle Einträge abrufen |
| GET | `/api/KennzeichenInfos/{id}` | Einen Eintrag abrufen |
| POST | `/api/KennzeichenInfos` | Eintrag anlegen |
| PUT | `/api/KennzeichenInfos/{id}` | Eintrag ändern |
| DELETE | `/api/KennzeichenInfos/{id}` | Eintrag löschen |

### Technik

- C# / .NET 9, ASP.NET Core Web API
- Entity Framework Core mit SQL Server (LocalDB)
- OpenAPI / Swagger UI

### Projekt starten

Voraussetzungen: .NET 9 SDK und SQL Server LocalDB (ist bei Visual Studio dabei).

1. Repository klonen und Ordner öffnen
2. Datenbank anlegen
   ```
   dotnet ef database update
   ```
3. API starten
   ```
   dotnet run
   ```
4. Swagger UI im Browser öffnen: http://localhost:5294/swagger

### Was ich dabei gelernt habe

- Eine REST-API mit ASP.NET Core planen und umsetzen
- HTTP-Methoden und Statuscodes richtig einsetzen
- Eine Datenbank mit EF Core und Migrationen anbinden
- Eine API mit Swagger dokumentieren und testen
