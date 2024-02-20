using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using DongPhuong.Infrastructure.Data;
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

builder.Services.AddAuthorization();
builder.Services.AddIdentityApiEndpoints<IdentityUser>()
    .AddEntityFrameworkStores<DataContext>();
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
    if (dataContext.Database.CanConnect())
        await dataContext.Database.MigrateAsync();
}

app.UseHttpsRedirection();
app.UseRouting();
app.MapIdentityApi<IdentityUser>();
app.MapControllers();

app.Run();