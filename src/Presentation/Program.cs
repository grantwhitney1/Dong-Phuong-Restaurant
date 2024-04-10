using DongPhuong.Application.Handlers.Features.Drinks;
using DongPhuong.Application.Handlers.Features.PackagedGoods;
using DongPhuong.Application.Handlers.Features.PreparedGoods;
using DongPhuong.Domain.Dtos.Features.PackagedGoods;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.Drinks;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.PackagedGoods;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.PreparedGoods;
using DongPhuong.Domain.Interfaces.Domain.Entities.Base;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories.Base;
using DongPhuong.Infrastructure.Data;
using DongPhuong.Infrastructure.Services.Repositories;
using DongPhuong.Infrastructure.Services.Repositories.Base;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Environment.IsProduction()
    ? builder.Configuration.GetConnectionString("LocalDbConnectionString")
    : Environment.GetEnvironmentVariable("DbConnectionString");

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddAutoMapper(typeof(IEntity));
builder.Services.AddLogging();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IDrinksRepository, DrinksRepository>();
builder.Services.AddScoped<IPackagedGoodsRepository, PackagedGoodsRepository>();
builder.Services.AddScoped<IPreparedGoodsRepository, PreparedGoodsRepository>();

builder.Services.AddScoped<IDrinksCommandHandler, DrinksCommandHandler>();
builder.Services.AddScoped<IPackagedGoodsCommandHandler, PackagedGoodsCommandHandler>();
builder.Services.AddScoped<IPreparedGoodsCommandHandler, PreparedGoodsCommandHandler>();

builder.Services.AddScoped<IDrinksQueryHandler, DrinksQueryHandler>();
builder.Services.AddScoped<IPackagedGoodsQueryHandler, PackagedGoodsQueryHandler>();
builder.Services.AddScoped<IPreparedGoodsQueryHandler, PreparedGoodsQueryHandler>();

builder.Services.AddAuthorization();
builder.Services.AddIdentityApiEndpoints<IdentityUser>()
    .AddEntityFrameworkStores<DataContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddValidatorsFromAssemblyContaining<PackagedGoodDtoValidator>();
builder.Services.AddFluentValidationAutoValidation();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
    using var scope = app.Services.CreateScope();
    var dataContext = scope.ServiceProvider.GetRequiredService<DataContext>();
    if (dataContext.Database.CanConnect())
        await dataContext.Database.MigrateAsync();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.UseCors(o =>
{
    o.AllowAnyHeader();
    o.AllowAnyMethod();
    o.AllowAnyOrigin();
});
app.MapIdentityApi<IdentityUser>();
app.MapControllers();
app.MapPost("/logout", async (SignInManager<IdentityUser> signInManager) =>
    {
        try
        {
            await signInManager.SignOutAsync();
            return Results.Ok();
        }
        catch
        {
            return Results.Unauthorized();
        }
    })
    .RequireAuthorization();

app.Run();