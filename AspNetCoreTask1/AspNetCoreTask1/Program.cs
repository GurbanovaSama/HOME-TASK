using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); 
var app = builder.Build();


app.MapDefaultControllerRoute();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index()}/{id?}");

app.MapControllerRoute(
    name: "defaultstudent",
    pattern: "{controller=Student}/{action=Index()}/{id?}");

app.Run();
   
           
  
