using ClosedBurger.Persistance.Context;
using ClosedBurger.WebApi.Configurations;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
builder.Services.InstallServices(builder.Configuration, typeof(IServiceInstaller).Assembly);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
using (var context = new AppDbContext()) { context.Database.Migrate(); }
app.Run();