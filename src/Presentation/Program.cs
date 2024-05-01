using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
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

if (builder.Environment.IsDevelopment())
{
    var localDbConnectionString = builder.Configuration.GetConnectionString("LocalDbConnectionString");
    builder.Services.AddDbContext<DataContext>(options =>
        options.UseSqlServer(localDbConnectionString));
}
else if (builder.Environment.IsProduction())
{
    var vaultUrl = builder.Configuration["VaultUrl"];
    var client = new SecretClient(new Uri(vaultUrl!), new DefaultAzureCredential());
    var cloudDbConnectionString = client.GetSecret("DbConnectionString");
    builder.Services.AddDbContext<DataContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString(cloudDbConnectionString.Value.Value)));
}

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
builder.Services.AddScoped<DatabaseInitializer>();

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
    var dbInitializer = scope.ServiceProvider.GetRequiredService<DatabaseInitializer>();
    await dbInitializer.SeedData();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseCors(o =>
{
    o.AllowAnyHeader();
    o.AllowAnyMethod();
    o.WithOrigins("https://localhost:3000");
    o.AllowCredentials();
});

app.UseAuthorization();
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