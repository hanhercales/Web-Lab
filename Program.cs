var builder = WebApplication.CreateBuilder(args);

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
    name: "admin_student",
    pattern: "Admin/Student/",
    defaults: new { controller = "Student", action = "Index"});

app.MapControllerRoute(
    name: "admin_student_list",
    pattern: "Admin/Student/List",
    defaults: new { controller = "Student", action = "Index" });

app.MapControllerRoute(
    name: "admin_student_add",
    pattern: "Admin/Student/Add",
    defaults: new { controller = "Student", action = "Create" });

app.MapControllerRoute(
    name: "admin_branches_list",
    pattern: "Admin/Branches/List",
    defaults: new { controller = "Student", action = "Branches" });

app.MapControllerRoute(
    name: "admin_students_list",
    pattern: "Admin/Students/List",
    defaults: new { controller = "Student", action = "Students" });

app.MapControllerRoute(
    name: "admin_subjects_list",
    pattern: "Admin/Subjects/List",
    defaults: new { controller = "Student", action = "Subjects" });

app.MapControllerRoute(
    name: "admin_courses_list",
    pattern: "Admin/Courses/List",
    defaults: new { controller = "Student", action = "Courses" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();