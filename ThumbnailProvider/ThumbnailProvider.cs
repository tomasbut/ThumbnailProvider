using System.Drawing;
using System.Runtime.InteropServices;
using ThumbnailProvider.Interop;
using Windows.Win32.System.Com;
using Windows.Win32.UI.Shell;

namespace ThumbnailProvider;

[ComVisible(true)]
[ClassInterface(ClassInterfaceType.None)]
[Guid(Constants.ThumbnailProviderCLSID)]
public class ThumbnailProvider : IThumbnailProvider, IInitializeWithStream
{
    public int GetThumbnail(uint cx, out IntPtr phbmp, out WTS_ALPHATYPE pdwAlpha)
    {
        int thumbnailWidth = (int)cx;
        int thumbnailHeight = (int)cx;

        phbmp = IntPtr.Zero;
        pdwAlpha = WTS_ALPHATYPE.WTSAT_UNKNOWN;

        // Generate blue thumbnail
        var thumbnail = new Bitmap(thumbnailWidth, thumbnailHeight);
        using (var graphics = Graphics.FromImage(thumbnail))
        {
            var rectangle = new Rectangle(0, 0, thumbnailWidth, thumbnailHeight);
            graphics.FillRectangle(Brushes.Blue, rectangle);
        }

        phbmp = thumbnail.GetHbitmap();
        pdwAlpha = WTS_ALPHATYPE.WTSAT_ARGB;

        return 0;
    }

    public int Initialize(IStream pstream, uint grfMode)
    {
        // do something with the stream
        return 0;
    }
}
