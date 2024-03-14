using Blazor.Extensions.Canvas.Canvas2D;
using Blazor.Extensions.Canvas.WebGL;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

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

    public async Task<Canvas2DContext> CreateCanvas2DAsync()
    {
        return await new Canvas2DContext(this).InitializeAsync().ConfigureAwait(false) as Canvas2DContext;
    }

    public async Task<WebGLContext> CreateWebGLAsync()
    {
        return await new WebGLContext(this).InitializeAsync().ConfigureAwait(false) as WebGLContext;
    }

    public async Task<WebGLContext> CreateWebGLAsync(WebGLContextAttributes attributes)
    {
        return await new WebGLContext(this, attributes).InitializeAsync().ConfigureAwait(false) as WebGLContext;
    }
}
