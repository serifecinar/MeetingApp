var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();//mvc şablonu projeye tanıtılmış oluyor 

var app = builder.Build();

//proje şablonları--
//mvc
//rest api
//razor pages

app.MapGet("/", () => "Hello World!");
app.MapGet("/abc", () => "deneme");

app.Run();
