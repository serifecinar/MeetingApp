var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();//mvc şablonu projeye tanıtılmış oluyor - servis ekledik mvc için


var app = builder.Build();

app.UseStaticFiles();//wwwroot altındaki dosyalar erişime açılır bu kod ile 
app.UseRouting();

//proje şablonları--
//mvc
//rest api
//razor pages


//controller/action/id?
//app.MapDefaultControllerRoute();

app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Home}/{action=Index}/{id?}"
);
app.Run();
