using ApplicationLayer;
using InterfaceAdapters.Data;
using InterfaceAdapters.Presenters;
using InterfaceAdapters.Repositories;

var builder = WebApplication.CreateBuilder(args);

var mongoSettings = new MongoDbSettings
{
    ConnectionString = builder.Configuration.GetConnectionString("MongoConnection"),
    DatabaseName = builder.Configuration["MongoSettings:DatabaseName"]
};

builder.Services.AddSingleton(mongoSettings);
builder.Services.AddSingleton<MongoDbContext>();

// Application
builder.Services.AddScoped<ILogInRepository, LogInRepository>();
builder.Services.AddScoped<ILogInPresenter, LogInPresenter>();
builder.Services.AddScoped<PostLogInUseCase>();
builder.Services.AddScoped<GetLogInsUseCase>();
builder.Services.AddScoped<LogInPresenter>();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
