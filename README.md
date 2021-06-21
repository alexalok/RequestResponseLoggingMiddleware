![Nuget](https://img.shields.io/nuget/v/AspNetCore.RequestResponseLoggingMiddleware)

# About

This middleware allows for logging of requests and responses in ASP.NET Core applications.

# Usage

## Install NuGet package

`Install-Package AspNetCore.RequestResponseLoggingMiddleware`

## Use middleware in Startup.cs:

```c#
 app.UseRequestResponseLogging(ctx =>
 {
     var path = ctx.Request.Path;
     return path.StartsWithSegments("/needs-to-be-logged", StringComparison.InvariantCultureIgnoreCase);
 });

app.UseRouting();
```
Note that `app.UseRequestResponseLogging()` should be called as early as possible.
