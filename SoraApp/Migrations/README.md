## Migrations

1. Create a migration with

```powershell
dotnet ef migrations add InitialCreate
```

2. Apply the migration with
```powershell
dotnet ef database update --connection "Server=localhost;Database=sora_csharp;Uid=root;Pwd=;"
```

<!-- TODO: Update to use a config inside the app -->
