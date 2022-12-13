using Microsoft.EntityFrameworkCore;
using TestCI_app_SLN.Models;

var builder = WebApplication.CreateBuilder(args);

//var myconfig = builder.Configuration["Myconfig"];

builder.Services.AddControllersWithViews();

//builder.Services.AddTransient<IPostService, PostService>();
//builder.Services.AddTransient<IUserService, UserService>();
//builder.Services.AddTransient<IVoteService, VoteService>();
//builder.Services.AddTransient<ISessionService, SessionService>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();
var config = builder.Services.BuildServiceProvider().GetService<IConfiguration>();
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

var app = builder.Build();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseStaticFiles();
app.UseRouting();
app.UseSession();
app.MapControllers();

app.Run();

public partial class Program { }
