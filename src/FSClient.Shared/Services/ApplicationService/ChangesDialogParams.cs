namespace FSClient.Shared.Services
{
    using System;
    using System.Collections.Generic;

    public class ChangesDialogInput
    {
        public IEnumerable<ChangelogEntity> Changelog;

        public ChangesDialogInput(IEnumerable<ChangelogEntity> changelog)
        {
            Changelog = changelog;
        }

        public Version? UpdateVersion { get; set; }

        public Version? ShowFromVersion { get; set; }

        public Version? ShowToVersion { get; set; }
    }

    public class ChangesDialogOutput
    {
        public bool ShouldOpenUpdatePage { get; set; }
    }
}
