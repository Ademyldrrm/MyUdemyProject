using HotelProject.EntityLayer.Concrete;
using HotelProject.DataAccessLayer.Concrete;
using FluentValidation.AspNetCore;
using FluentValidation;
using HotelProjectWebUI.Dtos.GuestDto;
using HotelProjectWebUI.ValidationRules.GuestValidatonRules;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
builder.Services.AddHttpClient();

builder.Services.AddAutoMapper(typeof(Program));

// Add services to the container.
builder.Services.AddTransient<IValidator<CreateGuestDto>, GuestCreateValidator>();
builder.Services.AddTransient<IValidator<UpdateGuestDto>, GuestUpdateValidator>();
builder.Services.AddControllersWithViews().AddFluentValidation();

//automaper yapýlanmasý
builder.Services.AddAutoMapper(typeof(Program));

//Autontucation Yapýlanmasý
builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser()
    .Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});

//loginpath ile iþlemler
builder.Services.ConfigureApplicationCookie(opitons =>
{
    opitons.Cookie.HttpOnly = true;
    opitons.ExpireTimeSpan = TimeSpan.FromMinutes(10);
    opitons.LoginPath = "/Login/Index/";

});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
