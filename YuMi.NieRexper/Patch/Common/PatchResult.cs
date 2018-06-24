namespace YuMi.NieRexper.Apply.Common
{
    /// <summary>
    /// Enum for representing the outcome of applying a level of choice to the save file.
    /// </summary>
    public class PatchResult
    {
        /// <summary>
        /// Outcome of the EXP patching to the save file.
        /// </summary>
        public PatchStatus Status { get; }

        /// <summary>
        /// Optional data, e.g. exception messages.
        /// </summary>
        public string Data { get; }

        /// <summary>
        /// LevelApplyResult constructor.
        /// </summary>
        /// <param name="status">Outcome of the EXP patching to the save file.</param>
        /// <param name="data">Optional data, e.g. exception messages.</param>
        public PatchResult(PatchStatus status, string data = null)
        {
            Status = status;
            Data = data;
        }
    }
}
