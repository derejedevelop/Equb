using AutoMapper;
using Equb.Helpers;
using Equb.Data;
using Equb.Repositories;
using Equb.Interfaces.Repositories;
using Equb.Services;
using Equb.Interfaces.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var services = builder.Services;

services.AddDbContext<DataContext>();
services.AddCors();
services.AddMvc();
services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();
services.AddScoped<IUserRepository, UserRepository>();
services.AddScoped<IUserService, UserService>();
services.AddScoped<IEqubRepository, EqubRepository>();
services.AddScoped<IEqubService, EqubService>();
services.AddScoped<IMemberInviteRepository, MemberInviteRepository>();
services.AddScoped<IMemberInviteService, MemberInviteService>();
services.AddScoped<ICommonRepository, CommonRepository>();
services.AddScoped<IEnrollmentService, EnrollmentService>();
services.AddScoped<IEnrollmentRepository, EnrollmentRepository>();

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new AutoMapperProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
services.AddSingleton(mapper);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseCors(x => x
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapControllers();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
