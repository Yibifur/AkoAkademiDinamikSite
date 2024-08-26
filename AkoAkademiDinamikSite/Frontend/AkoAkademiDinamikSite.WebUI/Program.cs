using AkoAkademiDinamikSite.BusinessLayer.Abstract;
using AkoAkademiDinamikSite.BusinessLayer.Concrete;
using AkoAkademiDinamikSite.DataAccessLayer.Abstract;
using AkoAkademiDinamikSite.DataAccessLayer.Concrete;
using AkoAkademiDinamikSite.DataAccessLayer.EntityFramework;
using AkoAkademiDinamikSite.EntityLayer.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddDbContext<AkoContext>();
builder.Services.AddScoped<ILayoutDal, EfLayoutDal>();
builder.Services.AddScoped<ILayoutService, LayoutManager>();
//builder.Services.AddScoped<ILayoutService,LayoutManager>();
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
