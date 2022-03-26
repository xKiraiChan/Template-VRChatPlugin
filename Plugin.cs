using BepInEx;
using BepInEx.IL2CPP;

namespace Template_VRChatPlugin
{
    [BepInAutoPlugin("com.github.xKiraiChan.Template_VRChatPlugin", "Template_VRChatPlugin", "0.1.0")]
    public partial class Plugin : BasePlugin
    {
        public override void Load()
        {
            // Plugin startup logic
            Log.LogInfo($"Plugin {Id} is loaded!");
        }
    }
}
