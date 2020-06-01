using Microsoft.AspNetCore.Components;
using System;

namespace MyFirstBlazor.Components
{
  public partial class DismissableAlert
  {
    private bool show;
    [Parameter]
    public bool Show
    {
      get => this.show;
      set
      {
        if (value != this.show)
        {
          this.show = value;
          ShowChanged.InvokeAsync(this.show);
        }
      }
    }

    [Parameter]
    public EventCallback<bool> ShowChanged { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    public void Dismiss()
      => Show = false;
  }
}
