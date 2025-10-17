using CurrieTechnologies.Razor.SweetAlert2;
using Service.Interfaces;
using Service.Services;
using Web.Components;
using Web.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// caching memory   
builder.Services.AddMemoryCache();
// Auth service que usa el provider
builder.Services.AddScoped<FirebaseAuthService>();

// Registra el AuthenticationHandler
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<FirebaseAuthService>();
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
builder.Services.AddScoped<ILibroService, LibroService>();
builder.Services.AddScoped<IPrestamoService, PrestamoService>();
builder.Services.AddSweetAlert2();


// Configurar HttpClient
builder.Services.AddHttpClient();

// Configurar opciones de circuito para errores detallados
builder.Services.Configure<Microsoft.AspNetCore.Components.Server.CircuitOptions>(options =>
{
    options.DetailedErrors = builder.Environment.IsDevelopment();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();