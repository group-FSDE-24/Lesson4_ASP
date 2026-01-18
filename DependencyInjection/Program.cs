using DependencyInjection.Services.Abstracts;
using DependencyInjection.Services.Concretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


#region DI


/*
User => request

1. Singleton    => Yalniz 1 instance yaranir arxada, butun userler bir instance-dan istifade edirler
2. Scope        => Her user ucun ayrinca 1 instance yaranir. 
3. Transient    => Her user ucun her defe referance-a muraciet edilende yeni 1 object yaradilir.

*/

// // Umumi istifade edildikde

// builder.Services.AddSingleton<ILog, DatabaseLog>();
// builder.Services.AddScoped<ILog, DatabaseLog>();
// builder.Services.AddTransient<ILog, DatabaseLog>();

// Xususi methoda gore istifade etdikde nece inject etmeliyik

//builder.Services.AddScoped<ILog>(x => new FileLog());
builder.Services.AddScoped<ILog>(x => new CustomSerilog("Hello World"));

#endregion



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
