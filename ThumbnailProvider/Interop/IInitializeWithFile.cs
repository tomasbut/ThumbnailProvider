using System.Runtime.InteropServices;
using Windows.Win32.System.Com;

namespace ThumbnailProvider.Interop;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("b7d14566-0509-4cce-a71f-0a554233bd9b")]
public interface IInitializeWithFile
{
    [PreserveSig]
    int Initialize([MarshalAs(UnmanagedType.LPWStr)] string pszFilePath, STGM grfMode);
}