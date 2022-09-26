
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
        public UdonlynProgramAsset(string filename, string source)
        {
            Debug.Log($"Compiling {filename}");

            SyntaxTree tree = CSharpSyntaxTree.ParseText(source);
            CSharpCompilationOptions options = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);
            CSharpCompilation compilation = CSharpCompilation.Create($"UdonlynCompilation_{filename}", syntaxTrees: new[] { tree }, null, options);
            // SemanticModel model = compilation.GetSemanticModel(tree);

            byte[] builtAssembly = null;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                EmitResult emitResult = compilation.Emit(memoryStream);
                if (emitResult.Success)
                {
                    builtAssembly = memoryStream.ToArray();
                }
                else
                {
                    foreach (Diagnostic diag in emitResult.Diagnostics)
                    {
                        if (diag.Severity == DiagnosticSeverity.Error)
                        {
                            // TODO: Let the user know about errors

                            // From UdonSharp:
                            // compilationContext.AddDiagnostic(DiagnosticSeverity.Error, diag.Location, $"{diag.Severity.ToString().ToLower()} {diag.Id}: {diag.GetMessage()}");
                        }
                    }
                }
            }

            // TODO: There are a bunch of checks here in UdonSharp to check that abstract classes are not used as if they were sealed and other stuff

            // Debug.Log(model);
        }

        protected override void RefreshProgramImpl()
        {
            this.udonAssembly = "";
        }
    }
}
