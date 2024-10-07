global using Blazored.LocalStorage;
using HRIS;
using HRIS.Contracts;
using HRIS.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Toolbelt.Blazor.Extensions.DependencyInjection;
using HRIS.Extension;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

//builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
//builder.Services.AddScoped<IAuthService, AuthService>();
//builder.Services.AddScoped<IUserService, UserService>();

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<CustomAuthStateProvider>();

//builder.Services.AddScoped<AuthenticationStateProvider>(provider => provider.GetRequiredService<CustomAuthStateProvider>());

builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IAuthenticationHttpClientService, AuthenticationHttpClientService>();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IMesinAbsenService, MesinAbsenService>();
builder.Services.AddScoped<IWorkGroupService, WorkGroupService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IPositionService, PositionService>();
builder.Services.AddScoped<IGroupService, GroupService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IExceptionTypeService, ExceptionTypeService>();
builder.Services.AddScoped<IExceptionService, ExceptionService>();
builder.Services.AddScoped<ISuratPerintahLemburService, SuratPerintahLemburService>();
builder.Services.AddScoped<IUMPService, UMPService>();
builder.Services.AddScoped<IPTKPService, PTKPService>();
builder.Services.AddScoped<IGajiDanTunjanganService, GajiDanTunjanganService>();
builder.Services.AddScoped<ILupaAbsenService, LupaAbsenService>();
builder.Services.AddScoped<IKehadiranService, KehadiranService>();
builder.Services.AddScoped<IJadwalKerjaKaryawanService, JadwalKerjaKaryawanService>();
builder.Services.AddScoped<IJamKerjaService, JamKerjaService>();
builder.Services.AddScoped<IJadwalShiftKaryawanService, JadwalShiftKaryawanService>();
builder.Services.AddScoped<IJadwalShiftSecurityServicecs, JadwalShiftSecurityService>();
builder.Services.AddScoped<IJadwalKerjaSecurityService, JadwalKerjaSecurityService>();
builder.Services.AddScoped<IAbsenPulangService, AbsenPulangService>();
builder.Services.AddScoped<IJadwalShiftDepartemenService, JadwalShiftDepartemenService>();
builder.Services.AddScoped<ILogMesinAbsenService, LogMesinAbsenService>();


//builder.Services.AddAuthorizationCore();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<IManageDepartmentsLocalStorage, ManageDepartmentsLocalStorage>();
builder.Services.AddScoped<IManagePositionLocalStorage, ManagePositionLocalStorage>();
builder.Services.AddScoped<UserService, UserService>();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<IJadwalKehadiranService, JadwalKehadiranService>();
builder.Services.AddScoped<IPayrollService, PayrollService>();

//static void AddFonts() {
//	var resources = Assembly.GetExecutingAssembly().GetManifestResourceNames();
//	foreach (var resource in resources) {
//		using var font = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource);
//		FastReport.Utils.Config.PrivateFontCollection.AddFontFromStream(font);
//	}
//}

//AddFonts();

//builder.Services.AddScoped<IPrintingService, PrintingService>();

//builder.Services.AddSyncfusionBlazor();
builder.Services.AddMudServices();
//builder.Services.AddAdminLte();
//Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NGaF1cWGhIfEx1RHxQdld5ZFRHallYTnNWUj0eQnxTdEZjUX1bcnVWQ2JdUUx0Wg==");
//builder.Services.AddScoped<DialogService>();
//builder.Services.AddScoped<NotificationService>();
//builder.Services.AddScoped<TooltipService>();
//builder.Services.AddScoped<ContextMenuService>();

var environment = await builder.GetEnvironment();

var DefaultAPI = builder.Configuration.GetValue<string>($"{environment.Environment}-baseUrl");

builder.Services.AddScoped(sp => new HttpClient {
   BaseAddress = new Uri(DefaultAPI.ToString()),
}.EnableIntercept(sp));
Console.WriteLine($"DefaultAPI: {DefaultAPI}");
//builder.Services.AddScoped(sp => new HttpClient {
//   BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
//}.EnableIntercept(sp));

builder.Services.AddHttpClientInterceptor();
builder.Services.AddScoped<HttpInterceptorService>();

await builder.Build().RunAsync();
