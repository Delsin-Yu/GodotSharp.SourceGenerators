﻿using GodotSharp.SourceGenerators.Utilities;

namespace GodotSharp.SourceGenerators.SceneTreeExtensions
{
    internal static class Diagnostics
    {
        public static DiagnosticDetail SceneFileNotFound(string tscn) => new DiagnosticDetail { Title = "Scene file not found", Message = $"Could not find scene file: {tscn}" };
    }
}
