namespace CardyWasm.Classes;

using Microsoft.JSInterop;

public class AlertService
{
    private readonly IJSRuntime _jsRuntime;

    public AlertService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task ShowAlert(string message)
    {
        await _jsRuntime.InvokeVoidAsync("alert", message);
    }
}