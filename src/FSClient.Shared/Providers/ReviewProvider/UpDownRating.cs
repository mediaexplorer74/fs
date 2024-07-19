namespace FSClient.Shared.Providers
{
    public class UpDownRating(int UpCount, int DownCount,
        bool UpVoted, bool DownVoted,
        bool DownVoteVisible = true,
        bool CanVote = false) : IRating
    {
        public int UpCount;
        public int DownCount;
        public bool UpVoted;
        public bool DownVoted;
        public bool DownVoteVisible;

        public double Value => UpCount + DownCount is var total && total == 0 ? 0.5f : (double)UpCount / total;

        public bool HasAnyVote => UpCount > 0 || DownCount > 0;

        public bool CanVote => throw new System.NotImplementedException();

        public override string ToString()
        {
            return Value.ToString("0.00");
        }
    }
}
