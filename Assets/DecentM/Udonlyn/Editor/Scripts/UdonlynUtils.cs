using System.Collections.Generic;

namespace DecentM.Udonlyn
{
    public static class UdonlynUtils
    {
        internal static string[] GetProjectDefines()
        {
            List<string> defines = new List<string>();

            foreach (string define in UnityEditor.EditorUserBuildSettings.activeScriptCompilationDefines)
            {
                if (define.StartsWith("UNITY_EDITOR"))
                    continue;

                defines.Add(define);
            }

            defines.Add("COMPILER_UDONLYN");

            return defines.ToArray();
        }
    }
}
