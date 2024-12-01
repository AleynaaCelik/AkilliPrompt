using Azure.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


var builder = WebApplication.CreateBuilder(args);

//// Azure Key Vault yap�land�rmas�
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
builder.Services.AddOpenApi(); // Swagger/OpenAPI deste�i ekleme

var app = builder.Build();

// HTTP pipeline yap�land�rmas�
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi(); // Swagger dok�mantasyonu geli�tirme ortam�nda
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
