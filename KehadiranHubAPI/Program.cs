using KehadiranHubAPI.Data;
using KehadiranHubAPI.Hub;
using KehadiranHubAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSignalR();

builder.Services.AddHostedService<KehadiranNotifier>();
builder.Services.AddHostedService<Top10KehadiranNotifier>();
builder.Services.AddHostedService<Top10TerlambatNotifier>();
builder.Services.AddHostedService<Top5KehadiranNotifier>();
builder.Services.AddHostedService<Top5TerlambatNotifier>();
builder.Services.AddHostedService<CountGenderEmployeeNotifier>();

builder.Services.AddCors(options => {
   options.AddPolicy("CORSPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

builder.Services.AddDbContext<KehadiranHubDbContext>();

builder.Services.AddScoped<IKehadiranService, KehadiranService>();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors("CORSPolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHub<NotifKehadiranHub>("/kehadiranHub");
app.MapHub<NotifTop10KehadiranHub>("/top10kehadiran");
app.MapHub<NotifTop5KehadiranHub>("/top5kehadiran");
app.MapHub<NotifTop10Terlambat>("/top10terlambat");
app.MapHub<NotifTop5TerlambatHub>("/top5terlambat");
app.MapHub<NotifCountGenderEmployeeHub>("/countEmpByGender");
app.Run();
Console.ReadKey();