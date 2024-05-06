using System;

// This file is auto-generated. Do not modify or move this file.

namespace SuperUnityBuild.Generated
{
    public enum ReleaseType
    {
        None,
        Client,
        Server,
    }

    public enum Platform
    {
        None,
        PC,
    }

    public enum ScriptingBackend
    {
        None,
        Mono,
    }

    public enum Architecture
    {
        None,
        Windows_x86,
        Windows_x64,
    }

    public enum Distribution
    {
        None,
    }

    public static class BuildConstants
    {
        public static readonly DateTime buildDate = new DateTime(638506307242614600);
        public const string version = "1.0.0.1";
        public const ReleaseType releaseType = ReleaseType.Client;
        public const Platform platform = Platform.PC;
        public const ScriptingBackend scriptingBackend = ScriptingBackend.Mono;
        public const Architecture architecture = Architecture.Windows_x64;
        public const Distribution distribution = Distribution.None;
    }
}

