using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlazor.Client.Pages
{
  public partial class LifeCycle : IDisposable
  {
    public LifeCycle()
    {
      Console.WriteLine($"Ctor [{Param}]");
    }

    protected override Task OnInitializedAsync()
    {
      Console.WriteLine("Initialized [{Param}]");
      return base.OnInitializedAsync();
    }


    protected override Task OnParametersSetAsync()
    {
      Console.WriteLine($"OnParametersSet [{Param}]");
      return base.OnParametersSetAsync();
    }

    public override async Task SetParametersAsync(ParameterView parameters)
    {
      Console.WriteLine($"SetParameters [{Param}]");
      foreach (var p in parameters)
      {
        Console.WriteLine($"Name {p.Name} = {p.Value} - {p.Cascading}");
      }
      if (parameters.TryGetValue(nameof(Param), out int par))
      {
        Console.WriteLine($"Got {par}");
        if (par % 2 == 1)
        {
          par += 1;
          this.Param = par;
          this.StateHasChanged();
          return;
        }
      }
      await base.SetParametersAsync(parameters);
    }

    protected override Task OnAfterRenderAsync(bool firstRender)
    {
      Console.WriteLine($"OnAfterRender({firstRender})");
      return base.OnAfterRenderAsync(firstRender);
    }

    public void Dispose() => Console.WriteLine("Disposed");

    [Parameter]
    public int Param { get; set; } = -1;
  }
}
