namespace FSClient.Shared.Services
{
    using System;
    using System.Collections.Generic;

    public class ChangelogEntity
    {
        public Version? Version { get; set; }

        public bool? ShowOnStartup { get; set; } = true;

        public IEnumerable<string>? Changes { get; set; }
    }
}
