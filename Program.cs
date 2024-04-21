using App.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Cấu hình các dịch vụ cũng như đăng kí các dịch vụ mới vào app
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// builder.Services.AddSingleton<ProductService>();
// builder.Services.AddSingleton<ProductService, ProductService>();
// builder.Services.AddSingleton(typeof(ProductService));
builder.Services.AddSingleton(typeof(ProductService), typeof(ProductService));


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

app.UseAuthentication(); // Xacs didnh danh tính
app.UseAuthorization(); // Xác thực quyền truy cập

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Tạo điểm endpoints tới Razor trên app
app.MapRazorPages();



app.Run();
