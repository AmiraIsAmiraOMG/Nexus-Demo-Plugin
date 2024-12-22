using PluginSystem;

namespace MyPlugin
{
    public class NotepadPlugin : IPlugin
    {
        public void Execute()
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }
    }
}