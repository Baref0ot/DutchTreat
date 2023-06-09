using DutchTreat.Serivces;
using DutchTreat.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddTransient<IMailService, NullMailService>();
builder.Services.AddTransient<IPracticeASP, PracticeASP>();

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    app.UseDeveloperExceptionPage();
}
else {
    app.UseExceptionHandler("/error");
}





app.UseStaticFiles();
app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=App}/{action=Index}/{id?}"
    );


 app.Run();
