# Temporary script: run EF Core migration while allowing NuGet warnings to be non-fatal
# Usage: From repository root in PowerShell: .\scripts\Add-Migration-AllowWarnings.ps1

# Allow warnings / non-terminating errors so Add-Migration doesn't stop on NU warnings
$ErrorActionPreference = 'Continue'

# Run the migration command (adjust project paths if needed)
# This uses dotnet-ef; ensure the EF tools are installed and available in PATH or use the Package Manager Console equivalent.
dotnet ef migrations add InitialDataBase --project .\SportsLeague.DataAccess\SportsLeague.DataAccess.csproj --startup-project .\SportsLeague.API\SportsLeague.API.csproj

# Reset preference to default (optional)
$ErrorActionPreference = 'Stop'
