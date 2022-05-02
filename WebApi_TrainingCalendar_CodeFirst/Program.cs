using Microsoft.EntityFrameworkCore;
using WebApi_TrainingCalendar_CodeFirst.Data;
using WebApi_TrainingCalendar_CodeFirst.Models;
using WebApi_TrainingCalendar_CodeFirst.Models.Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbcontext>(opts => opts.UseSqlServer(
builder.Configuration.GetConnectionString("MyConString")));
builder.Services.AddScoped<IDataRepository<TrainingDetailsModel>, DataRepository>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options => {
    options.AddPolicy(name: "MyPolicy",
        builder =>
        {
            builder.WithOrigins("https://localhost:44319",
                                "http://localhost:4200")
                    .WithMethods("POST", "PUT", "DELETE", "GET","PUT")
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();



        });
});
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseCors();
app.Run();








