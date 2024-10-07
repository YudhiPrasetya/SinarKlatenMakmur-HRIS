using DepartmentAPI.Data;
using DepartmentAPI.Services;
using MassTransit;
using Microservices.DepartmentAPI.Services;
using Microsoft.EntityFrameworkCore;

//if (args.Contains("--RunMigrations")) {
//	var config = new ConfigurationBuilder()
//		.AddJsonFile("appsettings.json")
//		.Build();

//	var optionsBuilder = new DbContextOptionsBuilder<DbContextClass>();
//	optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));

//	await using var DbContext = new DbContextClass(optionsBuilder.Options);
//	await DbContext.Database.MigrateAsync();	
//}

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMassTransit(x => {
	x.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(config => {
		config.Host(new Uri("rabbitmq://localhost"), h => {
			h.Username("guest");
			h.Password("guest");
		});
	}));
});
//builder.Services.AddMassTransitHostedService();

//ConfigurationManager configuration = builder.Configuration;
// Add services to the container.
builder.Services.AddCors(options =>
{
	options.AddPolicy("CORSPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});
builder.Services.AddScoped<IDepartmentService, DepartmentService>(); //added
builder.Services.AddDbContext<DepartmentDbContextClass>();
//builder.Services.AddScoped<IRabbitMqProducer, RabbitMqProducer>();

																 //builder.Services.AddStackExchangeRedisCache(options => { options.Configuration = configuration["RedisCacheUrl"]; });
builder.Services.AddScoped<ICacheService, CacheService>();
//builder.Services.AddJwtAuthentication();
builder.Services.AddControllers();

//builder.Services.AddCustomJwtAuthentication(); //added
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
app.UseCors("CORSPolicy");
app.UseHttpsRedirection();

app.UseAuthentication(); // added
app.UseAuthorization();

app.MapControllers();


//using (var scope = app.Services.CreateScope()) {
//	var db = scope.ServiceProvider.GetRequiredService<DbContextClass>();
//	db.Database.Migrate();
//}
app.Run();
