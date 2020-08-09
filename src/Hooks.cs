using Harmony;
using System;
using System.Reflection;
using UnityEngine;

namespace AudicaModding
{
    internal static class Hooks
    {
        public static void ApplyHooks(HarmonyInstance instance)
        {
            instance.PatchAll(Assembly.GetExecutingAssembly());
        }

        [HarmonyPatch(typeof(Gun), "AdjustAutoaimedPosition", new Type[] { typeof(Target), typeof(Vector3), typeof(int), typeof(bool) })]
        private static class PatchAdjustPosition
        {
            private static bool Prefix(Gun __instance, Target target, Vector3 intersection, int firepointHistoryIndex, bool forceForAutoplay, ref Vector3 __result)
            {
                return false;
            }
            private static void Postfix(Gun __instance, Target target, Vector3 intersection, int firepointHistoryIndex, bool forceForAutoplay, ref Vector3 __result)
            {
                __result = intersection;
            }
        }
	}
}