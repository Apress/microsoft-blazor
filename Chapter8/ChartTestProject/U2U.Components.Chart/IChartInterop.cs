namespace U2U.Components.Chart
{
  public interface IChartInterop
  {
    void CreateLineChart(string id, LineChartData data,
                                ChartOptions options);
  }
}
