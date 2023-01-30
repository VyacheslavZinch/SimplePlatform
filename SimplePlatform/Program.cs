using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

//Scaffold-DbContext 'Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GeneralDB;Trusted_Connection=True;' Microsoft.EntityFrameworkCore.SqlServer

//DESKTOP-5R0C0SM\SQLEXPRESS
//Scaffold-DbContext 'Data Source=DESKTOP-5R0C0SM\SQLEXPRESS;Initial Catalog=GeneralDB;Trusted_Connection=True;Encrypt=False;' Microsoft.EntityFrameworkCore.SqlServer