using Azure.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


var builder = WebApplication.CreateBuilder(args);

//// Azure Key Vault yapılandırması
//builder.Configuration.AddAzureKeyVault(
//    new Uri(builder.Configuration["AzureKeyVaultSettings:Uri"]),
//    new ClientSecretCredential(
//        builder.Configuration["AzureKeyVaultSettings:TenantId"],
//        builder.Configuration["AzureKeyVaultSettings:ClientId"],
//        builder.Configuration["AzureKeyVaultSettings:ClientSecret"]
//    )
//);

// Servisleri ekle
builder.Services.AddControllers();
builder.Services.AddOpenApi(); // Swagger/OpenAPI desteği ekleme

var app = builder.Build();

// HTTP pipeline yapılandırması
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi(); // Swagger dokümantasyonu geliştirme ortamında
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
