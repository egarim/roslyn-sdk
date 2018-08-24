﻿using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Testing.NUnit
{
    public static class CodefixVerifier
    {
        public static CodefixVerifier<TAnalyzer, TCodefix> Create<TAnalyzer, TCodefix>()
            where TAnalyzer : DiagnosticAnalyzer, new()
            where TCodefix : CodeFixProvider, new()
        {
            return new CodefixVerifier<TAnalyzer, TCodefix>();
        }
    }
}
