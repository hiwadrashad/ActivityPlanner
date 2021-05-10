using ActivityPlannerBlazor.Client.DataService;
using ActivityPlannerBlazor.Client.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ActivityPlannerBlazor.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddHttpClient("ActivityPlannerBlazor.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
                .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("ActivityPlannerBlazor.ServerAPI"));
            builder.Services.AddHttpClient<IInitialDataService, InitialDataService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44333/");
            });
            builder.Services.AddHttpClient<ICurrentOrganizerDataService, CurrentOrganizerDataService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44333/");
            });
            builder.Services.AddHttpClient<IAppointmentDataService, AppointmentDataService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44333/");
            });
            builder.Services.AddHttpClient<IAttendeeDataService, AttendeeDataService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44333/");
            });
            builder.Services.AddHttpClient<IOrganizerDataService, OrganizerDataService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44333/");
            });
            builder.Services.AddApiAuthorization();

            await builder.Build().RunAsync();
        }
    }
}
