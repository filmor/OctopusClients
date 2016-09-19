﻿using System.Threading.Tasks;
using Octopus.Client;
using Octopus.Client.Model;

namespace Octopus.Cli.Commands
{
    public interface IReleasePlanBuilder
    {
        Task<ReleasePlan> Build(IOctopusRepository repository, ProjectResource project, ChannelResource channel, string versionPreReleaseTag);
    }
}