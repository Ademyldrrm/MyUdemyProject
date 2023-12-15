using HotelProject.EntityLayer.Concrete;
using HotelProject.DataAccessLayer.Concrete;
using FluentValidation.AspNetCore;
using FluentValidation;
using HotelProjectWebUI.Dtos.GuestDto;
using HotelProjectWebUI.ValidationRules.GuestValidatonRules;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
builder.Services.AddHttpClient();

builder.Services.AddAutoMapper(typeof(Program));

// Add services to the container.
builder.Services.AddTransient<IValidator<CreateGuestDto>, GuestCreateValidator>();
builder.Services.AddTransient<IValidator<UpdateGuestDto>, GuestUpdateValidator>();
builder.Services.AddControllersWithViews().AddFluentValidation();
builder.Services.AddHttpClient();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
