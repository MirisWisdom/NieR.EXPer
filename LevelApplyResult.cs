namespace YuMi.NieRexper
{
    public class LevelApplyResult
    {
        public LevelApplyStatus Status { get; }
        public string Data { get; }

        public LevelApplyResult(LevelApplyStatus status, string data = null)
        {
            Status = status;
            Data = data;
        }
    }
}
