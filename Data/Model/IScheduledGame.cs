namespace Data.Model
{
    public interface IScheduledGame
    {
        public ITeam Home { get; }

        public ITeam Away { get; }
    }
}