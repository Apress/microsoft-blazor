using Microsoft.Extensions.DependencyInjection;

namespace U2U.Components.Chart
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddCharts(
      this IServiceCollection services)
    => services.AddTransient<IChartInterop, ChartInterop>();
  }
}
