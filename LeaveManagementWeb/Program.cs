using LeaveManagementData;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using LeaveManagementWeb.Mapper;
using LeaveManagementRepositories.Contracts;
using LeaveManagementRepositories;
using Microsoft.AspNetCore.Identity.UI.Services;
using Serilog;
using LeaveManagementRepositories.Services;
using LeaveManagementRepositories.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//Adding Identity and Roles
builder.Services.AddDefaultIdentity<Employee>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();


builder.Services.AddControllersWithViews();

//current user a Controller dışındaki classlardan da ulasmayi saglar
//Yani Add... olan her şey O tipe ihtiyaç olan sınıflara IOC tarafından otomatikman inject edilir!!!
builder.Services.AddHttpContextAccessor();
//registering EmailSender
//Bana bir IEmailSender instance ı yap girilen constructor a göre bu Constructor ı biz uydurduk
//ilk parametre emailin yollanacagi adres , ikincisi port numarası , son parametre ise kimden geldigi.
//PaperCut Servisi ile email i görüntüleyecegiz.
builder.Services.AddTransient<IEmailSender>(s => new EmailSender("localhost", 25, "no@reply.leavemanagement.com"));

//register generic repos
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
//register leaveTypeService
builder.Services.AddScoped<ILeaveTypeService,LeaveTypeService>();
//register LeaveAllocationService
builder.Services.AddScoped<ILeaveAllocationService, LeaveAllocationService>();

builder.Services.AddScoped<ILeaveRequestRepository, LeaveRequestService>();

//automapper
builder.Services.AddAutoMapper(typeof(MyMapper));

builder.Host.UseSerilog((ctx, lc) =>
{
    lc.WriteTo.Console().ReadFrom.Configuration(ctx.Configuration);  
   
});


var app = builder.Build();

app.UseSerilogRequestLogging();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
