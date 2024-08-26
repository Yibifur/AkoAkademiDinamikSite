using AkoAkademiDinamikSite.BusinessLayer.Abstract;
using AkoAkademiDinamikSite.BusinessLayer.Concrete;
using AkoAkademiDinamikSite.DataAccessLayer.Abstract;
using AkoAkademiDinamikSite.DataAccessLayer.Concrete;
using AkoAkademiDinamikSite.DataAccessLayer.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AkoContext>();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddScoped<IPageDal, EfPageDal>();
builder.Services.AddScoped<IPageService, PageManager>();

builder.Services.AddScoped<IContentDal, EfContentDal>();
builder.Services.AddScoped<IContentService, ContentManager>();



builder.Services.AddScoped<ILayoutDal, EfLayoutDal>();
builder.Services.AddScoped<ILayoutService, LayoutManager>();
builder.Services.AddControllers();
/*builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
    options.JsonSerializerOptions.MaxDepth = 64; // Eðer derinlik problemi yaþýyorsanýz MaxDepth'i artýrabilirsiniz.
});*/

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
