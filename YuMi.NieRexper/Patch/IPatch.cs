using YuMi.NieRexper.Apply.Common;

namespace YuMi.NieRexper.Apply
{
    /// <summary>
    /// Interface to be implemented by NieR:Automata EXP patchers.
    /// </summary>
    public interface IPatch
    {
        /// <summary>
        /// Patch experience points to a resource.
        /// </summary>
        /// <param name="amount">Amount of EXP to patch to the resource.</param>
        /// <returns>Result object representing the outcome of the patch procedure.</returns>
        PatchResult Patch(int amount);
    }
}
