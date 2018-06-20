﻿using System;
using System.Collections.Generic;

namespace DockerComposeFixture
{
    public interface IDockerFixtureOptions
    {
        Func<List<string>, bool> CustomUpTest { get; set; }
        string[] DockerComposeFiles { get; set; }
        bool DebugLog { get; set; }
        string DockerComposeUpArgs { get; set; }
        string DockerComposeDownArgs { get; set; }

        void Validate();

    }
}