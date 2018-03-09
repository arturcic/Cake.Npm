﻿using Cake.Npm.Ci;

namespace Cake.Npm.Tests.Ci
{
    internal sealed class NpmCiToolFixture : NpmFixture<NpmCiSettings>
    {
        public NpmCiToolFixture()
        {
        }

        protected override void RunTool()
        {
            var tool = new NpmCiTool(FileSystem, Environment, ProcessRunner, Tools, Log);
            tool.Install(Settings);
        }
    }
}
