namespace UserinterfaceTest.Utils
{
    public static class InputSimulator
    {
        public static void UploadImage(string imagePath)
        {
            WindowsInput.InputSimulator inputSimulator = new();
            inputSimulator.Keyboard.Sleep(1000).TextEntry(Path.GetFullPath(imagePath)).Sleep(1000).
            KeyPress(WindowsInput.Native.VirtualKeyCode.RETURN);
        }
    }
}
