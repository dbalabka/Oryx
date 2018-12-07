﻿// --------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// --------------------------------------------------------------------------------------------
namespace Microsoft.Oryx.BuildScriptGenerator.Node
{
    /// <summary>
    /// Build script template for NodeJs in Bash.
    /// </summary>
    public partial class NodeBashBuildScript
    {
        public NodeBashBuildScript(
            string packageInstallCommand,
            string runBuildCommand,
            string runBuildAzureCommand,
            string benvArgs)
        {
            PackageInstallCommand = packageInstallCommand ?? string.Empty;
            NpmRunBuildCommand = runBuildCommand ?? string.Empty;
            NpmRunBuildAzureCommand = runBuildAzureCommand ?? string.Empty;
            BenvArgs = benvArgs ?? string.Empty;
        }

        public string PackageInstallCommand { get; set; }
        public string NpmRunBuildCommand { get; set; }
        public string NpmRunBuildAzureCommand { get; set; }
        public string BenvArgs { get; set; }
    }
}