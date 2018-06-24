namespace YuMi.NieRexper.UI.Common
{
    /// <summary>
    /// Enum for representing the outcome of applying a level of choice to the save file.
    /// </summary>
    public enum LevelApplyStatus
    {
        /// <summary>
        /// The amount of EXP required for the chosen level has been successfully applied.
        /// </summary>
        Success,

        /// <summary>
        /// An exception has occurred when applying the EXP.
        /// </summary>
        Exception
    }
}
