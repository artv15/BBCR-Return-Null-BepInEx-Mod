using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

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
            patcher.PatchAll(typeof(NullCheckPatcher));
            Logger.LogInfo("All patches have been applied!");
        }
    }

    internal class MainMenuPatcher
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(MainMenu), "Start")]
        internal static void Start()
        {
            var lgr = new ManualLogSource("MenuPatch");
            lgr.LogMessage("Tried to update teh values!");
            Singleton<PlayerFileManager>.Instance.flags[4] = false;
            Singleton<PlayerFileManager>.Instance.flags[5] = false;
            Singleton<PlayerFileManager>.Instance.flags[0] = true;
        }
    }

    internal class NullCheckPatcher
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(PlayerFileManager), "NullCheck")]
        internal static bool NullCkeckPrefix(PlayerFileManager __instance)
        {
            __instance.flags[4] = false; //have beaten null?
            __instance.flags[5] = false; //no idea
            __instance.flags[0] = true; //no idea as well, but it's referenced in the MainMenu.Start() code.
            return false; // no null check for today, bye!
        }
    }
}