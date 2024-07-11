using System.Runtime.InteropServices;
using Windows.Win32.System.Com;
using Windows.Win32.UI.Shell;

namespace ThumbnailProvider.Interop;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("7f73be3f-fb79-493c-a6c7-7ee14e245841")]
public interface IInitializeWithItem
{
    [PreserveSig]
    int Initialize(IShellItem shellItem, STGM accessMode);
}
