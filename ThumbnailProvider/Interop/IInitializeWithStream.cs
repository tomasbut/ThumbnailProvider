using System.Runtime.InteropServices;
using Windows.Win32.System.Com;

namespace ThumbnailProvider.Interop;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("b824b49d-22ac-4161-ac8a-9916e8fa3f7f")]
public interface IInitializeWithStream
{
    [PreserveSig]
    int Initialize(IStream pstream, uint grfMode);
}
