using System.Runtime.InteropServices;

namespace Blackjack
{
    public static class Window
    {
        // Sets a new window style.
        private const int GWL_STYLE = -16;

        // The window has a maximize button.
        private const int WS_MAXIMIZEBOX = 0x10000;

        // The window has a minimize button.
        private const int WS_MINIMIZEBOX = 0x20000;

        // The window has a sizing border.
        private const int WS_SIZEBOX = 0x00040000;

        // Retrieves the window handle used by the console associated with the calling process.
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();

        // Retrieves information about the specified window.
        // The function also retrieves the 32-bit (DWORD) value at the specified offset into the extra window memory. 
        [DllImport("user32.dll")]
        private static extern long GetWindowLong(IntPtr hWnd, int nIndex);

        // Changes an attribute of the specified window.
        // The function also sets the 32-bit (long) value at the specified offset into the extra window memory.
        [DllImport("user32.dll")]
        private static extern long SetWindowLong(IntPtr hWnd, int nIndex, long dwNewLong);

        public static void Modify()
        {
            var handle = GetConsoleWindow();

            var style = GetWindowLong(handle, GWL_STYLE);
            style &= ~WS_MINIMIZEBOX & ~WS_MAXIMIZEBOX & ~WS_SIZEBOX;
            SetWindowLong(handle, GWL_STYLE, style);
        }
    }
}