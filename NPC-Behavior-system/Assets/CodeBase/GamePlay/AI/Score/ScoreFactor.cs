namespace CodeBase.GamePlay.AI.Score
{
    public struct ScoreFactor
    {
        public string Name { get; }
        public float Score { get; }

        public ScoreFactor(string name, float score)
        {
            Name = name;
            Score = score;
        }

        public override string ToString() =>  $"{Name} -> {(Score >= 0 ? "+" : "")}{Score}";
    }
}