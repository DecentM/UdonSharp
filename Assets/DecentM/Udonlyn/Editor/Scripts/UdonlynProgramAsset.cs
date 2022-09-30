
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;
using VRC.Udon.Editor.ProgramSources;
using VRC.Udon.Editor.ProgramSources.Attributes;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Text;

[assembly: UdonProgramSourceNewMenu(typeof(DecentM.Udonlyn.UdonlynProgramAsset), "Udonlyn C# Program Asset")]

namespace DecentM.Udonlyn
{
    [CreateAssetMenu(menuName = "VRChat/Udon/Udonlyn C# Program Asset", fileName = "New Udonlyn C# Program Asset")]
    public class UdonlynProgramAsset : UdonAssemblyProgramAsset
    {
        private string source = string.Empty;

        public UdonlynProgramAsset(string sourceFilename, string source)
        {
            this.name = sourceFilename;
            this.source = source;

            this.RefreshProgramImpl();
        }

        protected override void RefreshProgramImpl()
        {
            UdonlynCompiler compiler = new UdonlynCompiler();

            this.udonAssembly = compiler.Compile(this.name, this.source);
        }
    }
}
