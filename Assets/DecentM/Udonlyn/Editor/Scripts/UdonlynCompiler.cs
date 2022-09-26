using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.IO;
using UnityEditor;
using UnityEngine;
using Microsoft.CodeAnalysis.Text;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;
using UnityEngine.Rendering;
using System.Text;
using System.Reflection;
using VRC.Udon.Common.Interfaces;
using Microsoft.CSharp;
using Mono.Cecil;
using System.CodeDom.Compiler;
using System.CodeDom;

namespace DecentM.Udonlyn
{
    public class UdonlynCompiler
    {
        // Input: C# source code
        // Output: Udon program assembly source
        public string Compile(UdonlynProgramAsset program, string filename, string source)
        {
            Debug.Log("Parsing syntax tree...");

            CSharpCompilationOptions options = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);
            CSharpCompilation compilation = CSharpCompilation.Create($"UdonlynCompilation_{filename}", options: options);
            string[] defines = UdonlynUtils.GetProjectDefines();

            SyntaxTree tree = CSharpSyntaxTree.ParseText(source, CSharpParseOptions.Default.WithDocumentationMode(DocumentationMode.None).WithPreprocessorSymbols(defines));

            compilation.AddSyntaxTrees(tree);

            foreach (Diagnostic diagnostic in tree.GetDiagnostics())
            {
                if (diagnostic.Severity == DiagnosticSeverity.Error)
                {
                    LinePosition linePosition = diagnostic.Location.GetLineSpan().StartLinePosition;

                    Debug.LogError($"error {diagnostic.Descriptor.Id}: {diagnostic.GetMessage()} - {filename} line {linePosition.Line} column {linePosition.Character}");

                    // TODO: Handle error
                }
            }

            // SemanticModel model = compilation.GetSemanticModel(tree);

            /* using (MemoryStream stream = new MemoryStream())
            {
                EmitResult emission = compilation.Emit(stream);

                if (!emission.Success)
                    Debug.LogError("Emission not successful");

                Debug.Log(Encoding.UTF8.GetString(stream.ToArray()));
            } */


            return "";
        }
    }
}
