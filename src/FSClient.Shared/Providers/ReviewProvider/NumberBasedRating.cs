namespace FSClient.Shared.Providers
{
    public class NumberBasedRating : IRating
    {
        public double BaseNumber;
        public double Value;
        public int? VotesCount = null;
        public double? UserVote = null;
        private int v;
        private int? v1;

        public NumberBasedRating(int v, double value)
        {
            this.v = v;
            Value = value;
        }

        public NumberBasedRating(int v, double value, int? v1) : this(v, value)
        {
            this.v1 = v1;
        }

        public bool Voted => UserVote.HasValue;

        public bool HasAnyVote => VotesCount > 0;

        // TODO NotImplemented on View layer.
        public bool CanVote => false;

        double IRating.Value => throw new System.NotImplementedException();
    }
}
