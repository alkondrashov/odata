# OData

## Commands

```bash
dotnet new webapi -o odata
```

```bash
dotnet add package Microsoft.EntityFrameworkCore.InMemory
```

```bash
dotnet add package Microsoft.AspNetCore.Odata
```

`https://localhost:7005/WeatherForecast`

`https://localhost:7005/odata`
`https://localhost:7005/odata/Cars`
`https://localhost:7005/odata/Cars(2)`
`https://localhost:7005/odata/Cars?$filter=Price le 50`

```c#
IEdmModel GetEdmModel()
{
    var builder = new ODataConventionModelBuilder();
    builder.EntitySet<Car>("Cars");
    return builder.GetEdmModel();
}
```

```c#
builder.Services.AddDbContext<ODataContext>(opt => opt.UseInMemoryDatabase("Cars"));
```

```c#
builder.Services.AddControllers().AddOData(opt => opt.AddRouteComponents("odata", GetEdmModel()));
```

```c#
public IActionResult Get()
{
    return Ok(_context.Cars);
}
```

```c#
[EnableQuery]
```

```c#
[EnableQuery]
public IActionResult Get(int key)
{
    return Ok(_context.Cars.FirstOrDefault(c => c.Id == key));
}
```

```c#
builder.Services.AddControllers().AddOData(opt => opt.AddRouteComponents("odata", GetEdmModel()).Filter().Select());
```

## Resources

1. <https://docs.microsoft.com/en-us/aspnet/web-api/overview/odata-support-in-aspnet-web-api/odata-v4/create-an-odata-v4-endpoint>
2. <https://devblogs.microsoft.com/odata/asp-net-core-odata-now-available/>
3. <https://devblogs.microsoft.com/odata/asp-net-odata-8-0-preview-for-net-5/>
4. <https://referbruv.com/blog/posts/working-with-odata-integrating-an-existing-aspnet-core-3x-api>
