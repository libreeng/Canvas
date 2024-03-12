using Blazor.Extensions.Canvas.Canvas2D;
using Blazor.Extensions.Canvas.WebGL;
using System.Threading.Tasks;

namespace Blazor.Extensions;

public static class CanvasContextExtensions
{
    public static async Task<Canvas2DContext> CreateCanvas2DAsync(this BECanvasComponent canvas)
    {
        return await new Canvas2DContext(canvas).InitializeAsync().ConfigureAwait(false) as Canvas2DContext;
    }

    public static async Task<WebGLContext> CreateWebGLAsync(this BECanvasComponent canvas)
    {
        return await new WebGLContext(canvas).InitializeAsync().ConfigureAwait(false) as WebGLContext;
    }

    public static async Task<WebGLContext> CreateWebGLAsync(this BECanvasComponent canvas, WebGLContextAttributes attributes)
    {
        return await new WebGLContext(canvas, attributes).InitializeAsync().ConfigureAwait(false) as WebGLContext;
    }
}
