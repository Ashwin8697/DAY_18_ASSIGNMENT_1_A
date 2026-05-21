using AdvancedRoutingMVC.Constraints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// Register custom route constraint
builder.Services.Configure<RouteOptions>(options =>
{
    options.ConstraintMap.Add("guidconstraint",
        typeof(GuidRouteConstraint));
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Complex Route 1
app.MapControllerRoute(
    name: "products",
    pattern: "Products/{category}/{id}",
    defaults: new
    {
        controller = "Products",
        action = "Details"
    });

// Complex Route 2
app.MapControllerRoute(
    name: "userorders",
    pattern: "Users/{username}/Orders",
    defaults: new
    {
        controller = "Users",
        action = "Orders"
    });

// GUID Constraint Route
app.MapControllerRoute(
    name: "documents",
    pattern: "Documents/{id:guidconstraint}",
    defaults: new
    {
        controller = "Documents",
        action = "Details"
    });

// Default Route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.Run();