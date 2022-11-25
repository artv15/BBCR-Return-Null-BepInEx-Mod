using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace BBCR_Return_Null_Mod
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            Harmony patcher = new Harmony("TheFallenProject.NullMod.Patcher");
            // Plugin startup logic
            Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
            patcher.PatchAll(typeof(MainMenuPatcher));
            Logger.LogInfo("All patches have been applied!");
        }
    }

    internal class MainMenuPatcher
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(MainMenu), "Start")]
        public static void Start()
        {
            var lgr = new ManualLogSource("MenuPatch");
            lgr.LogMessage("Tried to update teh values!");
            Singleton<PlayerFileManager>.Instance.flags[4] = false;
            Singleton<PlayerFileManager>.Instance.flags[5] = false;
            Singleton<PlayerFileManager>.Instance.flags[0] = true;
        }
    }
}