# Credentials

The Umbraco back office credentials are admin@admin.admin / adminadmin.

# Workaround for "Could not find roslyn/csc.exe"

Try rebuilding the solution a few times.

If that doesn't work, see this: https://stackoverflow.com/a/34391473/2052963

It says to run this command in the Package Manager Console (in this case, with the "Website" project selected as the default project):

```
Update-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform -r
```