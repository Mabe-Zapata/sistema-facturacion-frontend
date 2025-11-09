using BlazorColorPicker;
using Blazored.LocalStorage;
using Soenneker.Blazor.TomSelect.Registrars;
using Soenneker.Blazor.FilePond.Registrars;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Components.Authorization;
using sistemaFacturacion;
using sistemaFacturacion.Components;

namespace sistemaFacturacion
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7084")
            });

            builder.Services.AddColorPicker();
            builder.Services.AddSweetAlert2();
            builder.Services.AddFilePondInteropAsScoped();
            builder.Services.AddTomSelectInteropAsScoped();
            builder.Services.AddBlazoredLocalStorage();

            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<AuthService>();
            builder.Services.AddScoped<CustomAuthStateProvider>();
            builder.Services.AddScoped<SessionService>();

            builder.Services.AddScoped<AuthenticationStateProvider>(provider =>
                provider.GetRequiredService<CustomAuthStateProvider>());

            builder.Services.AddSingleton<AppState>();
            builder.Services.AddScoped<StateService>();
            builder.Services.AddScoped<IActionService, ActionService>();
            builder.Services.AddScoped<MenuDataService>();
            builder.Services.AddScoped<NavScrollService>();
            builder.Services.AddScoped<ScriptLoaderService>();

            builder.Services.AddWMBOS();
            builder.Services.AddWMBSC();

            builder.Services.AddScoped<IClientesApiClient, ClientesApiClient>();

            await builder.Build().RunAsync();
        }
    }
}
