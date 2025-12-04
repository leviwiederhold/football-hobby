> Note: I developed this project on macOS, which does not support SQL Server LocalDB.
> For development I use SQLite (configured in appsettings.Development.json),
> but appsettings.json contains the required LocalDB connection string and the
> DbContext is configured to use SQL Server when run on Windows.
