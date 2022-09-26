using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace DecentM.Udonlyn
{
    public static class UdonlynContextMenus
    {
        [MenuItem("Assets/Create/Udonlyn C# Program", false, 1)]
        public static void CreateUdonlynProgram()
        {
            ProjectWindowUtil.CreateAssetWithContent("Program.ulyn", string.Empty);
        }
    }
}
