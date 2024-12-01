using AkilliPrompt.WebApi.Controllers;

var builder = WebApplication.CreateBuilder(args);

// appsettings.json'dan ayarlarý yükleme
var apiUrl = builder.Configuration["Settings:ApiUrl"];
var clientId = builder.Configuration["Settings:ClientId"];
var clientSecret = builder.Configuration["Settings:ClientSecret"];

// Örnek: Servislerinize ayarlarý aktarabilirsiniz
builder.Services.AddSingleton(new ApiService(apiUrl, clientId, clientSecret));

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
