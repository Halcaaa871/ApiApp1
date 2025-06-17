using Microsoft.EntityFrameworkCore;
using ApiApp1.Data;



var builder = WebApplication.CreateBuilder(args);

//SQLiteデータベースを使用するように設定
builder.Services.AddDbContext<FishDbContext>(options =>
    options.UseSqlite("Data Source = app.db"));

//各種サービス登録
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowVueApp",
        policy => policy.WithOrigins("http://localhost:5173")
                .AllowAnyHeader()
                .AllowAnyMethod());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowVueApp");

app.MapControllers();

using(var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<FishDbContext>();
    db.Database.EnsureCreated();
    SeedData.Initialize(db);
}


app.Run();

