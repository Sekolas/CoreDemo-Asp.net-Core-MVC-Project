using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession(); // Session servisini ekliyoruz
builder.Services.AddMvc(config =>
{
	// Tüm istekler için kullanýcý kimlik doðrulamasý talep eden bir yetkilendirme politikasý ekleniyor
	var policy = new AuthorizationPolicyBuilder()
					.RequireAuthenticatedUser()
					.Build();

	config.Filters.Add(new AuthorizeFilter(policy)); // Bu politikayý tüm MVC isteklerine uyguluyoruz
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
	app.UseExceptionHandler("/Home/Error"); // Hata durumunda yönlendirme
	app.UseHsts(); // HSTS, güvenlik için kullanýlýyor (Üretimde önerilir)
}

// Hata sayfalarýný ele alma
app.UseStatusCodePagesWithReExecute("/ErrorPage/Error1", "?code={0}");

// HTTPS yönlendirme ve statik dosya servisini aktif etme
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseSession(); // Session yönetimi
app.UseRouting(); // Routing iþlemi

app.UseAuthorization(); // Yetkilendirme iþlemleri

// Varsayýlan route yapýsý
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run(); // Uygulamayý baþlat
