//using JwtTokenAuthentication;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using UserAPI.Data;
using UserAPI.Services;
//using Microsoft.Data.SqlClient;
//using Microsoft.SqlServer.Management.Common;
//using SMO = Microsoft.SqlServer.Management.Smo;
//using Microsoft.SqlServer.Management.Smo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddDbContext<UserDbContextClass>();
builder.Services.AddControllers();
//builder.Services.AddJwtAuthentication();
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

//using (var scope = app.Services.CreateScope()) {
//   var db = scope.ServiceProvider.GetRequiredService<UserDbContextClass>();
//   db.Database.Migrate();
//}

//ExecuteSQLScript executeSQLScript = new();
//executeSQLScript.ExecuteScript();

app.Run();

//public class ExecuteSQLScript {
//   public void ExecuteScript() {
//      var fileName = @"D:\SKM\SinarKlatenMakmur\UserAPI\Data\Users.sql";
//      var connectionString = "Server = localhost\\SQLEXPRESS; Database = UserDB; Trusted_Connection = true;";
//      var databaseName = "UserDB";
//      var schemaName = "dbo";

//      if (File.Exists(fileName))
//         File.Delete(fileName);

//      try {
//         var server = new SMO.Server(new ServerConnection(new SqlConnection(connectionString)));
//         var options = new SMO.ScriptingOptions();
//         var databases = server.Databases[databaseName];

//         options.FileName = fileName;
//         options.EnforceScriptingOptions = true;
//         options.WithDependencies = true;
//         options.IncludeHeaders = true;
//         options.ScriptDrops = false;
//         options.AppendToFile = true;
//         options.ScriptSchema = true;
//         options.ScriptData = true;
//         options.Indexes = true;

//         var tableEnum = databases.Tables.Cast<SMO.Table>().Where(i => i.Schema == schemaName);
//         var viewEnum = databases.Views.Cast<SMO.View>().Where(i => i.Schema == schemaName);
//         var procedureEnum = databases.StoredProcedures.Cast<SMO.StoredProcedure>().Where(i => i.Schema == schemaName);

//         Console.WriteLine("SQL Script Generator");

//         Console.WriteLine("\nTable Scripts:");
//         foreach (SMO.Table table in tableEnum) {
//            databases.Tables[table.Name, schemaName].EnumScript(options);
//            Console.WriteLine(table.Name);
//         }

//         options.ScriptData = false;
//         options.WithDependencies = false;

//         Console.WriteLine("\nView Scripts:");
//         foreach (SMO.View view in viewEnum) {
//            databases.Views[view.Name, schemaName].Script(options);
//            Console.WriteLine(view.Name);
//         }

//         Console.WriteLine("\nStored Procedure Scripts:");
//         foreach (SMO.StoredProcedure procedure in procedureEnum) {
//            databases.StoredProcedures[procedure.Name, schemaName].Script(options);
//            Console.WriteLine(procedure.Name);
//         }
//      }
//      catch (Exception ex) {
//         Console.WriteLine("Exception occured: " + ex.Message);
//      }
//   }
//}
