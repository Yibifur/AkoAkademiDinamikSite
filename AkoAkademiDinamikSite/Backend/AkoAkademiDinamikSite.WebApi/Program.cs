using AkoAkademiDinamikSite.BusinessLayer.Abstract;
using AkoAkademiDinamikSite.BusinessLayer.Concrete;
using AkoAkademiDinamikSite.DataAccessLayer.Abstract;
using AkoAkademiDinamikSite.DataAccessLayer.Concrete;
using AkoAkademiDinamikSite.DataAccessLayer.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

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

builder.Services.AddScoped<IFormDal, EfFormDal>();
builder.Services.AddScoped<IFormService, FormManager>();

builder.Services.AddScoped<IFormElementDal, EfFormElementDal>();
builder.Services.AddScoped<IFormElementService, FormElementManager>();

builder.Services.AddScoped<IFormOptionDal, EfFormOptionDal>();
builder.Services.AddScoped<IFormOptionService, FormOptionManager>();

builder.Services.AddScoped<IFormAnswerDal, EfFormAnswerDal>();
builder.Services.AddScoped<IFormAnswerService, FormAnswerManager>();



builder.Services.AddControllers()
    .AddNewtonsoftJson(options =>
    {
        options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore; // Döngüsel referansları yoksay
        options.SerializerSettings.Formatting = Formatting.Indented; // Daha okunabilir JSON çıktısı
    });

/*builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
    options.JsonSerializerOptions.MaxDepth = 64; // Eğer derinlik problemi yaşıyorsanız MaxDepth'i artırabilirsiniz.
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
