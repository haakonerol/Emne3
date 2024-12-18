
using WebApplication1;
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
app.UseHttpsRedirection();

// app.MapGet("/weatherforecast", () =>
// {
//     return new Person[]
//     {
//         new Person{Name="Per", BirthYear=1979},
//         new Person{Name="Pål", BirthYear=1981},
//     };
// });
app.MapGet("/people", DataManager.GetPeople);

app.MapGet("/numbers", () =>
{
    return new[] { 1, 2, 3, 4, 5 };
});
app.Run();