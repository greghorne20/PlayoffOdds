namespace Data.Model
{
    public interface ITeam
    {
        public int Losses { get; }

        public string Name { get; }

        public double PointsFor { get; }

        public double WinningPercentage { get; }

        public int Wins { get; }

        public int Ties { get; }
    }

}