using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BlazorLifetime.Shared;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorLifetime.Client;

namespace BlazorLifetime.Client
{
  public class Program
  {
    public static async Task Main(string[] args)
    {
      var builder = WebAssemblyHostBuilder.CreateDefault(args);

      builder.Services.AddLifetime();

      builder.Services.AddSingleton(new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
      builder.RootComponents.Add<App>("app");
      await builder.Build().RunAsync();
    }
  }
}
