using AutoMapper;
using gecoTM.Models;
using gecoTM.Repository.Blog;
using gecoTM.Repository.Employee;
using gecoTM.Repository.Timesheet;
using gecoTM.Repository.UpcomingEvent;
using gecoTM.Repository.WebUser;
using gecoTM.Services.Blog;
using gecoTM.Services.Employee;
using gecoTM.Services.Timesheet;
using gecoTM.Services.UpcomingEvent;
using gecoTM.Services.WebUser;
using Microsoft.EntityFrameworkCore;
using static gecoTM.CustomMiddlewares.ExceptionHanldingMiddleware;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        });
});
// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("CustomerDBConnectionString");
builder.Services.AddDbContext<TmContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddSingleton<IMapper, Mapper>();
builder.Services.AddScoped<IEmployeeRepo, EmployeeRepo>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<ITimesheetRepo, TimesheetRepo>();
builder.Services.AddScoped<ITimesheetService, TimesheetService>();
builder.Services.AddScoped<IUpcomingEventRepo, UpcomingEventRepo>();
builder.Services.AddScoped<IUpcomingEventService, UpcomingEventService>();
builder.Services.AddScoped<IWebUserService, WebUserService>();
builder.Services.AddScoped<IWebUserRepo, WebUserRepo>();
builder.Services.AddScoped<IBlogService, BlogService>();
builder.Services.AddScoped<IBlogRepo, BlogRepo>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionHandlingMiddleware>();


app.UseCors(MyAllowSpecificOrigins);
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
