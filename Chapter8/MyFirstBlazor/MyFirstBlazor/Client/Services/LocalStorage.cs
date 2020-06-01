using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace MyFirstBlazor.Client.Services
{

  public class LocalStorage : ILocalStorage
  {
    private readonly IJSRuntime jsRuntime;

    public LocalStorage(IJSRuntime jsRuntime)
    => this.jsRuntime = jsRuntime;

    public async Task<T> GetProperty<T>(string propName, T defaultValue = default)
      => await this.jsRuntime.InvokeAsync<T>("blazorLocalStorage.get", propName, defaultValue);

    public async Task<object> SetProperty<T>(string propName, T value)
      => await this.jsRuntime.InvokeAsync<object>("blazorLocalStorage.set", propName, value);

    public async Task<object> WatchAsync<T>(T instance) where T : class
      => await this.jsRuntime.InvokeAsync<object>("blazorLocalStorage.watch", DotNetObjectReference.Create<T>(instance));

  }
}
