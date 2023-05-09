using E_mail_Management_Domain.Interfaces;
using E_mail_Management_Infrastructure.Context;
using E_mail_Management_Infrastructure.Repositories;
using E_mail_Management_MVC.AutoMapper;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Criando a connectionString
var conectionString = builder.Configuration.GetConnectionString("DataBase");

builder.Services.AddDbContext<Email_Management_Context>(options =>
    options.UseSqlServer(conectionString));

//Inje��o de depend�ncia dos repositorios
builder.Services.AddScoped<IBusinessRepository, BusinessRepository>();

//AutoMapper - todas as confg
builder.Services.AddAutoMapper(typeof(Email_Management_Mapper));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
