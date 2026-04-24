using AOSharp.Core;
using AOSharp.Core.UI;
using AOSharp.Common.GameData;

namespace HelloWorldPlugin;

public class Main : AOPluginEntry
{
    public override void Run(string pluginDir)
    {
        Chat.WriteLine("Hello, world!", ChatColor.Green);
    }

    public override void Teardown()
    {
        Chat.WriteLine("HelloWorldPlugin unloaded.", ChatColor.Orange);
    }
}
