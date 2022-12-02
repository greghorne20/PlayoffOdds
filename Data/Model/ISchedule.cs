namespace Data.Model
{
    using System.Collections.Generic;
    
    public interface ISchedule 
    {
        public IReadOnlyCollection<IScheduledGame> Games { get; }
    }
}