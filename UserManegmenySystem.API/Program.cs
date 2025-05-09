using DomainLayer.Data;
using DomainLayer.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Repositorylayer;
using Servicelayer.Sevices;
using Servicelayer;
using Servicelayer.Sevices;
using Servicelayer.Sreibce;
using UserManegmenySystem.API;
using UserManegmenySystem.API.Extrntion;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<MangementSystemDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Conn"));
    });




builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGenJwtAuth();
builder.Services.AddCustomJwtAuth(builder.Configuration);


builder.Services.AddSwaggerGen(c =>
{
    c.OperationFilter<AddSwaggerDefaultResponseFilter>();
});


#region Service Injected
builder.Services.AddScoped(typeof(IRrepositry<>),typeof(Repostiry<>));
builder.Services.AddScoped<ICoustmsServices<Student>, ModelStudentSirvec>(); 
builder.Services.AddScoped<ICoustmsServices<Department>,ModelDepartmentSirvsc>();
builder.Services.AddScoped<ICoustmsServices<Resules1>, ModelResultSirvec>();
builder.Services.AddScoped<ICoustmsServices<SubjectGpa>, MolelSubjectGpaSirvec>();
#endregion

builder.Services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<MangementSystemDbContext>();


var app = builder.Build();


// Configure the HTTP request pipeline.+ app null Microsoft.AspNetCore.Builder.WebApplication

if (app.Environment.IsDevelopment())
{
     app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();