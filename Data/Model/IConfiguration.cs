namespace Data.Model
{
    using System.Collections.Generic;

    public interface IConfiguration
    {
        public IReadOnlyCollection<ITeam> Teams { get; }

        public ISchedule Schedule { get; }

        public int PlayoffTeamsCount { get; }
    }

}
