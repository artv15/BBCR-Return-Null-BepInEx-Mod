using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

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
        internal static void Start(MainMenu __instance)
        {
            if (PlayerPrefs.GetInt("hasNullInstalledAnnounced") != 1) 
            { 
                Traverse menuTraverse = Traverse.Create(__instance); // i hate private fields. all my homies hate private fields.
                AudioManager audMan = menuTraverse.Field("audMan").GetValue<AudioManager>();
                TMP_Text unlockText = menuTraverse.Field("unlockTmp").GetValue<TMP_Text>();
                menuTraverse.Field("unlockNotif").SetValue(true);
                menuTraverse.Field("startDelay").SetValue(10f);

                __instance.unlockScreen.SetActive(true);
                unlockText.text = "Return null mod has been succesfully installed! Good job!";
                audMan.PlaySingle(__instance.audWow);
                PlayerPrefs.SetInt("hasNullInstalledAnnounced", 1);
            }
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