using System;
using System.Reflection;
using SPT.Reflection.Patching;
using UnityEngine;

namespace Fika.Headless.Patches
{
    // Token: 0x02000003 RID: 3
    public class ApplicationQuitPatch : ModulePatch
    {
        // Token: 0x06000008 RID: 8 RVA: 0x000021D4 File Offset: 0x000003D4
        protected override MethodBase GetTargetMethod()
        {
            return typeof(Application).GetMethod("Quit", new Type[] { typeof(int) });
        }

        // Token: 0x06000009 RID: 9 RVA: 0x00002210 File Offset: 0x00000410
        [PatchPrefix]
        private static bool Prefix()
        {
            Logger.LogInfo(Environment.StackTrace);
            return false;
        }
    }
}
