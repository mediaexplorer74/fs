namespace FSClient.Shared.Providers
{
    public class UpDownRatingVote : IRatingVote
    {
        public bool? UpVoted;
        public bool? DownVoted;
        private bool v1;
        private bool v2;

        public UpDownRatingVote(bool v1, bool v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}
