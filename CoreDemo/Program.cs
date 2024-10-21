using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession(); // Session servisini ekliyoruz
builder.Services.AddMvc(config =>
{
	// T�m istekler i�in kullan�c� kimlik do�rulamas� talep eden bir yetkilendirme politikas� ekleniyor
	var policy = new AuthorizationPolicyBuilder()
					.RequireAuthenticatedUser()
					.Build();

	config.Filters.Add(new AuthorizeFilter(policy)); // Bu politikay� t�m MVC isteklerine uyguluyoruz
});

builder.Services.AddMvc();
builder.Services.AddAuthentication(
	CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
	{
		x.LoginPath = "/Login/Index";
	});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error"); // Hata durumunda y�nlendirme
	app.UseHsts(); // HSTS, g�venlik i�in kullan�l�yor (�retimde �nerilir)
}

// Hata sayfalar�n� ele alma
app.UseStatusCodePagesWithReExecute("/ErrorPage/Error1", "?code={0}");

// HTTPS y�nlendirme ve statik dosya servisini aktif etme
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseSession(); // Session y�netimi
app.UseRouting(); // Routing i�lemi

app.UseAuthorization(); // Yetkilendirme i�lemleri

// Varsay�lan route yap�s�
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run(); // Uygulamay� ba�lat
