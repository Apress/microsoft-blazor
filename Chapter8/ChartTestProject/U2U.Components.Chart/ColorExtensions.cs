using System.Drawing;

namespace U2U.Components.Chart
{
  public static class ColorExtensions
  {
    public static string ToJs(this Color c)
    => $"rgba({c.R}, {c.G}, {c.B}, {c.A})";
  }
}
