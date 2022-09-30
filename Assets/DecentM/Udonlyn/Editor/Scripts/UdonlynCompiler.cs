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
using System;

namespace DecentM.Udonlyn
{
    public class UdonlynCompiler
    {
        // Input: C# source code
        // Output: Udon program assembly source
        public string Compile(string id, string source)
        {
            Debug.Log("Parsing syntax tree...");

            CSharpCompilationOptions options = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);
            CSharpCompilation compilation = CSharpCompilation.Create($"UdonlynCompilation_{id}", options: options);
            string[] defines = UdonlynUtils.GetProjectDefines();

            SyntaxTree tree = CSharpSyntaxTree.ParseText(source, CSharpParseOptions.Default.WithDocumentationMode(DocumentationMode.None).WithPreprocessorSymbols(defines));

            // https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/get-started/syntax-transformation
            // CompilationUnitSyntax root = (CompilationUnitSyntax)tree.GetRoot();
            
            // SyntaxList<UsingDirectiveSyntax> usings = root.Usings;
            // Debug.Log(root.ToString());

            compilation.AddSyntaxTrees(tree);

            foreach (Diagnostic diagnostic in tree.GetDiagnostics())
            {
                if (diagnostic.Severity != DiagnosticSeverity.Error)
                    continue;

                LinePosition linePosition = diagnostic.Location.GetLineSpan().StartLinePosition;
                Debug.LogError($"error {diagnostic.Descriptor.Id}: {diagnostic.GetMessage()} - {id} line {linePosition.Line} column {linePosition.Character}");

                // TODO: Handle the error better
            }

            // SemanticModel model = compilation.GetSemanticModel(tree);

            byte[] builtAssembly = null;

            using (MemoryStream stream = new MemoryStream())
            {
                EmitResult emission = compilation.Emit(stream);

                if (!emission.Success)
                    Debug.LogError("Emission not successful");

                builtAssembly = stream.ToArray();

                Debug.Log("C# assembly built");
            }

            Assembly assembly = null;

            try
            {
                // TODO: WTF is this line? I'm assuming it somehow removes unused code from the assembly.
                // using (new UdonSharpUtils.UdonSharpAssemblyLoadStripScope())
                // https://github.com/vrchat-community/UdonSharp/blob/master/Packages/com.vrchat.UdonSharp/Editor/Compiler/UdonSharpCompilerV1.cs#L575
                assembly = Assembly.Load(builtAssembly);
            }
            catch (Exception e)
            {
                // TODO: Handle error
                Debug.LogException(e);
                return "";
            }

            return "";
        }
    }
}
