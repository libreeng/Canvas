using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;

namespace Blazor.Extensions;

public class BECanvasComponent : ComponentBase
{
    [Parameter]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    [Parameter]
    public string Class { get; set; }

    [Parameter]
    public string Style { get; set; }

    [Parameter]
    public long Height { get; set; }

    [Parameter]
    public long Width { get; set; }

    [Inject]
    internal IJSRuntime JSRuntime { get; set; }

    protected ElementReference _canvasRef;

    public ElementReference CanvasReference => this._canvasRef;
}
