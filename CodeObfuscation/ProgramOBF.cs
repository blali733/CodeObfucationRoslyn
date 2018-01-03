using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.IO;

namespace CodeObfuscation
{
    class DJW$Q    {
        static void Main(string[] args)
        {
            CompilationManager compilationManager = new CompilationManager();
            Compilation compilation = compilationManager.CreateCompilation();

            foreach (SyntaxTree sourceTree in compilation.SyntaxTrees)
            {
                ClassRewriter classRewriter = new ClassRewriter();
                SyntaxNode classRewritedNode = classRewriter.Visit(sourceTree.GetRoot());
                MethodRewriter methodRewriter = new MethodRewriter();
                SyntaxNode methodRewritedNode = methodRewriter.Visit(classRewritedNode);
                OccurrenceRewriter occurrenceRewriter = new OccurrenceRewriter();
                SyntaxNode occurenceRewritedNode = occurrenceRewriter.Visit(methodRewritedNode);
                /*if (occurenceRewritedNode != sourceTree.GetRoot())
                {
                    File.WriteAllText(sourceTree.FilePath, occurenceRewritedNode.ToFullString());
                }*/
                //save without condition
                File.WriteAllText(sourceTree.FilePath, occurenceRewritedNode.ToFullString());
            }
        }
    }
}