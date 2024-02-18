using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using DongPhuong.Domain.Interfaces.Repositories;
using DongPhuong.Infrastructure.Data;
using DongPhuong.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

if (builder.Environment.IsDevelopment())
{
    var localDbConnectionString = builder.Configuration.GetConnectionString("LocalDbConnectionString");
    builder.Services.AddDbContext<DataContext>(options =>
        options.UseSqlServer(localDbConnectionString));
} else if (builder.Environment.IsProduction()) 
{
    var vaultUrl = builder.Configuration["VaultUrl"];
    var client = new SecretClient(vaultUri: new Uri(vaultUrl!), credential: new DefaultAzureCredential());
    var cloudDbConnectionString = client.GetSecret("DbConnectionString");
    builder.Services.AddDbContext<DataContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString(cloudDbConnectionString.Value.Value)));
}

builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
    using var scope = app.Services.CreateScope();
    var dataContext = scope.ServiceProvider.GetRequiredService<DataContext>();
    if(dataContext.Database.CanConnect()) 
        await dataContext.Database.MigrateAsync();
}

app.UseHttpsRedirection();
app.UseRouting();
app.MapControllers();

app.Run();