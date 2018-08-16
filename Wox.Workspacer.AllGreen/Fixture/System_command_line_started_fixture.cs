﻿using AllGreen.Lib;
using System.Collections.Generic;
using Wox.Workspacer.AllGreen.Helper;

namespace Wox.Workspacer.AllGreen.Fixture
{
    public class System_command_line_started_fixture : FixtureBase<WorkspacerContext>
    {
        public override IEnumerable<object> OnQuery()
        {
            foreach (var commandLineStarted in Context.ApplicationStarter.SystemService.CommandLineStarted)
            {
                yield return new Result
                {
                    Command = commandLineStarted.Command,
                    Arguments = commandLineStarted.Arguments,
                };
            }
        }

        public class Result
        {
            public string Command { get; set; }

            public string Arguments { get; set; }
        }
    }
}