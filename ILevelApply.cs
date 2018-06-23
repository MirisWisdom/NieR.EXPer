namespace YuMi.NieRexper
{
    /// <summary>
    /// Interface to be implemented by objects that apply experients points.
    /// </summary>
    public interface ILevelApply
    {
        /// <summary>
        /// Apply experience points to the specified save file.
        /// </summary>
        /// <param name="amount">Amount of EXP.</param>
        /// <param name="path">Save file location.</param>
        /// <returns>Result object representing the outcome of the patch procedure.</returns>
        LevelApplyResult Apply(int amount, string path);
    }
}
