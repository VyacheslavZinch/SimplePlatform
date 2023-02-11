using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

//Scaffold-DbContext 'Data Source=DESKTOP-5R0C0SM\SQLEXPRESS;Initial Catalog=GeneralDB;Trusted_Connection=True;Encrypt=False;' Microsoft.EntityFrameworkCore.SqlServer