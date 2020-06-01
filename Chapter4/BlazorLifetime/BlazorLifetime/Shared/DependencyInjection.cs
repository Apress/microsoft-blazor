using Microsoft.Extensions.DependencyInjection;

namespace BlazorLifetime.Shared
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddLifetime(this IServiceCollection services)
    {
      services.AddSingleton<SingletonService>();
      services.AddTransient<TransientService>();
      services.AddScoped<ScopedService>();
      return services;
    }
  }
}
