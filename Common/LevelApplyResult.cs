namespace YuMi.NieRexper.Common
{
    /// <summary>
    /// Result-compliant wrapper for the LevelApplyStatus and Data string.
    /// </summary>
    public class LevelApplyResult
    {
        /// <summary>
        /// Outcome of the EXP patching to the save file.
        /// </summary>
        public LevelApplyStatus Status { get; }

        /// <summary>
        /// Optional data, e.g. exception messages.
        /// </summary>
        public string Data { get; }

        /// <summary>
        /// LevelApplyResult constructor.
        /// </summary>
        /// <param name="status">Outcome of the EXP patching to the save file.</param>
        /// <param name="data">Optional data, e.g. exception messages.</param>
        public LevelApplyResult(LevelApplyStatus status, string data = null)
        {
            Status = status;
            Data = data;
        }
    }
}
