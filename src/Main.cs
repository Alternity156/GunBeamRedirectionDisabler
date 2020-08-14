using MelonLoader;
using Harmony;

namespace AudicaModding
{
    public class AudicaMod : MelonMod
    {
        public static class BuildInfo
        {
            public const string Name = "GunBeamRedirectionDisabler";  // Name of the Mod.  (MUST BE SET)
            public const string Author = "Alternity"; // Author of the Mod.  (Set as null if none)
            public const string Company = null; // Company that made the Mod.  (Set as null if none)
            public const string Version = "1.1.1"; // Version of the Mod.  (MUST BE SET)
            public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
        }

        public override void OnApplicationStart()
        {
            HarmonyInstance instance = HarmonyInstance.Create("AudicaMod");
        }
    }
}



