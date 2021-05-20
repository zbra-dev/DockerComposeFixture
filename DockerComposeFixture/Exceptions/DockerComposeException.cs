﻿using System;

namespace DockerComposeFixture.Exceptions
{
    public class DockerComposeException:Exception
    {
        public DockerComposeException(string[] loggedLines):base($"docker-compose failed - see {nameof(DockerComposeOutput)} property")
        {
            this.DockerComposeOutput = loggedLines;
        }

        public string[] DockerComposeOutput { get; set; }
    }
}
